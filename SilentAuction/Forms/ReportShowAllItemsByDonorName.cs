using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SilentAuction.Utilities;

namespace SilentAuction.Forms
{
    public partial class ReportShowAllItemsByDonorName : Form
    {
        #region Constructor
        public ReportShowAllItemsByDonorName()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Event Handlers
        private void SearchByDonorNameLoad(object sender, EventArgs e)
        {
            bidIncrementTypesTableAdapter.FillBidIncremenetTypes(silentAuctionDataSet.BidIncrementTypes);
            donationDeliveryTypesTableAdapter.FillDonationDeliveryTypes(silentAuctionDataSet.DonationDeliveryTypes);
            itemTypesTableAdapter.FillItemTypes(silentAuctionDataSet.ItemTypes);
            auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);
            requestStatusTypesTableAdapter.FillRequestStatusType(silentAuctionDataSet.RequestStatusTypes);
            requestFormatTypesTableAdapter.FillRequestFormatTypes(silentAuctionDataSet.RequestFormatTypes);
            donorTypesTableAdapter.FillDonorTypes(silentAuctionDataSet.DonorTypes);

            donorsTableAdapter.FillAllDonors(silentAuctionDataSet.Donors);

            List<string> donorNamesList = silentAuctionDataSet.Donors.Select(a => a.Name).Distinct().ToList();
            donorsComboBox.DataSource = donorNamesList;
            DoData();

            WindowSettings.SetupInitialWindow(this, "ShowAllItemsByDonorNamesInitialLocation");
        }

        private void ShowAllItemsByDonorNameFormClosing(object sender, FormClosingEventArgs e)
        {
            WindowSettings.SaveWindowSettings(this, "ShowAllItemsByDonorNamesInitialLocation");
        }
        #endregion

        #region Other Event Handlers
        private void DonorsComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            DoData();
        }
        #endregion

        #region Private Methods
        private void DoData()
        {
            string donorName = donorsComboBox.SelectedItem.ToString();
            itemsTableAdapter.FillItemsByDonorName(silentAuctionDataSet.Items, donorName);
        }
        #endregion
    }
}
