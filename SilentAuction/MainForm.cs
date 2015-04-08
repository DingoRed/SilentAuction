#region Using Statements
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;
using SilentAuction.Extensions;
using SilentAuction.Forms;
using SilentAuction.Properties;
using SilentAuction.Utilities;
#endregion

namespace SilentAuction
{
    public partial class MainForm : Form
    {
        #region Fields
        private readonly byte[] _emptyImage = {
            137, 80, 78, 71, 13, 10, 26, 10, 0, 0, 0, 13, 73, 72, 68, 82, 0, 0, 0, 1, 0, 0, 0, 
            1, 8, 6, 0, 0, 0, 31, 21, 196, 137, 0, 0, 0, 1, 115, 82, 71, 66, 0, 174, 206, 28, 
            233, 0, 0, 0, 4, 103, 65, 77, 65, 0, 0, 177, 143, 11, 252, 97, 5, 0, 0, 0, 9, 112, 
            72, 89, 115, 0, 0, 14, 195, 0, 0, 14, 195, 1, 199, 111, 168, 100, 0, 0, 0, 11, 73, 
            68, 65, 84, 24, 87, 99, 96, 0, 2, 0, 0, 5, 0, 1, 170, 213, 200, 81, 0, 0, 0, 0, 73, 
            69, 78, 68, 174, 66, 96, 130
        };
        #endregion

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
            ImportFormSettings();
            
            requestFormatTypesTableAdapter.FillRequestFormatTypes(silentAuctionDataSet.RequestFormatTypes);
            requestStatusTypesTableAdapter.FillRequestStatusType(silentAuctionDataSet.RequestStatusTypes);
            donationDeliveryTypesTableAdapter.FillDonationDeliveryTypes(silentAuctionDataSet.DonationDeliveryTypes);
            itemTypesTableAdapter.FillItemTypes(silentAuctionDataSet.ItemTypes);
            bidIncrementTypesTableAdapter.FillBidIncremenetTypes(silentAuctionDataSet.BidIncrementTypes);
            donorTypesTableAdapter.FillDonorTypes(silentAuctionDataSet.DonorTypes);
            auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);

            donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors, AuctionIdInUse);
            itemsTableAdapter.FillItems(silentAuctionDataSet.Items, AuctionIdInUse);

            WindowSettings.SetupInitialWindow(this, "MainFormInitialLocation");
            SetupGrids();
            SetAuctionNameAndGrid();
            SetupToolStripMenuItems();
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
        private void ItemsDataGridViewDataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridView view = (DataGridView) sender;
            view.Rows[e.RowIndex].ErrorText = e.Exception.Message;

            MainFormStatusLabel.Text = e.Exception.Message;
            MainFormStatusLabel.Visible = true;

            e.Cancel = true;
        }

        private void ItemsSaveAllButtonClick(object sender, EventArgs e)
        {
            int currentRowIndex = 0;
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

        private void ItemsDataGridViewDefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            e.Row.Cells["ItemsCreateDateColumn"].Value = currentDate;
            e.Row.Cells["ItemsModifiedDateColumn"].Value = currentDate;
            e.Row.Cells["ItemsDonorIdColumn"].Value = silentAuctionDataSet.Donors.AsEnumerable().Min(d => d.Id);
            e.Row.Cells["ItemsQtyColumn"].Value = 1;
            e.Row.Cells["ItemsAuctionIdColumn"].Value = AuctionIdInUse;
            e.Row.Cells["ItemsBidIncrementTypeColumn"].Value = 1;
            e.Row.Cells["ItemsImageColumn"].Value = new Bitmap(1, 1);
        }        
        
        private void ItemsDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            MainFormStatusLabel.Visible = false;
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (ItemsDataGridView.Columns[e.ColumnIndex].CellType == typeof (DataGridViewImageCell))
                {
                    // TODO: Something wrong with _emptyImage...not the same on each computer?
                    if (((byte[])ItemsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value).SequenceEqual(_emptyImage))
                    {
                        DialogResult result = MessageBox.Show("Add an image?", "Add Image", MessageBoxButtons.YesNo);
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
                                    var byteArray = (byte[])converter.ConvertTo(bitmap, typeof(byte[]));

                                    ItemsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = byteArray;
                                }
                            }
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Delete the image?", "Delete Image", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            ItemsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = _emptyImage;
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

        private void AddItemsButtonClick(object sender, EventArgs e)
        {
            ItemsDataGridView.FirstDisplayedScrollingRowIndex = ItemsDataGridView.RowCount - 1;
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

        private void OpenAuctionToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (OpenAuctionForm openAuctionForm = new OpenAuctionForm())
            {
                openAuctionForm.ShowDialog();

                AuctionIdInUse = openAuctionForm.AuctionId;
                if (AuctionIdInUse > 0)
                {
                    AuctionNameInUse = silentAuctionDataSet.Auctions.First(a => a.Id == AuctionIdInUse).Name;
                    silentAuctionDataSet.Items.Clear();
                    silentAuctionDataSet.Donors.Clear();

                    donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors, AuctionIdInUse);
                    itemsTableAdapter.FillItems(silentAuctionDataSet.Items, AuctionIdInUse);
                    SetAuctionNameAndGrid();
                }

                SetupToolStripMenuItems();
            }
        }

        private void CloseAuctionToolStripMenuItemClick(object sender, EventArgs e)
        {
            AuctionIdInUse = 0;
            AuctionNameInUse = "";
            itemsTableAdapter.FillItems(silentAuctionDataSet.Items, AuctionIdInUse);
            donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors, AuctionIdInUse);
            
            SetAuctionNameAndGrid();
            SetupToolStripMenuItems();
        }

        private void SaveToolStripMenuItemClick(object sender, EventArgs e)
        {
            ItemsSaveAllButtonClick(sender, e);
        }

        private void PrintToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Todo: Implement PrintToolStripMenuItemClick
            MessageBox.Show("Not Implemented");
        }

        private void PrintPreviewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO:  Implement PrintPreviewToolStripMenuItemClick
            MessageBox.Show("Not Implemented");
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
                SetAuctionNameAndGrid();
            }
        }

        private void EditAuctionFormToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (EditAuctionForm editAuctionForm = new EditAuctionForm())
            {
                editAuctionForm.ShowDialog();
                SetAuctionNameAndGrid();
            }
        }

        private void EditDonorListToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (EditDonorList editDonorList = new EditDonorList())
            {
                editDonorList.AuctionIdInUse = AuctionIdInUse;
                editDonorList.ShowDialog();
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

        private void CreateLabelsFileToolStripMenuItemClick(object sender, EventArgs e)
        {
            List<int> donorIdsToInclude = new List<int>();

            GenerateAddressLabelsFile labelsFile = new GenerateAddressLabelsFile(AuctionIdInUse);
            DialogResult result = labelsFile.ShowDialog();
            if (result == DialogResult.OK)
                donorIdsToInclude = labelsFile.DonorIdsToInclude;
            else if(result == DialogResult.Cancel)
                return;
            
            DialogResult = DialogResult.None;

            donorAddressesTableAdapter.FillDonorAddresses(silentAuctionDataSet.DonorAddresses, AuctionIdInUse);
            DataTable dt = new SilentAuctionDataSet.DonorAddressesDataTable();

            foreach (SilentAuctionDataSet.DonorAddressesRow dataRow in silentAuctionDataSet.DonorAddresses.Rows)
            {
                if (donorIdsToInclude.Contains((int) dataRow.Id))
                {
                    dt.Rows.Add(dataRow.ItemArray);
                }
            }

            string csvFile = dt.DataTableToCsvFormat();
            SaveCsvFile(csvFile, "SilentAuctionLabels");
        }
        
        private void CreateItemLabelsFileToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO: Generate file
            GenerateItemLabelsFile itemLabelsFile = new GenerateItemLabelsFile(AuctionIdInUse);
            itemLabelsFile.ShowDialog();
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
        #endregion

        #region Reports Section...
        private void ShowAllItemsByDonorToolStripMenuItemClick(object sender, EventArgs e)
        {
            new ShowAllItemsByDonorName().ShowDialog();
        }

        private void DonorNoResponseToolStripMenuItemClick(object sender, EventArgs e)
        {
            new NoResponseByDonor().ShowDialog();
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

        #region Printing Event Handlers
        private void DonorRequestPrintDocumentPrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Red, new Rectangle(500, 500, 500, 500));
        }

        #endregion

        #region Private Methods
        private void SaveCsvFile(string dataToSave, string initialFilename)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "csv files (*.csv)|*.csv";
            saveFileDialog.DefaultExt = "csv";
            saveFileDialog.FileName = initialFilename;
            saveFileDialog.RestoreDirectory = true;

            DialogResult saveResult = saveFileDialog.ShowDialog();
            if (saveResult == DialogResult.OK)
            {
                try
                {
                    System.IO.File.WriteAllText(saveFileDialog.FileName, dataToSave);
                    MainFormStatusLabel.Text = "Item(s) Saved";
                    MainFormStatusLabel.Visible = true;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void SetupGrids()
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
            // TODO: Disable/Enable toolstrip items

            // File Section...
            // NewDonorToolStripMenuItem.Enabled = AuctionIdInUse > 0;
            OpenAuctionToolStripMenuItem.Enabled = (silentAuctionDataSet.Auctions.Rows.Count > 0);
            CloseAuctionToolStripMenuItem.Enabled = AuctionIdInUse > 0;
            SaveToolStripMenuItem.Enabled = ((AuctionIdInUse > 0) && 
                (ItemsDataGridView.Visible));
            PrintToolStripMenuItem.Enabled = ((AuctionIdInUse > 0) &&
                (ItemsDataGridView.Visible));
            PrintPreviewToolStripMenuItem.Enabled = ((AuctionIdInUse > 0) &&
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


            SilentAuctionDataSet.DonorsDataTable allDonorsTable = new SilentAuctionDataSet.DonorsDataTable();
            donorsTableAdapter.FillAllDonors(allDonorsTable);
            showAllItemsByDonorToolStripMenuItem.Enabled = (allDonorsTable.Rows.Count > 0);
        }
        #endregion

    }
}
