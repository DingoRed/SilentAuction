using System;
using System.Windows.Forms;
using SilentAuction.Utilities;

namespace SilentAuction.Forms
{
    public partial class OpenAuctionForm : Form
    {
        public int AuctionId { get; set; }

        public OpenAuctionForm()
        {
            InitializeComponent();
        }

        #region Form Event Handlers
        private void OpenAuctionFormLoad(object sender, EventArgs e)
        {
            auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);

            WindowSettings.SetupInitialWindow(this, "OpenAuctionInitialLocation");
        }

        private void OpenAuctionFormFormClosing(object sender, FormClosingEventArgs e)
        {
            WindowSettings.SaveWindowSettings(this, "OpenAuctionInitialLocation");
        }
        #endregion

        #region Event Handlers
        private void OpenButtonClick(object sender, EventArgs e)
        {
            AuctionId = MathHelper.ParseIntZeroIfNull(AuctionComboBox.SelectedValue.ToString());
            DialogResult = DialogResult.OK;
            Close();
        }
        #endregion
    }
}
