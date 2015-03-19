using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SilentAuction.Forms;
using SilentAuction.Properties;
using SilentAuction.Utilities;

namespace SilentAuction
{
    public partial class MainForm2 : Form
    {
        #region Constructor
        public MainForm2()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Event Handlers
        private void MainForm2Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'silentAuctionDataSet.RequestFormatTypes' table. You can move, or remove it, as needed.
            this.requestFormatTypesTableAdapter.FillRequestFormatTypes(this.silentAuctionDataSet.RequestFormatTypes);
            // TODO: This line of code loads data into the 'silentAuctionDataSet.DonationDeliveryTypes' table. You can move, or remove it, as needed.
            this.donationDeliveryTypesTableAdapter.FillDonationDeliveryTypes(this.silentAuctionDataSet.DonationDeliveryTypes);
            // TODO: This line of code loads data into the 'silentAuctionDataSet.ItemTypes' table. You can move, or remove it, as needed.
            this.itemTypesTableAdapter.FillItemTypes(this.silentAuctionDataSet.ItemTypes);
            SetupInitialWindow();

            bidIncrementTypesTableAdapter.FillBidIncremenetTypes(silentAuctionDataSet.BidIncrementTypes);
            donorTypesTableAdapter.FillDonorTypes(silentAuctionDataSet.DonorTypes);
            auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);
            donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors);
            
            ItemsDataGridView.Visible = false;
            
            BindItemsToolStripComboBox();

            SetupGrids();
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
            }
        }

        #endregion

        #region ToolStrip Event Handlers
        private void ItemsToolStripComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            //int auctionId = ((Auction) ItemsToolStripComboBox.SelectedItem).Id;

            try
            {
                if (ItemsToolStripComboBox.ComboBox != null)
                {
                    int auctionId = MathHelper.ParseIntZeroIfNull(ItemsToolStripComboBox.ComboBox.SelectedValue.ToString());
                    itemsTableAdapter.FillItems(silentAuctionDataSet.Items, auctionId);
                    ItemsDataGridView.Visible = auctionId > 0;
                    ItemsSaveAllButton.Visible = auctionId > 0;
                    AddItemsButton.Visible = auctionId > 0;
                    ItemsRequirementLabel.Visible = auctionId > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Items Event Handlers
        private void ItemsDataGridViewDataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            CommonDataErrorHandler(sender, e);
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

                    try
                    {
                        if (ItemsToolStripComboBox.ComboBox != null)
                        {
                            int auctionId = MathHelper.ParseIntZeroIfNull(ItemsToolStripComboBox.ComboBox.SelectedValue.ToString());
                            itemsTableAdapter.FillItems(silentAuctionDataSet.Items, auctionId);
                            MainFormStatusLabel.Text = string.Format("Saved data for {0} records", recordCount);
                            MainFormStatusLabel.Visible = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
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
            e.Row.Cells["ItemsDonorIdColumn"].Value = 1;
            e.Row.Cells["ItemsQtyColumn"].Value = 1;
            if (ItemsToolStripComboBox != null)
            {
                if (ItemsToolStripComboBox.ComboBox != null)
                {
                    int auctionId = MathHelper.ParseIntZeroIfNull(ItemsToolStripComboBox.ComboBox.SelectedValue.ToString());
                    e.Row.Cells["ItemsAuctionIdColumn"].Value = auctionId;
                }
            }
            e.Row.Cells["ItemsBidIncrementTypeColumn"].Value = 1;
        }        
        
        private void ItemsDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            MainFormStatusLabel.Visible = false;
        }

        private void ItemsDataGridViewCellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText = ItemsDataGridView.Columns[e.ColumnIndex].HeaderText;

            // Abort validation if cell is not in the CompanyName column. 
            if (!headerText.Equals("* Donor")) return;

            // Confirm that the cell is not empty. 
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                ItemsDataGridView.Rows[e.RowIndex].ErrorText = "* Donor must not be empty";
                e.Cancel = true;
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

        #region Donors Event Handlers
        private void DonorsDataGridViewDataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            CommonDataErrorHandler(sender, e);
        }

        private void DonorsSaveAllButtonClick(object sender, EventArgs e)
        {
            MainFormStatusLabel.Text = "Saving data...";
            MainFormStatusLabel.Visible = true;
            SilentAuctionDataSet.DonorsDataTable newDonors =
                (SilentAuctionDataSet.DonorsDataTable) silentAuctionDataSet.Donors.GetChanges(DataRowState.Added);

            SilentAuctionDataSet.DonorsDataTable modifiedDonors =
                (SilentAuctionDataSet.DonorsDataTable)silentAuctionDataSet.Donors.GetChanges(DataRowState.Modified);

            SilentAuctionDataSet.DonorsDataTable deletedDonors =
                (SilentAuctionDataSet.DonorsDataTable)silentAuctionDataSet.Donors.GetChanges(DataRowState.Deleted);

            try
            {
                bool changesMade = false;
                int recordCount = 0;
                if (newDonors != null)
                {
                    donorsTableAdapter.Update(newDonors);
                    changesMade = true;
                    recordCount += newDonors.Rows.Count;
                }

                if (modifiedDonors != null)
                {
                    foreach (DataRow row in modifiedDonors.Rows)
                    {
                        row["ModifiedDate"] = DateTime.Now;
                    }
                    donorsTableAdapter.Update(modifiedDonors);
                    changesMade = true;
                    recordCount += modifiedDonors.Rows.Count;
                }

                if (deletedDonors != null)
                {
                    donorsTableAdapter.Update(deletedDonors);
                    changesMade = true;
                    recordCount += deletedDonors.Rows.Count;
                }

                if (changesMade)
                {
                    silentAuctionDataSet.AcceptChanges();

                    try
                    {
                        donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors);
                        MainFormStatusLabel.Text = string.Format("Saved data for {0} records", recordCount);
                        MainFormStatusLabel.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
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
                if (newDonors != null)
                    newDonors.Dispose();
                if (modifiedDonors != null)
                    modifiedDonors.Dispose();
                if (deletedDonors != null)
                    deletedDonors.Dispose();
            }
        }

        private void DonorsDataGridViewDefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            e.Row.Cells["DonorsCreateDateColumn"].Value = currentDate;
            e.Row.Cells["DonorsModifiedDateColumn"].Value = currentDate;
        }
        
        private void DonorsDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            MainFormStatusLabel.Visible = false;
        }

        private void AddDonorButtonClick(object sender, EventArgs e)
        {
            DonorsDataGridView.FirstDisplayedScrollingRowIndex = DonorsDataGridView.RowCount - 1;
        }
        #endregion

        #region Auctions Event Handlers
        private void AuctionsDataGridViewDataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            CommonDataErrorHandler(sender, e);
        }

        private void AuctionsSaveAllButtonClick(object sender, EventArgs e)
        {
            MainFormStatusLabel.Text = "Saving data...";
            MainFormStatusLabel.Visible = true;
            SilentAuctionDataSet.AuctionsDataTable newAuctions =
                (SilentAuctionDataSet.AuctionsDataTable)silentAuctionDataSet.Auctions.GetChanges(DataRowState.Added);

            SilentAuctionDataSet.AuctionsDataTable modifiedAuctions =
                (SilentAuctionDataSet.AuctionsDataTable)silentAuctionDataSet.Auctions.GetChanges(DataRowState.Modified);

            SilentAuctionDataSet.AuctionsDataTable deletedAuctions =
                (SilentAuctionDataSet.AuctionsDataTable)silentAuctionDataSet.Auctions.GetChanges(DataRowState.Deleted);

            try
            {
                bool changesMade = false;
                int recordCount = 0;
                if (newAuctions != null)
                {
                    auctionsTableAdapter.Update(newAuctions);
                    changesMade = true;
                    recordCount += newAuctions.Rows.Count;
                }

                if (modifiedAuctions != null)
                {
                    foreach (DataRow row in modifiedAuctions.Rows)
                    {
                        row["ModifiedDate"] = DateTime.Now;
                    }
                    auctionsTableAdapter.Update(modifiedAuctions);
                    changesMade = true;
                    recordCount += modifiedAuctions.Rows.Count;
                }

                if (deletedAuctions != null)
                {
                    auctionsTableAdapter.Update(deletedAuctions);
                    changesMade = true;
                    recordCount += deletedAuctions.Rows.Count;
                }
                
                if (changesMade)
                {
                    silentAuctionDataSet.AcceptChanges();

                    try
                    {
                        auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);
                        MainFormStatusLabel.Text = string.Format("Saved data for {0} records", recordCount);
                        MainFormStatusLabel.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
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
                if (newAuctions != null)
                    newAuctions.Dispose();
                if (modifiedAuctions != null)
                    modifiedAuctions.Dispose();
                if (deletedAuctions != null)
                    deletedAuctions.Dispose();
            }

            BindItemsToolStripComboBox();
        }

        private void AuctionsDataGridViewDefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            e.Row.Cells["AuctionsCreateDateColumn"].Value = currentDate;
            e.Row.Cells["AuctionsModifiedDateColumn"].Value = currentDate;
        }
        
        private void AuctionsDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            MainFormStatusLabel.Visible = false;
        }
        
        private void AddAuctionButtonClick(object sender, EventArgs e)
        {
            AuctionsDataGridView.FirstDisplayedScrollingRowIndex = AuctionsDataGridView.RowCount - 1;
        }
        #endregion

        #region MenuStrip Event Handlers
        private void NewAuctionToolStripMenuItemClick(object sender, EventArgs e)
        {
            ItemsTabControl.SelectTab(AuctionsTabPage);
        }

        private void AddNewDonorToolStripMenuItemClick(object sender, EventArgs e)
        {
            ItemsTabControl.SelectTab(DonorsTabPage);
        }

        private void AddNewItemToolStripMenuItemClick(object sender, EventArgs e)
        {
            ItemsTabControl.SelectTab(ItemsTabPage);
        }

        private void SaveToolStripMenuItemClick(object sender, EventArgs e)
        {
            ItemsSaveAllButtonClick(sender, e);
            DonorsSaveAllButtonClick(sender, e);
            AuctionsSaveAllButtonClick(sender, e);
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
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        #endregion

        #region Private Methods
        private void SetupInitialWindow()
        {
            if ((ModifierKeys & Keys.Shift) == 0)
            {
                string initLocation = Settings.Default.InitialLocation;
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
                Settings.Default.InitialLocation = initLocation;
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


            // Donors grid settings...
            DonorsDonorTypeColumn.Width = Settings.Default.DonorsDonorTypeColumnWidth;
            DonorsNameColumn.Width = Settings.Default.DonorsNameColumnWidth;
            DonorsContactNameColumn.Width = Settings.Default.DonorsContactNameColumnWidth;
            DonorsStreet1Column.Width = Settings.Default.DonorsStreet1ColumnWidth;
            DonorsStreet2Column.Width = Settings.Default.DonorsStreet2ColumnWidth;
            DonorsCityColumn.Width = Settings.Default.DonorsCityColumnWidth;
            DonorsStateColumn.Width = Settings.Default.DonorsStateColumnWidth;
            DonorsZipCodeColumn.Width = Settings.Default.DonorsZipCodeColumnWidth;
            DonorsPhone1Column.Width = Settings.Default.DonorsPhone1ColumnWidth;
            DonorsPhone2Column.Width = Settings.Default.DonorsPhone2ColumnWidth;
            DonorsEmailColumn.Width = Settings.Default.DonorsEmailColumnWidth;
            DonorsRequestFormatTypeIdColumn.Width = Settings.Default.DonorsRequestFormatTypeIdColumnWidth;
            DonorsUrlColumn.Width = Settings.Default.DonorsUrlColumnWidth;

            // Auctions grid settings...
            AuctionsNameColumn.Width = Settings.Default.AuctionsNameColumnWidth;
            AuctionsDescriptionColumn.Width = Settings.Default.AuctionsDescriptionColumnWidth;

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

            // Donors grid user settings...
            Settings.Default.DonorsDonorTypeColumnWidth = DonorsDonorTypeColumn.Width;
            Settings.Default.DonorsNameColumnWidth = DonorsNameColumn.Width;
            Settings.Default.DonorsContactNameColumnWidth = DonorsContactNameColumn.Width;
            Settings.Default.DonorsStreet1ColumnWidth = DonorsStreet1Column.Width;
            Settings.Default.DonorsStreet2ColumnWidth = DonorsStreet2Column.Width;
            Settings.Default.DonorsCityColumnWidth = DonorsCityColumn.Width;
            Settings.Default.DonorsStateColumnWidth = DonorsStateColumn.Width;
            Settings.Default.DonorsZipCodeColumnWidth = DonorsZipCodeColumn.Width;
            Settings.Default.DonorsPhone1ColumnWidth = DonorsPhone1Column.Width;
            Settings.Default.DonorsPhone2ColumnWidth = DonorsPhone2Column.Width;
            Settings.Default.DonorsEmailColumnWidth = DonorsEmailColumn.Width;
            Settings.Default.DonorsRequestFormatTypeIdColumnWidth = DonorsRequestFormatTypeIdColumn.Width;
            Settings.Default.DonorsUrlColumnWidth = DonorsUrlColumn.Width;

            // Auction grid user settings...
            Settings.Default.AuctionsNameColumnWidth = AuctionsNameColumn.Width;
            Settings.Default.AuctionsDescriptionColumnWidth = AuctionsDescriptionColumn.Width;

            Settings.Default.Save();
        }

        private void BindItemsToolStripComboBox()
        {
            DataTable dt = silentAuctionDataSet.Auctions.Copy();
            var newRow = dt.NewRow();
            newRow["Id"] = 0;
            newRow["Name"] = "-- Please Select --";
            newRow["Description"] = "";
            newRow["CreateDate"] = DateTime.Now;
            newRow["ModifiedDate"] = DateTime.Now;
            
            dt.Rows.InsertAt(newRow, 0);

            if (ItemsToolStripComboBox.ComboBox != null)
            {
                ItemsToolStripComboBox.ComboBox.DataSource = dt;
                ItemsToolStripComboBox.ComboBox.ValueMember = "Id";
                ItemsToolStripComboBox.ComboBox.DisplayMember = "Name";
            }
        }

        private void CommonDataErrorHandler(object sender, DataGridViewDataErrorEventArgs e)
        {
            // TODO: Make the validation work better!
            ((DataGridView)sender).Rows[e.RowIndex].ErrorText = e.Exception.Message;

            MainFormStatusLabel.Text = e.Exception.Message;
            MainFormStatusLabel.Visible = true;

            e.Cancel = true;
        }
        
        #endregion

    }
}
