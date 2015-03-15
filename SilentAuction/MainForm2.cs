using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SilentAuction.Core.Entities;
using SilentAuction.Utilities.Extensions;

namespace SilentAuction
{
    public partial class MainForm2 : Form
    {
        #region Constructor and Form Methods
        public MainForm2()
        {
            InitializeComponent();
        }

        private void MainForm2Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'silentAuctionDataSet.Auctions' table. You can move, or remove it, as needed.
            auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);
            // TODO: This line of code loads data into the 'silentAuctionDataSet.Donors' table. You can move, or remove it, as needed.
            donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors);

            //itemsTableAdapter.FillItems(silentAuctionDataSet.Items, 0);

            List<Auction> auctions = silentAuctionDataSet.Auctions.DataTableToList<Auction>();

            if (ItemsToolStripComboBox.ComboBox != null)
            {
                //itemsToolStripComboBox.ComboBox.DataSource = auctions;
                ItemsToolStripComboBox.ComboBox.Items.AddRange(auctions.ToArray());
                ItemsToolStripComboBox.ComboBox.ValueMember = "Id";
                ItemsToolStripComboBox.ComboBox.DisplayMember = "Name";
            }
        }
        #endregion

        private void MainForm2FormClosed(object sender, FormClosedEventArgs e)
        {
            // MessageBox.Show("Save window info here");
        }

        private void ItemsToolStripComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                itemsTableAdapter.FillItems(silentAuctionDataSet.Items,
                    ((Auction) ItemsToolStripComboBox.SelectedItem).Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ItemsDataGridViewDataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }

        private void ItemsSaveAllButtonClick(object sender, EventArgs e)
        {
            SilentAuctionDataSet.ItemsDataTable newItems =
                (SilentAuctionDataSet.ItemsDataTable) silentAuctionDataSet.Items.GetChanges(DataRowState.Added);

            SilentAuctionDataSet.ItemsDataTable modifiedItems =
                (SilentAuctionDataSet.ItemsDataTable)silentAuctionDataSet.Items.GetChanges(DataRowState.Modified);

            SilentAuctionDataSet.ItemsDataTable deletedItems =
                (SilentAuctionDataSet.ItemsDataTable)silentAuctionDataSet.Items.GetChanges(DataRowState.Deleted);

            try
            {
                bool changesMade = false;
                if (newItems != null)
                {
                    itemsTableAdapter.Update(newItems);
                    changesMade = true;
                }

                if (modifiedItems != null)
                {
                    itemsTableAdapter.Update(modifiedItems);
                    changesMade = true;
                }

                if (deletedItems != null)
                {
                    itemsTableAdapter.Update(deletedItems);
                    changesMade = true;
                }


                if (changesMade)
                {
                    silentAuctionDataSet.AcceptChanges();

                    try
                    {
                        itemsTableAdapter.FillItems(silentAuctionDataSet.Items,
                            ((Auction) ItemsToolStripComboBox.SelectedItem).Id);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    MessageBox.Show("Update Successful");
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

        private void AuctionsSaveAllChangesButtonClick(object sender, EventArgs e)
        {
            SilentAuctionDataSet.AuctionsDataTable newAuctions =
                (SilentAuctionDataSet.AuctionsDataTable)silentAuctionDataSet.Auctions.GetChanges(DataRowState.Added);

            SilentAuctionDataSet.AuctionsDataTable modifiedAuctions =
                (SilentAuctionDataSet.AuctionsDataTable)silentAuctionDataSet.Auctions.GetChanges(DataRowState.Modified);

            SilentAuctionDataSet.AuctionsDataTable deletedAuctions =
                (SilentAuctionDataSet.AuctionsDataTable)silentAuctionDataSet.Auctions.GetChanges(DataRowState.Deleted);

            try
            {
                bool changesMade = false;
                if (newAuctions != null)
                {
                    auctionsTableAdapter.Update(newAuctions);
                    changesMade = true;
                }

                if (modifiedAuctions != null)
                {
                    auctionsTableAdapter.Update(modifiedAuctions);
                    changesMade = true;
                }

                if (deletedAuctions != null)
                {
                    auctionsTableAdapter.Update(deletedAuctions);
                    changesMade = true;
                }
                
                if (changesMade)
                {
                    silentAuctionDataSet.AcceptChanges();

                    try
                    {
                        auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    MessageBox.Show("Update Successful");
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
        }

        private void AuctionsDataGridViewDefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            e.Row.Cells["AuctionsCreateDateColumn"].Value = currentDate;
            e.Row.Cells["AuctionsModifiedDateColumn"].Value = currentDate;
        }
    }
}
