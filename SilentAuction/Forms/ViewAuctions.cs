using System;
using System.Drawing;
using System.Windows.Forms;
using SilentAuction.Properties;

namespace SilentAuction.Forms
{
    public partial class ViewAuctionsForm : Form
    {
        #region Form Event Handlers
        public ViewAuctionsForm()
        {
            InitializeComponent();
        }

        private void ViewAuctionsLoad(object sender, EventArgs e)
        {
            auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);

            SetupInitialWindow();
            SetupGrids();
        }

        private void ViewAuctionsFormFormClosing(object sender, FormClosingEventArgs e)
        {
            SaveWindowSettings();
            SaveGridSettings();
        }
        #endregion

        #region Private Methods
        private void SetupInitialWindow()
        {
            if ((ModifierKeys & Keys.Shift) == 0)
            {
                string initLocation = Settings.Default.ViewAuctionsFormInitialLocation;
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
                Settings.Default.ViewAuctionsFormInitialLocation = initLocation;
                Settings.Default.Save();
            }
        }

        private void SetupGrids()
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
