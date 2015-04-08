using System;
using System.Windows.Forms;
using SilentAuction.Utilities;

namespace SilentAuction.Forms
{
    public partial class DocumentOpenForm : Form
    {
        private int AuctionId { get; set; }
        public int DocumentId { get; set; }

        public DocumentOpenForm(int auctionId)
        {
            AuctionId = auctionId;
            InitializeComponent();
        }

        private void DocumentOpenFormLoad(object sender, EventArgs e)
        {
            auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);
            documentsTableAdapter.FillDocuments(silentAuctionDataSet.Documents);

            WindowSettings.SetupInitialWindow(this, "DocumentOpenFormInitialLocation");
        }

        private void DocumentOpenFormClosing(object sender, FormClosingEventArgs e)
        {
            WindowSettings.SaveWindowSettings(this, "DocumentOpenFormInitialLocation");
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
