using System;
using System.Data;
using System.Windows.Forms;
using SilentAuction.Properties;
using SilentAuction.Utilities;

namespace SilentAuction.Forms
{
    public partial class EditAuctionList : Form
    {
        #region Form Event Handlers
        public EditAuctionList()
        {
            InitializeComponent();
        }

        private void ViewAuctionsLoad(object sender, EventArgs e)
        {
            auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);

            WindowSettings.SetupInitialWindow(this, "EditAuctionListInitialLocation");
            LoadSettings();
        }

        private void ViewAuctionsFormFormClosing(object sender, FormClosingEventArgs e)
        {
            auctionsBindingSource.EndEdit();
            var silentAuctionDataSetChanges = silentAuctionDataSet.GetChanges();
            if (silentAuctionDataSetChanges != null)
            {
                e.Cancel = GenericPageHelper.StayOnPage();
            }

            if (!e.Cancel)
            {
                WindowSettings.SaveWindowSettings(this, "EditAuctionListInitialLocation");
                SaveSettings();
            }
        }
        #endregion

        #region Event Handlers
        private void AuctionsSaveAllButtonClick(object sender, EventArgs e)
        {
            SilentAuctionDataSet.AuctionsDataTable modifiedItems =
                (SilentAuctionDataSet.AuctionsDataTable)silentAuctionDataSet.Auctions.GetChanges(DataRowState.Modified);

            try
            {
                if (modifiedItems != null)
                {
                    foreach (DataRow row in modifiedItems.Rows)
                    {
                        row["ModifiedDate"] = DateTime.Now;
                    }

                    auctionsTableAdapter.Update(modifiedItems);
                }

                silentAuctionDataSet.AcceptChanges();
                auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Failed: " + ex.Message);
            }
            finally
            {
                if (modifiedItems != null)
                    modifiedItems.Dispose();
            }
        }
        #endregion

        #region Private Methods
        private void LoadSettings()
        {
            AuctionsNameColumn.Width = Settings.Default.AuctionsNameColumnWidth;
            AuctionsDescriptionColumn.Width = Settings.Default.AuctionsDescriptionColumnWidth;
        }

        private void SaveSettings()
        {
            Settings.Default.AuctionsNameColumnWidth = AuctionsNameColumn.Width;
            Settings.Default.AuctionsDescriptionColumnWidth = AuctionsDescriptionColumn.Width;

            Settings.Default.Save();
        }
        #endregion
    }
}
