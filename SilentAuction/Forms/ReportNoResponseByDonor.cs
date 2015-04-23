using System;
using System.Linq;
using System.Windows.Forms;
using SilentAuction.Utilities;

namespace SilentAuction.Forms
{
    public partial class ReportNoResponseByDonor : Form
    {
        private long? NoResponseId { get; set; }

        #region Constructor
        public ReportNoResponseByDonor()
        {
            InitializeComponent();
        }
        #endregion
           
        #region Form Event Handlers
        private void NoResponseByDonorLoad(object sender, EventArgs e)
        {
            requestStatusTypesTableAdapter.FillRequestStatusType(silentAuctionDataSet.RequestStatusTypes);
            auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);
            var requestStatusTypesRow = silentAuctionDataSet.RequestStatusTypes
                .FirstOrDefault(a => a.Name == "No Response");

            if (requestStatusTypesRow != null)
            {
                NoResponseId = requestStatusTypesRow.Id;
            }

            DoData();
            WindowSettings.SetupInitialWindow(this, "NoResponseByDonorInitialLocation");
        }

        private void NoResponseByDonorFormClosing(object sender, FormClosingEventArgs e)
        {
            WindowSettings.SaveWindowSettings(this, "NoResponseByDonorInitialLocation");
        }
        #endregion

        #region Event Handlers
        private void AuctionsComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            DoData();
        }
        #endregion

        #region Private Methods
        private void DoData()
        {
            int auctionId = MathHelper.ParseIntZeroIfNull(auctionsComboBox.SelectedValue.ToString());
            
            silentAuctionDataSet.Donors.Clear();
            donorsTableAdapter.FillByRequestStatusTypeId(silentAuctionDataSet.Donors, auctionId, NoResponseId);
        }
        #endregion
    }
}
