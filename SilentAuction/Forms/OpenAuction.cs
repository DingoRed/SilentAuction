using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void OpenAuctionFormLoad(object sender, EventArgs e)
        {
            auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);
        }

        private void OpenButtonClick(object sender, EventArgs e)
        {
            AuctionId = MathHelper.ParseIntZeroIfNull(AuctionComboBox.SelectedValue.ToString());
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelOpenButtonClick(object sender, EventArgs e)
        {

        }
    }
}
