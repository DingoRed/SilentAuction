#region Using Statements
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;
using SilentAuction.Extensions;
using SilentAuction.Forms;
using SilentAuction.Properties;
using SilentAuction.SilentAuctionDataSetTableAdapters;
using SilentAuction.Utilities;
#endregion

namespace SilentAuction
{
    public partial class MainForm : Form
    {
        #region Fields
        private readonly DonorsTableAdapter _donorsTableAdapter;
        private readonly AuctionsTableAdapter _auctionsTableAdapter;
        #endregion

        #region Properties
        public int AuctionIdInUse { get; set; }
        public string AuctionNameInUse { get; set; }
        #endregion

        #region Constructor
        public MainForm()
        {
            InitializeComponent();
            _donorsTableAdapter = new DonorsTableAdapter();
            _auctionsTableAdapter = new AuctionsTableAdapter();
        }
        #endregion
         
        #region Form Event Handlers
        private void MainFormLoad(object sender, EventArgs e)
        {
            LoadSettings();
            bidIncrementTypesTableAdapter.FillBidIncremenetTypes(silentAuctionDataSet.BidIncrementTypes);
            donationDeliveryTypesTableAdapter.FillDonationDeliveryTypes(silentAuctionDataSet.DonationDeliveryTypes);
            itemTypesTableAdapter.FillItemTypes(silentAuctionDataSet.ItemTypes);
            new DonorsTableAdapter().FillByAuctionId(silentAuctionDataSet.Donors, AuctionIdInUse);
            
            if (!Settings.Default.EULAAccepted)
            {
                Eula eula = new Eula();
                DialogResult dialogResult = eula.ShowDialog();

                if(dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
                    Application.Exit();
            }
            
            FillItems();

            SetAuctionNameAndGrid();
            SetupToolStripMenuItems();
            
            WindowSettings.SetupInitialWindow(this, "MainFormInitialLocation");
        }

        private void MainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            var silentAuctionDataSetChanges = silentAuctionDataSet.GetChanges();
            if (silentAuctionDataSetChanges != null)
            {
                var result = MessageBox.Show("You have unsaved changes.\n\rAre you sure you want to continue without saving?", "Unsaved Changes",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                e.Cancel = result == DialogResult.No; //GenericPageHelper.StayOnPage();
            }
             
            if (!e.Cancel)
            {
                WindowSettings.SaveWindowSettings(this, "MainFormInitialLocation");
                SaveSettings();
            }
        }

        #endregion

        #region Items Event Handlers
        private void ItemsDataGridViewRowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewRow row = ItemsDataGridView.Rows[e.RowIndex];
            if (row.IsNewRow && e.RowIndex > 0)
            {
                row.Cells[ItemsImageColumn.Index].Value = Constants.EmptyImage;
            }
        }

        private void ItemsDataGridViewDataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridView view = (DataGridView) sender;
            view.Rows[e.RowIndex].ErrorText = e.Exception.Message;
            view.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = e.Exception.Message;

            MainFormStatusLabel.Text = e.Exception.Message;
            MainFormStatusLabel.Visible = true;

            e.Cancel = true;
        }

        private void ItemsDataGridViewDefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            DateTime currentDate = DateTime.Now;

            var dgv = sender as DataGridView;
            if (dgv == null)
                return;

