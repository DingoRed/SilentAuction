using System;
using System.Data;
using System.Drawing;
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

            SetupInitialWindow();
            OpenGridSettings();
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
                SaveWindowSettings();
                SaveGridSettings();
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
        private void SetupInitialWindow()
        {
            if ((ModifierKeys & Keys.Shift) == 0)
            {
                string initLocation = Settings.Default.EditAuctionListInitialLocation;
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
                Settings.Default.EditAuctionListInitialLocation = initLocation;
                Settings.Default.Save();
            }
        }

        private void OpenGridSettings()
        {
            // Auctions grid settings...
            AuctionsNameColumn.Width = Settings.Default.AuctionsNameColumnWidth;
            AuctionsDescriptionColumn.Width = Settings.Default.AuctionsDescriptionColumnWidth;

        }

        private void SaveGridSettings()
        {
            // Donors grid user settings...
            Settings.Default.AuctionsNameColumnWidth = AuctionsNameColumn.Width;
            Settings.Default.AuctionsDescriptionColumnWidth = AuctionsDescriptionColumn.Width;

            Settings.Default.Save();
        }


        #endregion
    }
}
