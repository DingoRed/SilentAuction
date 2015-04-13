using System;
using System.Windows.Forms;
using SilentAuction.Utilities;

namespace SilentAuction.Forms
{
    public partial class ReportNoResponseByDonor : Form
    {
        #region Constructor
        public ReportNoResponseByDonor()
        {
            InitializeComponent();
        }
        #endregion
           
        #region Form Event Handlers
        private void NoResponseByDonorLoad(object sender, EventArgs e)
        {
            auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);
            requestStatusTypesTableAdapter.FillRequestStatusType(silentAuctionDataSet.RequestStatusTypes);
            DoData();
            WindowSettings.SetupInitialWindow(this, "NoResponseByDonorInitialLocation");
        }

        private void NoResponseByDonorFormClosing(object sender, FormClosingEventArgs e)
        {
            WindowSettings.SaveWindowSettings(this, "NoResponseByDonorInitialLocation");
        }
        #endregion

        private void AuctionsComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            DoData();
        }

        private void DoData()
        {
            int auctionId = MathHelper.ParseIntZeroIfNull(auctionsComboBox.SelectedValue.ToString());
            DonorsWithNoResponseTableAdapter.FillDonorsWithNoResponse(silentAuctionDataSet.DonorsWithNoResponse, auctionId);
        }

    }
}