            //e.Row.Cells[ItemsIdColumn.Index].Value = 0;
            e.Row.Cells[ItemsDonorTypeNameColumn.Index].Value = "";
            e.Row.Cells[ItemsDonorNameColumn.Index].Value = "";
            e.Row.Cells[ItemsItemNameColumn.Index].Value = "";
            e.Row.Cells[ItemsQtyColumn.Index].Value = 1;
            e.Row.Cells[ItemsDescriptionColumn.Index].Value = "";
            e.Row.Cells[ItemsImageColumn.Index].Value = Constants.EmptyImage;
            e.Row.Cells[ItemsNotesColumn.Index].Value = "";
            e.Row.Cells[ItemsItemTypeNameColumn.Index].Value = "Physical Item";
            e.Row.Cells[ItemsDonationDeliveryTypeIdColumn.Index].Value = 1;
            e.Row.Cells[ItemsSellValueColumn.Index].Value = 0;
            e.Row.Cells[ItemsRetailValueColumn.Index].Value = 0;
            e.Row.Cells[ItemsBidBuyItNowValueColumn.Index].Value = 1;
            e.Row.Cells[ItemsBidIncrementTypeIdColumn.Index].Value = 1;
            e.Row.Cells[ItemsBidMinValueColumn.Index].Value = 1;
            e.Row.Cells[ItemsBidMaxValueColumn.Index].Value = 2;
            e.Row.Cells[ItemsBidIncrementValueColumn.Index].Value = 1;
            e.Row.Cells[ItemsBidNumberOfBidsColumn.Index].Value = 1;
            e.Row.Cells[ItemsDonorIdColumn.Index].Value = -1; // silentAuctionDataSet.Donors.AsEnumerable().Min(d => d.Id);
            e.Row.Cells[ItemsAuctionIdColumn.Index].Value = AuctionIdInUse;
            e.Row.Cells[ItemsAuctionNameColumn.Index].Value = AuctionNameInUse;
            e.Row.Cells[ItemsItemTypeIdColumn.Index].Value = 2;
            e.Row.Cells[ItemsCreateDateColumn.Index].Value = currentDate;
            e.Row.Cells[ItemsModifiedDateColumn.Index].Value = currentDate;

