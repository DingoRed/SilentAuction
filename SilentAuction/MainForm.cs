﻿#region Using Statements
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
        #region Properties
        public int AuctionIdInUse { get; set; }
        public string AuctionNameInUse { get; set; }
        #endregion

        #region Constructor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion
         
        #region Form Event Handlers
        private void MainFormLoad(object sender, EventArgs e)
        {
            if (!Settings.Default.EULAAccepted)
            {
                Eula eula = new Eula();
                DialogResult dialogResult = eula.ShowDialog();

                if(dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
                    Application.Exit();
            }
            
            ImportFormSettings();
            
            requestFormatTypesTableAdapter.FillRequestFormatTypes(silentAuctionDataSet.RequestFormatTypes);
            requestStatusTypesTableAdapter.FillRequestStatusType(silentAuctionDataSet.RequestStatusTypes);
            donationDeliveryTypesTableAdapter.FillDonationDeliveryTypes(silentAuctionDataSet.DonationDeliveryTypes);
            itemTypesTableAdapter.FillItemTypes(silentAuctionDataSet.ItemTypes);
            bidIncrementTypesTableAdapter.FillBidIncremenetTypes(silentAuctionDataSet.BidIncrementTypes);
            donorTypesTableAdapter.FillDonorTypes(silentAuctionDataSet.DonorTypes);
            
            FillItems();

            SetupGrid();
            SetAuctionNameAndGrid();
            SetupToolStripMenuItems();

            WindowSettings.SetupInitialWindow(this, "MainFormInitialLocation");
        }

        private void MainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            var silentAuctionDataSetChanges = silentAuctionDataSet.GetChanges();
            if (silentAuctionDataSetChanges != null)
            {
                e.Cancel = GenericPageHelper.StayOnPage();
            }
             
            if (!e.Cancel)
            {
                WindowSettings.SaveWindowSettings(this, "MainFormInitialLocation");
                SaveItemsGridSettings();
                SaveFormSettings();
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
            e.Row.Cells[ItemsDonorIdColumn.Index].Value = silentAuctionDataSet.Donors.AsEnumerable().Min(d => d.Id);
            e.Row.Cells[ItemsAuctionIdColumn.Index].Value = AuctionIdInUse;
            e.Row.Cells[ItemsQtyColumn.Index].Value = 1;
            e.Row.Cells[ItemsItemDescriptionColumn.Index].Value = "";
            e.Row.Cells[ItemsItemTypeIdColumn.Index].Value = 2;
            e.Row.Cells[ItemsDonationDeliveryTypeIdColumn.Index].Value = 1;
            e.Row.Cells[ItemsRetailValueColumn.Index].Value = 0;
            e.Row.Cells[ItemsBidIncrementTypeColumn.Index].Value = 1;
            e.Row.Cells[ItemsBidMinValueColumn.Index].Value = 1;
            e.Row.Cells[ItemsBidMaxValueColumn.Index].Value = 2;
            e.Row.Cells[ItemsBidIncrementValueColumn.Index].Value = 1;
            e.Row.Cells[ItemsBidBuyItNowValueColumn.Index].Value = 1;
            e.Row.Cells[ItemsBidNumberOfBidsColumn.Index].Value = 1;
            e.Row.Cells[ItemsImageColumn.Index].Value = Constants.EmptyImage;
            e.Row.Cells[ItemsCreateDateColumn.Index].Value = currentDate;
            e.Row.Cells[ItemsModifiedDateColumn.Index].Value = currentDate;
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
                }
            }

            if (modifiedItems != null)
            {
                foreach (SilentAuctionDataSet.ItemsRow row in modifiedItems.Rows)
                {
                    if (!IsValidForm(row))
                        isValidForm = false;
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

                    itemsTableAdapter.FillItems(silentAuctionDataSet.Items, AuctionIdInUse);
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
            var dt = new ItemsShortListTableAdapter().GetItemsData(AuctionIdInUse);

            dt.Columns.Remove("BidIncrementTypeId");
            
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
                auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);
                donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors, AuctionIdInUse);
                SetupToolStripMenuItems();
            }
        }

        private void NewDonorToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (CreateNewDonorForm createNewDonorForm = new CreateNewDonorForm(AuctionIdInUse))
            {
                createNewDonorForm.ShowDialog();
                silentAuctionDataSet.Items.Clear();
                donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors, AuctionIdInUse);
                itemsTableAdapter.FillItems(silentAuctionDataSet.Items, AuctionIdInUse);
                SetupToolStripMenuItems();
            }
        }

        private void NewItemToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (CreateNewItemForm createNewItemForm = new CreateNewItemForm(AuctionIdInUse))
            {
                createNewItemForm.ShowDialog();
                silentAuctionDataSet.Items.Clear();
                donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors, AuctionIdInUse);
                itemsTableAdapter.FillItems(silentAuctionDataSet.Items, AuctionIdInUse);
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
                donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors, AuctionIdInUse);
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

                if (!SilentAuctionValidator.ValidateItemName(row.Name, ref errorMsg))
                {
                    ItemsDataGridView.Rows[rowIndex].Cells[ItemsNameColumn.Index].ErrorText = errorMsg;
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

            auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);
            donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors, AuctionIdInUse);
            itemsTableAdapter.FillItems(silentAuctionDataSet.Items, AuctionIdInUse);

            AuctionNameInUse = AuctionIdInUse > 0 ? silentAuctionDataSet.Auctions.First(a => a.Id == AuctionIdInUse).Name : "";
        }

        private void SetupGrid()
        {
            // Items grid settings...
            ItemsIdColumn.Width = Settings.Default.ItemsIdColumnWidth;
            ItemsDonorIdColumn.Width = Settings.Default.ItemsDonorIdColumnWidth;
            ItemsNameColumn.Width = Settings.Default.ItemsNameColumnWidth;
            ItemsQtyColumn.Width = Settings.Default.ItemsQtyColumnWidth;
            ItemsItemDescriptionColumn.Width = Settings.Default.ItemsItemDescriptionColumnWidth;
            ItemsImageColumn.Width = Settings.Default.ItemsImageColumnWidth;
            ItemsNotesColumn.Width = Settings.Default.ItemsNotesColumnWidth;
            ItemsRetailValueColumn.Width = Settings.Default.ItemsRetailValueColumnWidth;
            ItemsBidBuyItNowValueColumn.Width = Settings.Default.ItemsBuyItNowValueColumnWidth;
            ItemsBidIncrementTypeColumn.Width = Settings.Default.ItemsBidIncrementTypeColumnWidth;
            ItemsBidMinValueColumn.Width = Settings.Default.ItemsBidMinColumnWidth;
            ItemsBidMaxValueColumn.Width = Settings.Default.ItemsBidMaxColumnWidth;
            ItemsBidIncrementValueColumn.Width = Settings.Default.ItemsBidIncrementValuesColumnWidth;
            ItemsBidNumberOfBidsColumn.Width = Settings.Default.ItemsBidNumberOfBidsColumnWidth;
            ItemsItemTypeIdColumn.Width = Settings.Default.ItemsItemTypeIdColumnWidth;
            ItemsDonationDeliveryTypeIdColumn.Width = Settings.Default.ItemsDonationDeliveryTypeIdColumnWidth;
        }

        private void SaveItemsGridSettings()
        {
            // Items grid user settings...
            Settings.Default.ItemsIdColumnWidth = ItemsIdColumn.Width;
            Settings.Default.ItemsDonorIdColumnWidth = ItemsDonorIdColumn.Width;
            Settings.Default.ItemsNameColumnWidth = ItemsNameColumn.Width;
            Settings.Default.ItemsQtyColumnWidth = ItemsQtyColumn.Width;
            Settings.Default.ItemsItemDescriptionColumnWidth = ItemsItemDescriptionColumn.Width;
            Settings.Default.ItemsImageColumnWidth = ItemsImageColumn.Width;
            Settings.Default.ItemsNotesColumnWidth = ItemsNotesColumn.Width;
            Settings.Default.ItemsRetailValueColumnWidth = ItemsRetailValueColumn.Width;
            Settings.Default.ItemsBuyItNowValueColumnWidth = ItemsBidBuyItNowValueColumn.Width;
            Settings.Default.ItemsBidIncrementTypeColumnWidth = ItemsBidIncrementTypeColumn.Width;
            Settings.Default.ItemsBidMinColumnWidth = ItemsBidMinValueColumn.Width;
            Settings.Default.ItemsBidMaxColumnWidth = ItemsBidMaxValueColumn.Width;
            Settings.Default.ItemsBidIncrementValuesColumnWidth = ItemsBidIncrementValueColumn.Width;
            Settings.Default.ItemsBidNumberOfBidsColumnWidth = ItemsBidNumberOfBidsColumn.Width;
            Settings.Default.ItemsItemTypeIdColumnWidth = ItemsItemTypeIdColumn.Width;
            Settings.Default.ItemsDonationDeliveryTypeIdColumnWidth = ItemsDonationDeliveryTypeIdColumn.Width;

            Settings.Default.Save();
        }

        private void ImportFormSettings()
        {
            AuctionIdInUse = Settings.Default.AuctionIdInUse;
            AuctionNameInUse = Settings.Default.AuctionNameInUse;
        }

        private void SaveFormSettings()
        {
            Settings.Default.AuctionIdInUse = AuctionIdInUse;
            Settings.Default.AuctionNameInUse = AuctionNameInUse;
            Settings.Default.Save();
        }

        private void SetAuctionNameAndGrid()
        {
            ItemsDataGridView.Visible = ((AuctionIdInUse > 0) &&
                                         (silentAuctionDataSet.Donors.Rows.Count > 0));
            ButtonsPanel.Visible = ((AuctionIdInUse > 0) &&
                                    (silentAuctionDataSet.Donors.Rows.Count > 0));
            LabelsPanel.Visible = ((AuctionIdInUse > 0) &&
                                   (silentAuctionDataSet.Donors.Rows.Count > 0));
            AuctionNamePanel.Visible = ((AuctionIdInUse > 0) &&
                                        (silentAuctionDataSet.Donors.Rows.Count > 0));
            AuctionNameLabel2.Text = AuctionNameInUse;
            
            Text = "Silent Auction";
            if (!string.IsNullOrWhiteSpace(AuctionNameInUse))
                Text += " - " + AuctionNameInUse;
        }

        private void SetupToolStripMenuItems()
        {
            SilentAuctionDataSet.DonorsDataTable allDonorsTable = new SilentAuctionDataSet.DonorsDataTable();
            donorsTableAdapter.FillAllDonors(allDonorsTable);
            
            // File Section...
            NewDonorToolStripMenuItem.Enabled = (silentAuctionDataSet.Auctions.Rows.Count > 0);
            NewItemToolStripMenuItem.Enabled = (allDonorsTable.Rows.Count > 0);
            OpenAuctionToolStripMenuItem.Enabled = (silentAuctionDataSet.Auctions.Rows.Count > 0);
            CloseAuctionToolStripMenuItem.Enabled = AuctionIdInUse > 0;
            SaveToolStripMenuItem.Enabled = ((AuctionIdInUse > 0) && 
                (ItemsDataGridView.Visible));

            // Edit/View Section...
            EditAuctionListToolStripMenuItem.Enabled = silentAuctionDataSet.Auctions.Rows.Count > 0;
            EditAuctionFormToolStripMenuItem.Enabled = silentAuctionDataSet.Auctions.Rows.Count > 0;
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
            CopyDonorsToolStripMenuItem.Enabled = silentAuctionDataSet.Auctions.Rows.Count > 1;

            // Reports Section...
            ShowAllItemsByDonorToolStripMenuItem.Enabled = (allDonorsTable.Rows.Count > 0);
            donorNoResponseToolStripMenuItem.Enabled = ((AuctionIdInUse > 0) &&
                (silentAuctionDataSet.Donors.Rows.Count > 0));
        }
        #endregion
    }
}
