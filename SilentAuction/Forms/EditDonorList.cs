using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SilentAuction.Properties;
using SilentAuction.Utilities;

namespace SilentAuction.Forms
{
    public partial class EditDonorList : Form
    {
        #region Properties
        public int AuctionIdInUse { get; set; }
        #endregion

        #region Form Event Handlers
        public EditDonorList()
        {
            InitializeComponent();
        }

        private void EditDonorListFormLoad(object sender, EventArgs e)
        {
            auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);
            requestStatusTypesTableAdapter.FillRequestStatusType(silentAuctionDataSet.RequestStatusTypes);
            requestFormatTypesTableAdapter.FillRequestFormatTypes(silentAuctionDataSet.RequestFormatTypes);
            donorTypesTableAdapter.FillDonorTypes(silentAuctionDataSet.DonorTypes);
            donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors, AuctionIdInUse);

            SetupInitialWindow();
            OpenGridSettings();
        }

        private void EditDonorListFormClosing(object sender, FormClosingEventArgs e)
        {
            donorsBindingSource.EndEdit();
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
        private void DonorsSaveAllButtonClick(object sender, EventArgs e)
        {
            SilentAuctionDataSet.DonorsDataTable modifiedItems =
                (SilentAuctionDataSet.DonorsDataTable)silentAuctionDataSet.Donors.GetChanges(DataRowState.Modified);

            try
            {
                if (modifiedItems != null)
                {
                    foreach (DataRow row in modifiedItems.Rows)
                    {
                        row["ModifiedDate"] = DateTime.Now;
                    }

                    donorsTableAdapter.Update(modifiedItems);
                }

                silentAuctionDataSet.AcceptChanges();
                donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors, AuctionIdInUse);
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
                string initLocation = Settings.Default.EditDonorListInitialLocation;
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
                Settings.Default.EditDonorListInitialLocation = initLocation;
                Settings.Default.Save();
            }
        }

        private void OpenGridSettings()
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
            RequestStatusTypeIdColumn.Width = Settings.Default.DonorsRequestStatusTypeIdColumnWidth;
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
            Settings.Default.DonorsRequestStatusTypeIdColumnWidth = RequestStatusTypeIdColumn.Width;

            Settings.Default.Save();
        }

        #endregion
    }
}