            dgv.BindingContext[dgv.DataSource].EndCurrentEdit();
        }        
        
        private void ItemsDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            MainFormStatusLabel.Visible = false;
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (ItemsDataGridView.Columns[e.ColumnIndex].CellType == typeof (DataGridViewImageCell))
                {
                    DialogResult result = MessageBox.Show("Replace the image?", "Replace Image", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        using (OpenFileDialog openFileDialog = new OpenFileDialog())
                        {
                            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
                            string sep = string.Empty;

                            foreach (var c in codecs)
                            {
                                string codecName = c.CodecName.Substring(8).Replace("Codec", "Files").Trim();
                                openFileDialog.Filter = String.Format("{0}{1}{2} ({3})|{3}", openFileDialog.Filter, sep,
                                    codecName, c.FilenameExtension);
                                sep = "|";
                            }

                            openFileDialog.Filter = String.Format("{0}{1}{2} ({3})|{3}", openFileDialog.Filter, sep,
                                "All Files", "*.*");

                            openFileDialog.DefaultExt = ".PNG"; // Default file extension 

                            if (openFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                var bitmap = new Bitmap(openFileDialog.FileName);
                                ImageConverter converter = new ImageConverter();
                                var byteArray = (byte[]) converter.ConvertTo(bitmap, typeof (byte[]));

                                ItemsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = byteArray;
                            }
                        }
                    }
                }
            }
        }

        private void ItemsDataGridViewCellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (ItemsDataGridView.Columns[e.ColumnIndex].CellType == typeof (DataGridViewImageCell))
                    {
                        DialogResult result = MessageBox.Show("Delete the image?", "Delete Image", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            ItemsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Constants.EmptyImage;
                        }
                    }
                }
            }
        }

        private void ItemsDataGridViewCellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Clear the row error in case the user presses ESC.   
            ItemsDataGridView.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        #endregion

        #region Button Event Handlers
        private void ItemsSaveAllButtonClick(object sender, EventArgs e)
        {
            int currentRowIndex = 0;
            bool isValidForm = true;
            
            if(ItemsDataGridView.CurrentRow != null)
                currentRowIndex = ItemsDataGridView.CurrentRow.Index;

            MainFormStatusLabel.Text = "Saving data...";
            MainFormStatusLabel.Visible = true;
            SilentAuctionDataSet.ItemsDataTable newItems =
                (SilentAuctionDataSet.ItemsDataTable) silentAuctionDataSet.Items.GetChanges(DataRowState.Added);

            SilentAuctionDataSet.ItemsDataTable modifiedItems =
                (SilentAuctionDataSet.ItemsDataTable)silentAuctionDataSet.Items.GetChanges(DataRowState.Modified);

            SilentAuctionDataSet.ItemsDataTable deletedItems =
                (SilentAuctionDataSet.ItemsDataTable)silentAuctionDataSet.Items.GetChanges(DataRowState.Deleted);

            if (newItems != null)
            {
                foreach (SilentAuctionDataSet.ItemsRow row in newItems.Rows)
                {
                    if (!IsValidForm(row))
                        isValidForm = false;
                    else
                    {
                        var donor = new DonorsTableAdapter().GetDonorsData().FirstOrDefault(d => d.Name == row.DonorName);
                        var itemType = new ItemTypesTableAdapter().GetItemTypesData().FirstOrDefault(i => i.Name == row.ItemTypeName);

                        if (donor != null)
                            row.DonorId = donor.Id;
                            
                        if (itemType != null)
                            row.ItemTypeId = itemType.Id;
                    }
                }
            }

            if (modifiedItems != null)
            {
                foreach (SilentAuctionDataSet.ItemsRow row in modifiedItems.Rows)
                {
                    if (!IsValidForm(row))
                        isValidForm = false;
                    else
                    {
                        var donor = new DonorsTableAdapter().GetDonorsData().FirstOrDefault(d => d.Name == row.DonorName);
                        var itemType = new ItemTypesTableAdapter().GetItemTypesData().FirstOrDefault(i => i.Name == row.ItemTypeName);

                        if (donor != null)
                            row.DonorId = donor.Id;

                        if (itemType != null)
                            row.ItemTypeId = itemType.Id;
                    }
                }
            }

            if (!isValidForm)
            {
                if (newItems != null)
                    newItems.Dispose();
                if (modifiedItems != null)
                    modifiedItems.Dispose();
                if (deletedItems != null)
                    deletedItems.Dispose();
                MainFormStatusLabel.Text = "Error in data";
                return;
            }

            try
            {
                bool changesMade = false;
                int recordCount = 0;
                if (newItems != null)
                {
                    itemsTableAdapter.Update(newItems);
                    changesMade = true;
                    recordCount += newItems.Rows.Count;
                }

                if (modifiedItems != null)
                {
                    foreach (DataRow row in modifiedItems.Rows)
                    {
                        row["ModifiedDate"] = DateTime.Now;
                    }
                    itemsTableAdapter.Update(modifiedItems);
                    changesMade = true;
                    recordCount += modifiedItems.Rows.Count;
                }

                if (deletedItems != null)
                {
                    itemsTableAdapter.Update(deletedItems);
                    changesMade = true;
                    recordCount += deletedItems.Rows.Count;
                }

                if (changesMade)
                {
                    silentAuctionDataSet.AcceptChanges();

                    itemsTableAdapter.Fill(silentAuctionDataSet.Items, AuctionIdInUse);
                    MainFormStatusLabel.Text = string.Format("Saved data for {0} records", recordCount);
                    MainFormStatusLabel.Visible = true;
                    SetupToolStripMenuItems();
                }
                else
                {
                    MainFormStatusLabel.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Failed: " + ex.Message);
            }
            finally
            {
                if(newItems != null)
                    newItems.Dispose();
                if(modifiedItems != null)
                    modifiedItems.Dispose();
                if(deletedItems != null)
                    deletedItems.Dispose();
            }

            if(currentRowIndex > 0)
                ItemsDataGridView.FirstDisplayedScrollingRowIndex = currentRowIndex; //ItemsDataGridView.RowCount - 1;
        }

        private void AddItemsButtonClick(object sender, EventArgs e)
        {
            ItemsDataGridView.FirstDisplayedScrollingRowIndex = ItemsDataGridView.RowCount - 1;
        }

        private void ExportButtonClick(object sender, EventArgs e)
        {
            var dt = new ItemsTableAdapter().GetData(AuctionIdInUse);

            dt.Columns.Remove(dt.AuctionIdColumn);
            dt.Columns.Remove(dt.BidIncrementTypeIdColumn);
            dt.Columns.Remove(dt.CreateDateColumn);
            dt.Columns.Remove(dt.DonationDeliveryTypeIdColumn);
            dt.Columns.Remove(dt.DonorIdColumn);
            dt.Columns.Remove(dt.ImageColumn);
            dt.Columns.Remove(dt.ItemTypeIdColumn);
            dt.Columns.Remove(dt.ModifiedDateColumn);
            
            string data = dt.DataTableToCsvFormat();

            FileHelper.SaveCsvFile(data, "Silent Auction Items");
        }
        #endregion

        #region MenuStrip Event Handlers
        #region File Section...
        private void NewAuctionToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (CreateNewAuctionForm createNewAuctionForm = new CreateNewAuctionForm())
            {
                createNewAuctionForm.ShowDialog();
                silentAuctionDataSet.Items.Clear();
                silentAuctionDataSet.Donors.Clear();
                _donorsTableAdapter.FillByAuctionId(silentAuctionDataSet.Donors, AuctionIdInUse);
                itemsTableAdapter.Fill(silentAuctionDataSet.Items, AuctionIdInUse);
                SetupToolStripMenuItems();
            }
        }

        private void NewDonorToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (CreateNewDonorForm createNewDonorForm = new CreateNewDonorForm(AuctionIdInUse))
            {
                createNewDonorForm.ShowDialog();
                silentAuctionDataSet.Items.Clear();
                _donorsTableAdapter.FillByAuctionId(silentAuctionDataSet.Donors, AuctionIdInUse);
                itemsTableAdapter.Fill(silentAuctionDataSet.Items, AuctionIdInUse);
                SetupToolStripMenuItems();
            }
        }

        private void NewItemToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (CreateNewItemForm createNewItemForm = new CreateNewItemForm(AuctionIdInUse))
            {
                createNewItemForm.ShowDialog();
                silentAuctionDataSet.Items.Clear();
                _donorsTableAdapter.FillByAuctionId(silentAuctionDataSet.Donors, AuctionIdInUse);
                itemsTableAdapter.Fill(silentAuctionDataSet.Items, AuctionIdInUse);
                SetupToolStripMenuItems();
            }
        }

        private void OpenAuctionToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (OpenAuctionForm openAuctionForm = new OpenAuctionForm())
            {
                openAuctionForm.ShowDialog();

                AuctionIdInUse = openAuctionForm.AuctionId;
                if (AuctionIdInUse > 0)
                {
                    FillItems();
                    SetAuctionNameAndGrid();
                }

                SetupToolStripMenuItems();
            }
        }

        private void CloseAuctionToolStripMenuItemClick(object sender, EventArgs e)
        {
            AuctionIdInUse = 0;
            AuctionNameInUse = "";
            FillItems();
            
            SetAuctionNameAndGrid();
            SetupToolStripMenuItems();
        }

        private void SaveToolStripMenuItemClick(object sender, EventArgs e)
        {
            ItemsSaveAllButtonClick(sender, e);
        }

        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Edit/View Section...
        private void EditAuctionListToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (EditAuctionList editAuctionList = new EditAuctionList())
            {
                editAuctionList.ShowDialog();
                FillItems();
                SetAuctionNameAndGrid();
            }
        }

        private void EditAuctionFormToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (EditAuctionForm editAuctionForm = new EditAuctionForm())
            {
                editAuctionForm.ShowDialog();
                FillItems();
                SetAuctionNameAndGrid();
            }
        }

        private void EditDonorListToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (EditDonorList editDonorList = new EditDonorList(AuctionIdInUse))
            {
                editDonorList.ShowDialog();
                FillItems();
                SetAuctionNameAndGrid();
            }
        }

        private void EditDonorFormToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO: Create an Edit Donor form?
            MessageBox.Show("Need to implement");
        }
        #endregion

        #region Documents Section...
        private void DocumentEditorToolStripMenuItemClick(object sender, EventArgs e)
        {
            DocumentEditor documentEditor = new DocumentEditor(AuctionIdInUse);
            documentEditor.ShowDialog();
        }

        private void PrintBidSheetsToolStripMenuItemClick(object sender, EventArgs e)
        {
            BidSheetPrintForm printBidSheetForm = new BidSheetPrintForm(AuctionIdInUse);
            printBidSheetForm.ShowDialog();
        }

        private void CreateLabelsFileToolStripMenuItemClick(object sender, EventArgs e)
        {
            GenerateAddressLabelsFile addressLabelsFile = new GenerateAddressLabelsFile(AuctionIdInUse);
            if (addressLabelsFile.ShowDialog() == DialogResult.OK)
            {
                MainFormStatusLabel.Text = "File created";
                MainFormStatusLabel.Visible = true;
            }
        }

        private void CreateItemLabelsFileToolStripMenuItemClick(object sender, EventArgs e)
        {
            GenerateItemLabelsFile itemLabelsFile = new GenerateItemLabelsFile(AuctionIdInUse);
            if(itemLabelsFile.ShowDialog() == DialogResult.OK)
            {
                MainFormStatusLabel.Text = "File created";
                MainFormStatusLabel.Visible = true;
            }
        }
        #endregion
        
        #region Tools Section...
        private void CopyDonorsToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (CopyDonorsForm copyDonorsForm = new CopyDonorsForm())
            {
                copyDonorsForm.ShowDialog();
                donorsNameOnlyTableAdapter.Fill(silentAuctionDataSet.DonorsNameOnly, AuctionIdInUse);
                SetAuctionNameAndGrid();
            }
        }

        private void BidCalculatorToolStripMenuItemClick(object sender, EventArgs e)
        {
            BidCalculatorForm.GetForm.Show();
        }
        #endregion

        #region Reports Section...
        private void ShowAllItemsByDonorToolStripMenuItemClick(object sender, EventArgs e)
        {
            new ReportShowAllItemsByDonorName().ShowDialog();
        }

        private void DonorNoResponseToolStripMenuItemClick(object sender, EventArgs e)
        {
            new ReportNoResponseByDonor().ShowDialog();
        }
        #endregion
        
        #region Help Section...
        private void AboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (AboutBox ab = new AboutBox())
            {
                ab.ShowDialog();
            }
        }
        #endregion
        #endregion
        
        #region Private Methods
        private bool IsValidForm(SilentAuctionDataSet.ItemsRow row)
        {
            bool isValid = true;
            string errorMsg = "";
            bool tempAllowUserToAddRows = ItemsDataGridView.AllowUserToAddRows;

            ItemsDataGridView.AllowUserToAddRows = false; // Turn off or .Value below will throw null exception
            DataGridViewRow dgRow = ItemsDataGridView.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.Cells["ItemsIdColumn"].Value.Equals(row.Id));

            if (dgRow != null)
            {
                var rowIndex = dgRow.Index;
                ItemsDataGridView.AllowUserToAddRows = tempAllowUserToAddRows;

                if (!SilentAuctionValidator.ValidateDonorName(row.DonorName, ref errorMsg))
                {
                    ItemsDataGridView.Rows[rowIndex].Cells[ItemsDonorNameColumn.Index].ErrorText = errorMsg;
                    isValid = false;
                }

                if (!SilentAuctionValidator.ValidateItemName(row.Name, ref errorMsg))
                {
                    ItemsDataGridView.Rows[rowIndex].Cells[ItemsItemNameColumn.Index].ErrorText = errorMsg;
                    isValid = false;
                }

                if (!SilentAuctionValidator.ValidateQty((int) row.Qty, ref errorMsg))
                {
                    ItemsDataGridView.Rows[rowIndex].Cells[ItemsQtyColumn.Index].ErrorText = errorMsg;
                    isValid = false;
                }

                if (!SilentAuctionValidator.ValidateRetailValue((decimal) row.RetailValue, ref errorMsg))
                {
                    ItemsDataGridView.Rows[rowIndex].Cells[ItemsRetailValueColumn.Index].ErrorText = errorMsg;
                    isValid = false;
                }

                if (!SilentAuctionValidator.ValidateMinimumBid((decimal) row.BidMinValue, ref errorMsg))
                {
                    ItemsDataGridView.Rows[rowIndex].Cells[ItemsBidMinValueColumn.Index].ErrorText = errorMsg;
                    isValid = false;
                }

                if (!SilentAuctionValidator.ValidateMaximumBid((decimal) row.BidMaxValue, ref errorMsg))
                {
                    ItemsDataGridView.Rows[rowIndex].Cells[ItemsBidMaxValueColumn.Index].ErrorText = errorMsg;
                    isValid = false;
                }

                if (!SilentAuctionValidator.ValidateMaximumBidGreaterThanMinimumBid((decimal) row.BidMinValue,
                    (decimal) row.BidMaxValue, ref errorMsg))
                {
                    ItemsDataGridView.Rows[rowIndex].Cells[ItemsBidMaxValueColumn.Index].ErrorText = errorMsg;
                    isValid = false;
                }

                if (!SilentAuctionValidator.ValidateBuyItNow((decimal) row.BidBuyItNowValue, ref errorMsg))
                {
                    ItemsDataGridView.Rows[rowIndex].Cells[ItemsBidBuyItNowValueColumn.Index].ErrorText = errorMsg;
                    isValid = false;
                }
                
                if (row.BidIncrementTypeId == (int) BidIncrementType.IncrementValue)
                {
                    if (!SilentAuctionValidator.ValidateBidIncrementValue((decimal) row.BidMinValue,
                        (decimal) row.BidMaxValue, (decimal) row.BidIncrementValue, ref errorMsg))
                    {
                        ItemsDataGridView.Rows[rowIndex].Cells[ItemsBidIncrementValueColumn.Index].ErrorText = errorMsg;
                        isValid = false;
                    }
                }
                else
                {
                    if (!SilentAuctionValidator.ValidateNumberOfBids((int) row.BidNumberOfBids, ref errorMsg))
                    {
                        ItemsDataGridView.Rows[rowIndex].Cells[ItemsBidNumberOfBidsColumn.Index].ErrorText = errorMsg;
                        isValid = false;
                    }
                }
            }

            return isValid;
        }
        
        private void FillItems()
        {
            silentAuctionDataSet.Items.Clear();
            silentAuctionDataSet.Donors.Clear();
            silentAuctionDataSet.Auctions.Clear();

            _auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);
            donorsNameOnlyTableAdapter.Fill(silentAuctionDataSet.DonorsNameOnly, AuctionIdInUse);
            itemsTableAdapter.Fill(silentAuctionDataSet.Items, AuctionIdInUse);

            AuctionNameInUse = AuctionIdInUse > 0 
                ? silentAuctionDataSet.Auctions.First(a => a.Id == AuctionIdInUse).Name 
                : "";
        }

        private void LoadSettings()
        {
            ItemsIdColumn.Width = Settings.Default.ItemsIdColumnWidth;
            ItemsDonorTypeNameColumn.Width = Settings.Default.ItemsDonorTypeNameColumnWidth;
            ItemsDonorNameColumn.Width = Settings.Default.ItemsDonorNameColumnWidth;
            ItemsItemNameColumn.Width = Settings.Default.ItemsNameColumnWidth;
            ItemsDescriptionColumn.Width = Settings.Default.ItemsItemDescriptionColumnWidth;
            ItemsQtyColumn.Width = Settings.Default.ItemsQtyColumnWidth;
            ItemsItemTypeNameColumn.Width = Settings.Default.ItemsItemTypeNameColumnWidth;
            ItemsDonationDeliveryTypeIdColumn.Width = Settings.Default.ItemsDonationDeliveryTypeIdColumnWidth;
            ItemsSellValueColumn.Width = Settings.Default.ItemsSellValueColumnWidth;
            ItemsRetailValueColumn.Width = Settings.Default.ItemsRetailValueColumnWidth;
            ItemsBidIncrementTypeIdColumn.Width = Settings.Default.ItemsBidIncrementTypeColumnWidth;
            ItemsBidMinValueColumn.Width = Settings.Default.ItemsBidMinColumnWidth;
            ItemsBidMaxValueColumn.Width = Settings.Default.ItemsBidMaxColumnWidth;
            ItemsBidIncrementValueColumn.Width = Settings.Default.ItemsBidIncrementValuesColumnWidth;
            ItemsBidBuyItNowValueColumn.Width = Settings.Default.ItemsBuyItNowValueColumnWidth;
            ItemsBidNumberOfBidsColumn.Width = Settings.Default.ItemsBidNumberOfBidsColumnWidth;
            ItemsNotesColumn.Width = Settings.Default.ItemsNotesColumnWidth;
            ItemsImageColumn.Width = Settings.Default.ItemsImageColumnWidth;

            AuctionIdInUse = Settings.Default.AuctionIdInUse;
            AuctionNameInUse = Settings.Default.AuctionNameInUse;
        }

        private void SaveSettings()
        {
            Settings.Default.ItemsIdColumnWidth = ItemsIdColumn.Width;
            Settings.Default.ItemsDonorTypeNameColumnWidth = ItemsDonorTypeNameColumn.Width;
            Settings.Default.ItemsDonorNameColumnWidth = ItemsDonorNameColumn.Width;
            Settings.Default.ItemsNameColumnWidth = ItemsItemNameColumn.Width;
            Settings.Default.ItemsItemDescriptionColumnWidth = ItemsDescriptionColumn.Width;
            Settings.Default.ItemsQtyColumnWidth = ItemsQtyColumn.Width;
            Settings.Default.ItemsItemTypeNameColumnWidth = ItemsItemTypeNameColumn.Width;
            Settings.Default.ItemsDonationDeliveryTypeIdColumnWidth = ItemsDonationDeliveryTypeIdColumn.Width;
            Settings.Default.ItemsSellValueColumnWidth = ItemsSellValueColumn.Width;
            Settings.Default.ItemsRetailValueColumnWidth = ItemsRetailValueColumn.Width;
            Settings.Default.ItemsBidIncrementTypeColumnWidth = ItemsBidIncrementTypeIdColumn.Width;
            Settings.Default.ItemsBidMinColumnWidth = ItemsBidMinValueColumn.Width;
            Settings.Default.ItemsBidMaxColumnWidth = ItemsBidMaxValueColumn.Width;
            Settings.Default.ItemsBidIncrementValuesColumnWidth = ItemsBidIncrementValueColumn.Width;
            Settings.Default.ItemsBuyItNowValueColumnWidth = ItemsBidBuyItNowValueColumn.Width;
            Settings.Default.ItemsBidNumberOfBidsColumnWidth = ItemsBidNumberOfBidsColumn.Width;
            Settings.Default.ItemsNotesColumnWidth = ItemsNotesColumn.Width;
            Settings.Default.ItemsImageColumnWidth = ItemsImageColumn.Width;

            Settings.Default.AuctionIdInUse = AuctionIdInUse;
            Settings.Default.AuctionNameInUse = AuctionNameInUse;

            Settings.Default.Save();
        }

        private void SetAuctionNameAndGrid()
        {
            ItemsDataGridView.Visible = ((AuctionIdInUse > 0) &&
                                         (silentAuctionDataSet.DonorsNameOnly.Rows.Count > 0));
            ButtonsPanel.Visible = ((AuctionIdInUse > 0) &&
                                    (silentAuctionDataSet.DonorsNameOnly.Rows.Count > 0));
            LabelsPanel.Visible = ((AuctionIdInUse > 0) &&
                                   (silentAuctionDataSet.DonorsNameOnly.Rows.Count > 0));
            AuctionNamePanel.Visible = ((AuctionIdInUse > 0) &&
                                        (silentAuctionDataSet.DonorsNameOnly.Rows.Count > 0));
            AuctionNameLabel2.Text = AuctionNameInUse;
            ItemsLabel.Visible = ((AuctionIdInUse > 0) &&
                                        (silentAuctionDataSet.DonorsNameOnly.Rows.Count > 0));
            
            Text = "Silent Auction";
            if (!string.IsNullOrWhiteSpace(AuctionNameInUse))
                Text += " - " + AuctionNameInUse;
        }

        private void SetupToolStripMenuItems()
        {
            SilentAuctionDataSet.DonorsDataTable allDonorsTable = new SilentAuctionDataSet.DonorsDataTable();
            new DonorsTableAdapter().FillDonors(allDonorsTable);
            int auctionsCount = new AuctionsTableAdapter().GetAuctionsData().Rows.Count;
            new DonorsTableAdapter().FillByAuctionId(silentAuctionDataSet.Donors, AuctionIdInUse);
            
            // File Section...
            NewDonorToolStripMenuItem.Enabled = (auctionsCount > 0);
            NewItemToolStripMenuItem.Enabled = (allDonorsTable.Rows.Count > 0);
            OpenAuctionToolStripMenuItem.Enabled = (auctionsCount > 0);
            CloseAuctionToolStripMenuItem.Enabled = AuctionIdInUse > 0;
            SaveToolStripMenuItem.Enabled = ((AuctionIdInUse > 0) && 
                (ItemsDataGridView.Visible));

            // Edit/View Section...
            EditAuctionListToolStripMenuItem.Enabled = auctionsCount > 0;
            EditAuctionFormToolStripMenuItem.Enabled = auctionsCount > 0;
            EditDonorListToolStripMenuItem.Enabled = ((AuctionIdInUse > 0) &&
                (silentAuctionDataSet.Donors.Rows.Count > 0));
            EditDonorFormToolStripMenuItem.Enabled = ((AuctionIdInUse > 0) &&
                (silentAuctionDataSet.Donors.Rows.Count > 0));

            // Documents Section...
            DocumentEditorToolStripMenuItem.Enabled = ((AuctionIdInUse > 0) &&
                (silentAuctionDataSet.Donors.Rows.Count > 0));
            CreateAddressLabelsFileToolStripMenuItem.Enabled = ((AuctionIdInUse > 0) &&
                (silentAuctionDataSet.Donors.Rows.Count > 0));
            CreateItemLabelsFileToolStripMenuItem.Enabled = ((AuctionIdInUse > 0) &&
                (silentAuctionDataSet.Donors.Rows.Count > 0));

            // Tools Section...
            CopyDonorsToolStripMenuItem.Enabled = auctionsCount > 1;

            // Reports Section...
            ShowAllItemsByDonorToolStripMenuItem.Enabled = (allDonorsTable.Rows.Count > 0);
            donorNoResponseToolStripMenuItem.Enabled = ((AuctionIdInUse > 0) &&
                (silentAuctionDataSet.Donors.Rows.Count > 0));
        }
        #endregion

        private void RefreshButtonClick(object sender, EventArgs e)
        {
            var silentAuctionDataSetChanges = silentAuctionDataSet.GetChanges();
            if (silentAuctionDataSetChanges != null)
            {
                if (GenericPageHelper.StayOnPage())
                    return;
            }
            FillItems();
        }
    }
}
