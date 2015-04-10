using System;
using System.Windows.Forms;
using SilentAuction.Utilities;

namespace SilentAuction.Forms
{
    public partial class CreateNewItemForm : Form
    {
        #region Properties
        private int AuctionId { get; set; }
        #endregion

        #region Constructor
        public CreateNewItemForm(int auctionId)
        {
            AuctionId = auctionId;
            InitializeComponent();
        }
        #endregion

        #region Form Event Handlers
        private void CreateItemLoad(object sender, EventArgs e)
        {
            donationDeliveryTypesTableAdapter.FillDonationDeliveryTypes(silentAuctionDataSet.DonationDeliveryTypes);
            bidIncrementTypesTableAdapter.FillBidIncremenetTypes(silentAuctionDataSet.BidIncrementTypes);
            itemTypesTableAdapter.FillItemTypes(silentAuctionDataSet.ItemTypes);
            requestStatusTypesTableAdapter.FillRequestStatusType(silentAuctionDataSet.RequestStatusTypes);
            requestFormatTypesTableAdapter.FillRequestFormatTypes(silentAuctionDataSet.RequestFormatTypes);
            donorTypesTableAdapter.FillDonorTypes(silentAuctionDataSet.DonorTypes);
            auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);

            if (AuctionId > 0)
            {
                donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors, AuctionId);
                itemsTableAdapter.FillItems(silentAuctionDataSet.Items, AuctionId);
                AuctionsComboBox.Enabled = false;
            }

            AuctionsComboBox.SelectedValue = AuctionId;

            // TODO: Load Window Settings

        }

        private void CreateNewItemFormFormClosing(object sender, FormClosingEventArgs e)
        {
            // TODO: Window Settings
        }
        #endregion

        #region Top Section Event Handlers
        private void AuctionsComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (AuctionsComboBox.SelectedValue != null)
            {
                AuctionId = MathHelper.ParseIntZeroIfNull(AuctionsComboBox.SelectedValue.ToString());
                donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors, AuctionId);
            }
        }
        #endregion

        #region Item Section Event Handlers
        private void ItemPictureBoxClick(object sender, EventArgs e)
        {
            // TODO: Implement Picture Box
        }
        #endregion

        #region Bid Section Event Handlers
        private void BidIncrementTypesComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: Disable/Enable textboxes for bids
        }

        private void BidCalculatorButtonClick(object sender, EventArgs e)
        {
            // TODO: Open bid calculator
        }

        #endregion

        #region Button Section Event Handlers
        private void SaveItemButtonClick(object sender, EventArgs e)
        {
            // TODO: Implement save
            string myVal = DigitsOnly(RetailValueTextBox.Text);
            decimal x;
            MessageBox.Show(decimal.TryParse(myVal, out x) + "   " + MathHelper.ParseDecimalZeroIfNull(myVal));
            ClearForm();
        }

        private void SaveItemAndCloseButtonClick(object sender, EventArgs e)
        {
            // TODO: Implement save and close
        }
        #endregion

        #region Generic Event Handlers
        private void TextBoxEnter(object sender, EventArgs e)
        {
            SelectTextInTextBox((TextBox)sender);
        }

        private void TextBoxLeaveFormatCurrency(object sender, EventArgs e)
        {
            TextBox sndr = (TextBox) sender;
            if(!string.IsNullOrEmpty(sndr.Text))
                sndr.Text = string.Format("{0:c}", DecimalAsCurrency(sndr.Text));
        }
        #endregion
        
        #region Private Methods

        private string DigitsOnly(string value)
        {
            string retVal = "";
            foreach (Char c in value.ToCharArray())
            {
                if (Char.IsDigit(c))
                    retVal += c;
                else if (c == '.')
                    retVal += c;
            }

            return retVal;
        }

        private string DecimalAsCurrency(string value)
        {
            return string.Format("{0:c}", MathHelper.ParseDecimalZeroIfNull(DigitsOnly(value)));
        }

        private bool IsValidForm()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(NameTextBox.Text))
            {
                itemErrorProvider.SetError(NameTextBox, "Item Name required");
                isValid = false;
            }

            if (string.IsNullOrEmpty(QtyTextBox.Text))
            {
                itemErrorProvider.SetError(QtyTextBox, "Quantity required");
                isValid = false;
            }
            else if (MathHelper.ParseIntZeroIfNull(QtyTextBox.Text) <= 0)
            {
                itemErrorProvider.SetError(QtyTextBox, "Quantity must be greater than zero");
                isValid = false;
            }

            if (!string.IsNullOrEmpty(RetailValueTextBox.Text))
            {
                if (MathHelper.ParseDecimalZeroIfNull(RetailValueTextBox.Text) < 0)
                {
                    itemErrorProvider.SetError(RetailValueTextBox, "Retail Value must be greater than or equal to zero");
                    isValid = false;
                }
            }

            if (!string.IsNullOrEmpty(MinimumBidTextBox.Text))
            {
                if (MathHelper.ParseDecimalZeroIfNull(MinimumBidTextBox.Text) < 0)
                {
                    itemErrorProvider.SetError(MinimumBidTextBox, "Minimum Bid must be greater than or equal to zero");
                    isValid = false;
                }
            }

            if (!string.IsNullOrEmpty(MaximumBidTextBox.Text))
            {
                if (MathHelper.ParseDecimalZeroIfNull(MaximumBidTextBox.Text) < 0)
                {
                    itemErrorProvider.SetError(MaximumBidTextBox, "Maximum Bid must be greater than or equal to zero");
                    isValid = false;
                }
            }

            if (!string.IsNullOrEmpty(BuyItNowTextBox.Text))
            {
                if (MathHelper.ParseDecimalZeroIfNull(BuyItNowTextBox.Text) < 0)
                {
                    itemErrorProvider.SetError(BuyItNowTextBox, "Buy It Now value must be greater than or equal to zero");
                    isValid = false;
                }
            }

            if (!string.IsNullOrEmpty(BidIncrementValueTextBox.Text))
            {
                if (MathHelper.ParseDecimalZeroIfNull(BidIncrementValueTextBox.Text) <= 0)
                {
                    itemErrorProvider.SetError(BidIncrementValueTextBox, "Bid Increment value must be greater than zero");
                    isValid = false;
                }
            }

            if (!string.IsNullOrEmpty(NumberOfBidsTextBox.Text))
            {
                if (MathHelper.ParseIntZeroIfNull(NumberOfBidsTextBox.Text) <= 0)
                {
                    itemErrorProvider.SetError(NumberOfBidsTextBox, "Number of Bids must be greater than zero");
                    isValid = false;
                }
            }

            return isValid;
        }




        private void ClearForm()
        {
            NameTextBox.Text = string.Empty;
            QtyTextBox.Text = string.Empty;
            DescriptionTextBox.Text = string.Empty;
            NotesTextBox.Text = string.Empty;
            RetailValueTextBox.Text = string.Empty;
            MinimumBidTextBox.Text = string.Empty;
            MaximumBidTextBox.Text = string.Empty;
            BuyItNowTextBox.Text = string.Empty;
            BidIncrementValueTextBox.Text = string.Empty;
            NumberOfBidsTextBox.Text = string.Empty;

            ItemTypesComboBox.SelectedIndex = 0;
            DonationDeliveryTypesComboBox.SelectedIndex = 0;
            BidIncrementTypesComboBox.SelectedIndex = 0;

            ItemPictureBox.Image = null;
        }

        private void SelectTextInTextBox(TextBox textBox)
        {
            if (textBox != null)
                BeginInvoke((Action)textBox.SelectAll);
        }

        #endregion

    }
}
