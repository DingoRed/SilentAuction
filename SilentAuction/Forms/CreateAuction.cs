using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SilentAuction.Forms
{
    public partial class CreateNewAuctionForm : Form
    {
        #region Properties
        public int AuctionId { get; set; }
        #endregion

        #region Form Event Handlers
        public CreateNewAuctionForm()
        {
            InitializeComponent();
        }

        private void CreateNewAuctionFormLoad(object sender, EventArgs e)
        {
            auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);
        }
        #endregion

        #region Event Handlers
        private void SaveButtonClick(object sender, EventArgs e)
        {
            if (!ValidForm()) return;
            
            SaveAuctionData();
            DialogResult = DialogResult.None;

            ClearForm();
        }

        private void SaveAuctionAndCloseButtonClick(object sender, EventArgs e)
        {
            if (!ValidForm()) return;

            SaveAuctionData();
            DialogResult = DialogResult.OK;
        }

        private void NameTextBoxTextChanged(object sender, EventArgs e)
        {
            ErrorLabel.Visible = AuctionNameExists();
        }
        #endregion

        #region Private Methods
        private bool ValidForm()
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
                return false;

            if (AuctionNameExists())
            {
                ErrorLabel.Visible = true;
                return false;
            }

            ErrorLabel.Visible = false;

            return true;
        }

        private void SaveAuctionData()
        {
            DateTime currentDate = DateTime.Now;
            silentAuctionDataSet.Auctions.AddAuctionsRow(NameTextBox.Text, DescriptionTextBox.Text,
                currentDate.ToString(), currentDate.ToString());

            SilentAuctionDataSet.AuctionsDataTable newItems =
                (SilentAuctionDataSet.AuctionsDataTable) silentAuctionDataSet.Auctions.GetChanges(DataRowState.Added);

            if (newItems != null)
            {
                auctionsTableAdapter.Update(newItems);
                silentAuctionDataSet.AcceptChanges();
                newItems.Dispose();
                auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);
            }

            AuctionId = (int) silentAuctionDataSet.Auctions.Max(a => a.Id);
        }
        
        private bool AuctionNameExists()
        {
            return silentAuctionDataSet.Auctions.Any(a => a.Name == NameTextBox.Text);
        }

        private void ClearForm()
        {
            NameTextBox.Text = string.Empty;
            DescriptionTextBox.Text = string.Empty;
        }
        #endregion
    }
}
