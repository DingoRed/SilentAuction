using System;
using System.Drawing;
using System.Windows.Forms;
using SilentAuction.Properties;

namespace SilentAuction.Forms
{
    public partial class ViewDonorsForm : Form
    {
        #region Form Event Handlers
        public ViewDonorsForm()
        {
            InitializeComponent();
        }

        private void ViewDonorsFormLoad(object sender, EventArgs e)
        {
            requestFormatTypesTableAdapter.FillRequestFormatTypes(silentAuctionDataSet.RequestFormatTypes);
            donorTypesTableAdapter.FillDonorTypes(silentAuctionDataSet.DonorTypes);
            donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors);

            SetupInitialWindow();
            SetupGrids();
        }

        private void ViewDonorsFormFormClosing(object sender, FormClosingEventArgs e)
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
                string initLocation = Settings.Default.ViewDonorsFormInitialLocation;
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
                Settings.Default.ViewDonorsFormInitialLocation = initLocation;
                Settings.Default.Save();
            }
        }

        private void SetupGrids()
        {
            // Donors grid settings...
            DonorTypeColumn.Width = Settings.Default.DonorsDonorTypeColumnWidth;
            NameColumn.Width = Settings.Default.DonorsNameColumnWidth;
            ContactNameColumn.Width = Settings.Default.DonorsContactNameColumnWidth;
            Street1Column.Width = Settings.Default.DonorsStreet1ColumnWidth;
            Street2Column.Width = Settings.Default.DonorsStreet2ColumnWidth;
            CityColumn.Width = Settings.Default.DonorsCityColumnWidth;
            StateColumn.Width = Settings.Default.DonorsStateColumnWidth;
            ZipCodeColumn.Width = Settings.Default.DonorsZipCodeColumnWidth;
            Phone1Column.Width = Settings.Default.DonorsPhone1ColumnWidth;
            Phone2Column.Width = Settings.Default.DonorsPhone2ColumnWidth;
            EmailColumn.Width = Settings.Default.DonorsEmailColumnWidth;
            RequestFormatTypeIdColumn.Width = Settings.Default.DonorsRequestFormatTypeIdColumnWidth;
            UrlColumn.Width = Settings.Default.DonorsUrlColumnWidth;
        }

        private void SaveGridSettings()
        {
            // Donors grid user settings...
            Settings.Default.DonorsDonorTypeColumnWidth = DonorTypeColumn.Width;
            Settings.Default.DonorsNameColumnWidth = NameColumn.Width;
            Settings.Default.DonorsContactNameColumnWidth = ContactNameColumn.Width;
            Settings.Default.DonorsStreet1ColumnWidth = Street1Column.Width;
            Settings.Default.DonorsStreet2ColumnWidth = Street2Column.Width;
            Settings.Default.DonorsCityColumnWidth = CityColumn.Width;
            Settings.Default.DonorsStateColumnWidth = StateColumn.Width;
            Settings.Default.DonorsZipCodeColumnWidth = ZipCodeColumn.Width;
            Settings.Default.DonorsPhone1ColumnWidth = Phone1Column.Width;
            Settings.Default.DonorsExt1ColumnWidth = Ext1Column.Width;
            Settings.Default.DonorsPhone2ColumnWidth = Phone2Column.Width;
            Settings.Default.DonorsExt2ColumnWidth = Ext2Column.Width;
            Settings.Default.DonorsEmailColumnWidth = EmailColumn.Width;
            Settings.Default.DonorsRequestFormatTypeIdColumnWidth = RequestFormatTypeIdColumn.Width;
            Settings.Default.DonorsUrlColumnWidth = UrlColumn.Width;

            Settings.Default.Save();
        }

        #endregion
    }
}
