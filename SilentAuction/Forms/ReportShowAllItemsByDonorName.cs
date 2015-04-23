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
            donationDeliveryTypesTableAdapter.FillDonationDeliveryTypes(silentAuctionDataSet.DonationDeliveryTypes);
            itemsTableAdapter.FillItemsByDonorName(silentAuctionDataSet.Items, "");
            donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors);

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
            donorItemsDataGridView.DataSource = silentAuctionDataSet.Items;
        }
        #endregion
    }
}
