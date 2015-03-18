using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SilentAuction.Core.Entities;
using SilentAuction.Forms;
using SilentAuction.Utilities.Extensions;

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
            SetupInitialWindow();

            bidIncrementTypesTableAdapter.FillBidIncremenetTypes(silentAuctionDataSet.BidIncrementTypes);
            donorTypesTableAdapter.FillDonorTypes(silentAuctionDataSet.DonorTypes);
            auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);
            donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors);
            
            ItemsDataGridView.Visible = false;
            
            BindItemsToolStripComboBox();
        }

        private void MainForm2FormClosing(object sender, FormClosingEventArgs e)
        {
            var xxx = silentAuctionDataSet.GetChanges();
            if (xxx != null)
            {
                var result = MessageBox.Show("You have unsaved changes.\n\rAre you sure you want to close without saving?", "Unsaved Changes",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(result == DialogResult.No)
                    e.Cancel = true;
            }
             
            if (!e.Cancel)
            {
                SaveWindowSettings();
            }
        }

        #endregion

        #region ToolStrip Event Handlers
        private void ItemsToolStripComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            int auctionId = ((Auction) ItemsToolStripComboBox.SelectedItem).Id;

            try
            {
                itemsTableAdapter.FillItems(silentAuctionDataSet.Items, auctionId);
                ItemsDataGridView.Visible = auctionId > 0;
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
            string headerText = ItemsDataGridView.Columns[e.ColumnIndex].HeaderText;
            
            ItemsDataGridView.Rows[e.RowIndex].ErrorText = e.Exception.Message;
            MainFormStatusLabel.Text = e.Exception.Message;
            MainFormStatusLabel.Visible = true;

            e.Cancel = true;
        }

        private void ItemsSaveAllButtonClick(object sender, EventArgs e)
        {
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
                        itemsTableAdapter.FillItems(silentAuctionDataSet.Items,
                            ((Auction) ItemsToolStripComboBox.SelectedItem).Id);
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
                if(newItems != null)
                    newItems.Dispose();
                if(modifiedItems != null)
                    modifiedItems.Dispose();
                if(deletedItems != null)
                    deletedItems.Dispose();
            }
        }

        private void ItemsDataGridViewDefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            e.Row.Cells["ItemsCreateDateColumn"].Value = currentDate;
            e.Row.Cells["ItemsModifiedDateColumn"].Value = currentDate;
            if (ItemsToolStripComboBox != null)
            {
                if (ItemsToolStripComboBox.ComboBox != null)
                {
                    e.Row.Cells["ItemsAuctionIdColumn"].Value =
                        ((Auction) ItemsToolStripComboBox.ComboBox.SelectedItem).Id;
                }
            }
            e.Row.Cells["BidIncrementTypeComboBoxColumn"].Value = 1;
        }        
        
        private void ItemsDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            MainFormStatusLabel.Visible = false;
        }
        #endregion

        #region Donors Event Handlers
        private void DonorsDataGridViewDataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
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
        #endregion

        #region Auctions Event Handlers
        private void AuctionsDataGridViewDataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }

        private void AuctionsSaveAllChangesButtonClick(object sender, EventArgs e)
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
            AuctionsSaveAllChangesButtonClick(sender, e);
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
                string initLocation = Properties.Settings.Default.InitialLocation;
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
                Properties.Settings.Default.InitialLocation = initLocation;
                Properties.Settings.Default.Save();
            }
        }

        private void BindItemsToolStripComboBox()
        {
            List<Auction> auctions = silentAuctionDataSet.Auctions.DataTableToList<Auction>();
            auctions.Insert(0, new Auction
            {
                Id = 0,
                Name = "-- Please Select --",
                Description = "",
                CreateDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            });

            if (ItemsToolStripComboBox.ComboBox != null)
            {
                ItemsToolStripComboBox.ComboBox.DataSource = auctions;
                ItemsToolStripComboBox.ComboBox.ValueMember = "Id";
                ItemsToolStripComboBox.ComboBox.DisplayMember = "Name";
            }
        }
        #endregion

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
    }
}
