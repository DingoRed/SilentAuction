using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SilentAuction.Forms
{
    public partial class ShowAllItemsByDonorName : Form
    {
        public ShowAllItemsByDonorName()
        {
            InitializeComponent();
        }

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
            
        }

        private void DonorsComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            string donorName = donorsComboBox.SelectedItem.ToString();

            itemsTableAdapter.FillItemsByDonorName(silentAuctionDataSet.Items, donorName);
            
        }
    }
}
