using System;
using System.Data;
using System.Windows.Forms;
using SilentAuction.Properties;
using SilentAuction.Utilities;

namespace SilentAuction.Forms
{
    public partial class EditDonorList : Form
    {
        #region Properties
        private int AuctionIdInUse { get; set; }
        #endregion

        #region Form Event Handlers
        public EditDonorList(int auctionId)
        {
            AuctionIdInUse = auctionId;
            InitializeComponent();
        }

        private void EditDonorListFormLoad(object sender, EventArgs e)
        {
            auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);
            requestStatusTypesTableAdapter.FillRequestStatusType(silentAuctionDataSet.RequestStatusTypes);
            requestFormatTypesTableAdapter.FillRequestFormatTypes(silentAuctionDataSet.RequestFormatTypes);
            donorTypesTableAdapter.FillDonorTypes(silentAuctionDataSet.DonorTypes);
            donorsTableAdapter.FillByAuctionId(silentAuctionDataSet.Donors, AuctionIdInUse);

            WindowSettings.SetupInitialWindow(this, "EditDonorListInitialLocation");
            LoadSettings();
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
                WindowSettings.SaveWindowSettings(this, "EditDonorListInitialLocation");
                SaveSettings();
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
                donorsTableAdapter.FillByAuctionId(silentAuctionDataSet.Donors, AuctionIdInUse);
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
            DonorsDonorTypeColumn.Width = Settings.Default.DonorsDonorTypeColumnWidth;
            DonorsNameColumn.Width = Settings.Default.DonorsNameColumnWidth;
            DonorsRequestFormatTypeIdColumn.Width = Settings.Default.DonorsRequestFormatTypeIdColumnWidth;
            DonorsRequestStatusTypeIdColumn.Width = Settings.Default.DonorsRequestStatusTypeIdColumnWidth;
            DonorsContactNameColumn.Width = Settings.Default.DonorsContactNameColumnWidth;
            DonorsEmailColumn.Width = Settings.Default.DonorsEmailColumnWidth;
            DonorsUrlColumn.Width = Settings.Default.DonorsUrlColumnWidth;
            DonorsStreet1Column.Width = Settings.Default.DonorsStreet1ColumnWidth;
            DonorsStreet2Column.Width = Settings.Default.DonorsStreet2ColumnWidth;
            DonorsCityColumn.Width = Settings.Default.DonorsCityColumnWidth;
            DonorsStateColumn.Width = Settings.Default.DonorsStateColumnWidth;
            DonorsZipCodeColumn.Width = Settings.Default.DonorsZipCodeColumnWidth;
            DonorsPhone1Column.Width = Settings.Default.DonorsPhone1ColumnWidth;
            DonorsExt1Column.Width = Settings.Default.DonorsExt1ColumnWidth;
            DonorsPhone2Column.Width = Settings.Default.DonorsPhone2ColumnWidth;
            DonorsExt2Column.Width = Settings.Default.DonorsExt2ColumnWidth;
        }

        private void SaveSettings()
        {
            Settings.Default.DonorsDonorTypeColumnWidth = DonorsDonorTypeColumn.Width;
            Settings.Default.DonorsNameColumnWidth = DonorsNameColumn.Width;
            Settings.Default.DonorsRequestFormatTypeIdColumnWidth = DonorsRequestFormatTypeIdColumn.Width;
            Settings.Default.DonorsRequestStatusTypeIdColumnWidth = DonorsRequestStatusTypeIdColumn.Width;
            Settings.Default.DonorsContactNameColumnWidth = DonorsContactNameColumn.Width;
            Settings.Default.DonorsEmailColumnWidth = DonorsEmailColumn.Width;
            Settings.Default.DonorsUrlColumnWidth = DonorsUrlColumn.Width;
            Settings.Default.DonorsStreet1ColumnWidth = DonorsStreet1Column.Width;
            Settings.Default.DonorsStreet2ColumnWidth = DonorsStreet2Column.Width;
            Settings.Default.DonorsCityColumnWidth = DonorsCityColumn.Width;
            Settings.Default.DonorsStateColumnWidth = DonorsStateColumn.Width;
            Settings.Default.DonorsZipCodeColumnWidth = DonorsZipCodeColumn.Width;
            Settings.Default.DonorsPhone1ColumnWidth = DonorsPhone1Column.Width;
            Settings.Default.DonorsExt1ColumnWidth = DonorsExt1Column.Width;
            Settings.Default.DonorsPhone2ColumnWidth = DonorsPhone2Column.Width;
            Settings.Default.DonorsExt2ColumnWidth = DonorsExt2Column.Width;

            Settings.Default.Save();
        }
        #endregion
    }
}
