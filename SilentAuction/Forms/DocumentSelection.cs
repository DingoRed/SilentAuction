using System;
using System.Windows.Forms;
using SilentAuction.Utilities;

namespace SilentAuction.Forms
{
    public partial class DocumentSelection : Form
    {
        private int AuctionId { get; set; }
        public int DocumentId { get; set; }

        public DocumentSelection(int auctionId)
        {
            AuctionId = auctionId;
            InitializeComponent();
        }

        private void DocumentSelectionLoad(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'silentAuctionDataSet.Auctions' table. You can move, or remove it, as needed.
            this.auctionsTableAdapter.FillAuctions(this.silentAuctionDataSet.Auctions);
            documentsTableAdapter.FillDocuments(silentAuctionDataSet.Documents);
            // TODO: Set window locations
        }

        private void DocumentSelectionFormClosing(object sender, FormClosingEventArgs e)
        {
            // TODO: Set window locations
        }

        private void SelectDocumentButtonClick(object sender, EventArgs e)
        {
            if (DocumentsComboBox.SelectedValue != null)
            {
                DocumentId = MathHelper.ParseIntZeroIfNull(DocumentsComboBox.SelectedValue.ToString());
                DialogResult = DialogResult.OK;
            }
            else DialogResult = DialogResult.Cancel;

            Close();
        }

    }
}
