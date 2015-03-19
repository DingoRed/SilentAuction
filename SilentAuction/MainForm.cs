﻿using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SilentAuction.Forms;
using SilentAuction.Properties;

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
        private void MainForm2Load(object sender, EventArgs e)
        {
            ImportFormSettings();
            
            requestFormatTypesTableAdapter.FillRequestFormatTypes(silentAuctionDataSet.RequestFormatTypes);
            donationDeliveryTypesTableAdapter.FillDonationDeliveryTypes(silentAuctionDataSet.DonationDeliveryTypes);
            itemTypesTableAdapter.FillItemTypes(silentAuctionDataSet.ItemTypes);
            bidIncrementTypesTableAdapter.FillBidIncremenetTypes(silentAuctionDataSet.BidIncrementTypes);
            donorTypesTableAdapter.FillDonorTypes(silentAuctionDataSet.DonorTypes);
            auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);
            donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors);
            itemsTableAdapter.FillItems(silentAuctionDataSet.Items, AuctionIdInUse);
            
            ItemsDataGridView.Visible = AuctionIdInUse > 0;
           
            SetupInitialWindow();
            SetupGrids();
            SetupOpenAuctionToolStripMenuItem();
            SetupSaveToolStripMenuItem();
        }

        private void MainForm2FormClosing(object sender, FormClosingEventArgs e)
        {
            var silentAuctionDataSetChanges = silentAuctionDataSet.GetChanges();
            if (silentAuctionDataSetChanges != null)
            {
                var result = MessageBox.Show("You have unsaved changes.\n\rAre you sure you want to close without saving?", "Unsaved Changes",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(result == DialogResult.No)
                    e.Cancel = true;
            }
             
            if (!e.Cancel)
            {
                SaveWindowSettings();
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
                    SetupSaveToolStripMenuItem();
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
        }        
        
        private void ItemsDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            MainFormStatusLabel.Visible = false;
        }

        private void ItemsDataGridViewCellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //string headerText = ItemsDataGridView.Columns[e.ColumnIndex].HeaderText;

            //// Abort validation if cell is not in the CompanyName column. 
            //if (!headerText.Equals("* Donor")) return;

            //// Confirm that the cell is not empty. 
            //if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            //{
            //    ItemsDataGridView.Rows[e.RowIndex].ErrorText = "* Donor must not be empty";
            //    e.Cancel = true;
            //}
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
        private void NewAuctionToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (CreateNewAuctionForm createNewAuctionForm = new CreateNewAuctionForm())
            {
                createNewAuctionForm.ShowDialog();
                auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);
                SetupOpenAuctionToolStripMenuItem();
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
                    itemsTableAdapter.FillItems(silentAuctionDataSet.Items, AuctionIdInUse);
                    SetAuctionNameAndGrid();
                }
            }
        }

        private void CloseAuctionToolStripMenuItemClick(object sender, EventArgs e)
        {
            AuctionIdInUse = 0;
            AuctionNameInUse = "";
            itemsTableAdapter.FillItems(silentAuctionDataSet.Items, AuctionIdInUse);
            ItemsDataGridView.Visible = AuctionIdInUse > 0;
        }

        private void NewDonorToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (CreateNewDonorForm createNewDonorForm = new CreateNewDonorForm())
            {
                createNewDonorForm.ShowDialog();
                donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors);
                SetupOpenAuctionToolStripMenuItem();
            }
        }

        private void DonorsListToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (ViewDonorsForm viewDonors = new ViewDonorsForm())
            {
                viewDonors.ShowDialog();
            }
        }

        private void AuctionsListToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (ViewAuctionsForm viewAuctions = new ViewAuctionsForm())
            {
                viewAuctions.ShowDialog();
            }
        }

        private void SaveToolStripMenuItemClick(object sender, EventArgs e)
        {
            ItemsSaveAllButtonClick(sender, e);
        }

        private void PrintToolStripMenuItemClick(object sender, EventArgs e)
        {
            throw new Exception("Not Implemented");
        }

        private void PrintPreviewToolStripMenuItemClick(object sender, EventArgs e)
        {
            throw new Exception("Not Implemented");
        }

        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (AboutBox ab = new AboutBox())
            {
                ab.ShowDialog();
            }
        }
        #endregion

        #region Private Methods
        private void SetupInitialWindow()
        {
            if ((ModifierKeys & Keys.Shift) == 0)
            {
                string initLocation = Settings.Default.MainFormInitialLocation;
                Point il = new Point(0, 0);
                Size sz = Size;
                if (!string.IsNullOrWhiteSpace(initLocation))
                {
                    string[] parts = initLocation.Split(',');
                    if (parts.Length >= 2)
                    {
                        il = new Point(int.Parse(parts[0]), int.Parse(parts[1]));
                    }
                    if (parts.Length >= 4)
                    {
                        sz = new Size(int.Parse(parts[2]), int.Parse(parts[3]));
                    }
                    Size = sz;
                    Location = il;
                }
            }
        }

        // TODO: Move to its own class
        private void SaveWindowSettings()
        {
            if ((ModifierKeys & Keys.Shift) == 0)
            {
                Point location = Location;
                Size size = Size;
                if (WindowState != FormWindowState.Normal)
                {
                    location = RestoreBounds.Location;
                    size = RestoreBounds.Size;
                }
                string initLocation = string.Join(",", location.X, location.Y, size.Width, size.Height);
                Settings.Default.MainFormInitialLocation = initLocation;
                Settings.Default.Save();
            }
        }

        private void SetupGrids()
        {
            // Items grid settings...
            ItemsDonorIdColumn.Width = Settings.Default.ItemsDonorIdColumnWidth;
            ItemsNameColumn.Width = Settings.Default.ItemsNameColumnWidth;
            ItemsQtyColumn.Width = Settings.Default.ItemsQtyColumnWidth;
            ItemsItemDescriptionColumn.Width = Settings.Default.ItemsItemDescriptionColumnWidth;
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
            Settings.Default.ItemsDonorIdColumnWidth = ItemsDonorIdColumn.Width;
            Settings.Default.ItemsNameColumnWidth = ItemsNameColumn.Width;
            Settings.Default.ItemsQtyColumnWidth = ItemsQtyColumn.Width;
            Settings.Default.ItemsItemDescriptionColumnWidth = ItemsItemDescriptionColumn.Width;
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
            ItemsDataGridView.Visible = AuctionIdInUse > 0;
            ItemsSaveAllButton.Visible = AuctionIdInUse > 0;
            AddItemsButton.Visible = AuctionIdInUse > 0;
            ItemsRequirementLabel.Visible = AuctionIdInUse > 0;
            AuctionNameLabel1.Visible = AuctionIdInUse > 0;
            AuctionNameLabel2.Visible = AuctionIdInUse > 0;
            AuctionNameLabel2.Text = AuctionNameInUse;
            Text = "Silent Auction - " + AuctionNameInUse;
        }

        private void SetupSaveToolStripMenuItem()
        {
            SaveToolStripMenuItem.Enabled = silentAuctionDataSet.Items.Rows.Count > 0;
        }

        private void SetupOpenAuctionToolStripMenuItem()
        {
            OpenAuctionToolStripMenuItem.Enabled = (silentAuctionDataSet.Auctions.Rows.Count > 0 &&
                                                    silentAuctionDataSet.Donors.Rows.Count > 0);
        }
        #endregion

    }
}