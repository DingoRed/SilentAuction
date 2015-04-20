using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;
using SilentAuction.Utilities;

namespace SilentAuction.Forms
{
    public partial class CreateNewItemForm : Form
    {
        #region Fields
        private readonly byte[] _emptyImage = {
            137, 80, 78, 71, 13, 10, 26, 10, 0, 0, 0, 13, 73, 72, 68, 82, 0, 0, 0, 1, 0, 0, 0, 
            1, 8, 6, 0, 0, 0, 31, 21, 196, 137, 0, 0, 0, 1, 115, 82, 71, 66, 0, 174, 206, 28, 
            233, 0, 0, 0, 4, 103, 65, 77, 65, 0, 0, 177, 143, 11, 252, 97, 5, 0, 0, 0, 9, 112, 
            72, 89, 115, 0, 0, 14, 195, 0, 0, 14, 195, 1, 199, 111, 168, 100, 0, 0, 0, 11, 73, 
            68, 65, 84, 24, 87, 99, 96, 0, 2, 0, 0, 5, 0, 1, 170, 213, 200, 81, 0, 0, 0, 0, 73, 
            69, 78, 68, 174, 66, 96, 130
        };
        #endregion

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

            SetupFormElements();

            WindowSettings.SetupInitialWindow(this, "CreateItemInitialLocation");
        }

        private void CreateNewItemFormFormClosing(object sender, FormClosingEventArgs e)
        {
            WindowSettings.SaveWindowSettings(this, "CreateItemInitialLocation");
        }
        #endregion

        #region Top Section Event Handlers
        private void AuctionsComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (AuctionsComboBox.SelectedValue != null)
            {
                itemErrorProvider.SetError(AuctionsComboBox, "");
                itemErrorProvider.SetError(DonorsComboBox, "");
                AuctionId = MathHelper.ParseIntZeroIfNull(AuctionsComboBox.SelectedValue.ToString());
                donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors, AuctionId);
            }
        }
        #endregion

        #region Item Section Event Handlers
        private void ItemPictureBoxClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
                string sep = string.Empty;

                foreach (var c in codecs)
                {
                    string codecName = c.CodecName.Substring(8).Replace("Codec", "Files").Trim();
                    openFileDialog.Filter = String.Format("{0}{1}{2} ({3})|{3}", openFileDialog.Filter, sep,
                        codecName, c.FilenameExtension);
                    sep = "|";
                }

                openFileDialog.Filter = String.Format("{0}{1}{2} ({3})|{3}", openFileDialog.Filter, sep,
                    "All Files", "*.*");

                openFileDialog.DefaultExt = ".PNG"; // Default file extension 

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var bitmap = new Bitmap(openFileDialog.FileName);
                    ItemPictureBox.Image = bitmap;
                }
            }
        }
        #endregion

        #region Bid Section Event Handlers
        private void BidIncrementTypesComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (BidIncrementTypesComboBox.SelectedValue != null)
            {
                int id = MathHelper.ParseIntZeroIfNull(BidIncrementTypesComboBox.SelectedValue.ToString());
                bool isByNumber = id == (int) BidIncrementType.NumberOfBids;

                BidIncrementValueTextBox.Enabled = !isByNumber;
                NumberOfBidsTextBox.Enabled = isByNumber;

                itemErrorProvider.SetError(BidIncrementValueTextBox, "");
                itemErrorProvider.SetError(NumberOfBidsTextBox, "");
            }
        }

        private void BidCalculatorButtonClick(object sender, EventArgs e)
        {
            BidCalculatorForm.GetForm.Show();
        }

        #endregion

        #region Button Section Event Handlers
        private void SaveItemButtonClick(object sender, EventArgs e)
        {
            Text = "Create New Item";
            if (!IsValidForm())
                return;
            
            SaveItemData();
            DialogResult = DialogResult.None;
            ClearForm();
            Text = "Create New Item - Saved Successful";
        }

        private void SaveItemAndCloseButtonClick(object sender, EventArgs e)
        {
            if (!IsValidForm())
                return;

            SaveItemData();
            DialogResult = DialogResult.OK;
            Close();
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
        private void SaveItemData()
        {
            DateTime currentDate = DateTime.Now;
            int auctionId = MathHelper.ParseIntZeroIfNull(AuctionsComboBox.SelectedValue.ToString());
            int donorId = MathHelper.ParseIntZeroIfNull(DonorsComboBox.SelectedValue.ToString());
            int itemTypeId = MathHelper.ParseIntZeroIfNull(ItemTypesComboBox.SelectedValue.ToString());
            int donationDeliveryTypeId = MathHelper.ParseIntZeroIfNull(DonationDeliveryTypesComboBox.SelectedValue.ToString());
            int bidIncrementTypeId = MathHelper.ParseIntZeroIfNull(BidIncrementTypesComboBox.SelectedValue.ToString());
            ImageConverter converter = new ImageConverter();
            var byteArray = (byte[])converter.ConvertTo(ItemPictureBox.Image, typeof(byte[]));
            int qty = MathHelper.ParseIntZeroIfNull(DigitsOnly(QtyTextBox.Text));
            double retailValue = MathHelper.ParseDoubleZeroIfNull(DigitsOnly(RetailValueTextBox.Text));
            double bidMinValue = MathHelper.ParseDoubleZeroIfNull(DigitsOnly(MinimumBidTextBox.Text));
            double bidMaxValue = MathHelper.ParseDoubleZeroIfNull(DigitsOnly(MaximumBidTextBox.Text));
            double bidIncrementValue = MathHelper.ParseDoubleZeroIfNull(DigitsOnly(BidIncrementValueTextBox.Text));
            double buyItNowValue = MathHelper.ParseDoubleZeroIfNull(DigitsOnly(BuyItNowTextBox.Text));
            int numberOfBids = MathHelper.ParseIntZeroIfNull(DigitsOnly(NumberOfBidsTextBox.Text));
            

            SilentAuctionDataSet.AuctionsRow auctionsRow =
                silentAuctionDataSet.Auctions.FirstOrDefault(a => a.Id == auctionId);
            SilentAuctionDataSet.DonorsRow donorsRow =
                silentAuctionDataSet.Donors.FirstOrDefault(d => d.Id == donorId);
            SilentAuctionDataSet.BidIncrementTypesRow bidIncrementTypesRow =
                silentAuctionDataSet.BidIncrementTypes.FirstOrDefault(b => b.Id == bidIncrementTypeId);
            SilentAuctionDataSet.ItemTypesRow itemTypesRow =
                silentAuctionDataSet.ItemTypes.FirstOrDefault(i => i.Id == itemTypeId);
            SilentAuctionDataSet.DonationDeliveryTypesRow donationDeliveryTypesRow =
                silentAuctionDataSet.DonationDeliveryTypes.FirstOrDefault(d => d.Id == donationDeliveryTypeId);

            silentAuctionDataSet.Items.AddItemsRow(donorsRow, auctionsRow, NameTextBox.Text, DescriptionTextBox.Text,
                qty, NotesTextBox.Text, currentDate.ToString(), currentDate.ToString(), retailValue, bidIncrementTypesRow, 
                bidMinValue, bidMaxValue, bidIncrementValue, buyItNowValue, numberOfBids, itemTypesRow,
                donationDeliveryTypesRow, byteArray);

            SilentAuctionDataSet.ItemsDataTable newItems
                = (SilentAuctionDataSet.ItemsDataTable) silentAuctionDataSet.Items.GetChanges(DataRowState.Added);

            if (newItems != null)
            {
                itemsTableAdapter.Update(newItems);
                silentAuctionDataSet.AcceptChanges();
                newItems.Dispose();
                
                itemsTableAdapter.FillItems(silentAuctionDataSet.Items, auctionId);
            }
        }

        private string DecimalAsCurrency(string value)
        {
            return string.Format("{0:c}", MathHelper.ParseDecimalZeroIfNull(DigitsOnly(value)));
        }

        private static string DigitsOnly(string value)
        {
            string retVal = "";
            foreach (Char c in value)
            {
                if (Char.IsDigit(c))
                    retVal += c;
                else if (c == '.')
                    retVal += c;
            }

            return retVal;
        }

        private bool IsValidForm()
        {
            bool isValid = true;
            int qty = MathHelper.ParseIntZeroIfNull(QtyTextBox.Text);
            decimal retailValue = MathHelper.ParseDecimalZeroIfNull(RetailValueTextBox.Text);
            decimal minBid = MathHelper.ParseDecimalZeroIfNull(DigitsOnly(MinimumBidTextBox.Text));
            decimal maxBid = MathHelper.ParseDecimalZeroIfNull(DigitsOnly(MaximumBidTextBox.Text));
            decimal buyItNowValue = MathHelper.ParseDecimalZeroIfNull(DigitsOnly(BuyItNowTextBox.Text));
            int bidIncrementTypeId = MathHelper.ParseIntZeroIfNull(BidIncrementTypesComboBox.SelectedValue.ToString());
            decimal bidIncrementValue = MathHelper.ParseDecimalZeroIfNull(DigitsOnly(BidIncrementValueTextBox.Text));
            int numberOfBids = MathHelper.ParseIntZeroIfNull(NumberOfBidsTextBox.Text);
            string errorMsg = "";

            ClearErrorProviders();

            //ValidateAuction();
            if (AuctionsComboBox.SelectedValue == null)
            {
                itemErrorProvider.SetError(AuctionsComboBox, "Auction is required");
                isValid = false;
            }
            else if(!SilentAuctionValidator.ValidateAuctionId(MathHelper.ParseIntZeroIfNull(AuctionsComboBox.SelectedValue.ToString()), ref errorMsg))
            {
                itemErrorProvider.SetError(AuctionsComboBox, errorMsg);
                isValid = false;
            }

            //ValidateDonor();
            if (DonorsComboBox.SelectedValue == null)
            {
                itemErrorProvider.SetError(DonorsComboBox, "Donor is required");
            }
            else if (!SilentAuctionValidator.ValidateAuctionId(MathHelper.ParseIntZeroIfNull(DonorsComboBox.SelectedValue.ToString()), ref errorMsg))
            {
                itemErrorProvider.SetError(DonorsComboBox, errorMsg);
                isValid = false;
            }

            //isValid = ValidateItemName(isValid);
            if (!SilentAuctionValidator.ValidateItemName(NameTextBox.Text, ref errorMsg))
            {
                itemErrorProvider.SetError(NameTextBox, errorMsg);
                isValid = false;
            }

            //isValid = ValidateQty(isValid);
            if (!SilentAuctionValidator.ValidateQty(qty, ref errorMsg))
            {
                itemErrorProvider.SetError(QtyTextBox, errorMsg);
                isValid = false;
            }

            //isValid = ValidateRetailValue(isValid);
            if (!SilentAuctionValidator.ValidateRetailValue(retailValue, ref errorMsg))
            {
                itemErrorProvider.SetError(RetailValueTextBox, errorMsg);
                isValid = false;
            }

            //minBid = ValidateMinimumBid(minBid, ref isValid);
            if (!SilentAuctionValidator.ValidateMinimumBid(minBid, ref errorMsg))
            {
                itemErrorProvider.SetError(MinimumBidTextBox, errorMsg);
                isValid = false;
            }

            //maxBid = ValidateMaximumBid(maxBid, ref isValid);
            if (!SilentAuctionValidator.ValidateMaximumBid(maxBid, ref errorMsg))
            {
                itemErrorProvider.SetError(MaximumBidTextBox, errorMsg);
                isValid = false;
            }

            if (!SilentAuctionValidator.ValidateMaximumBidGreaterThanMinimumBid(minBid, maxBid, ref errorMsg))
            {
                itemErrorProvider.SetError(MaximumBidTextBox, errorMsg);
                isValid = false;
            }

            //isValid = ValidateBuyItNow(isValid);
            if (!SilentAuctionValidator.ValidateBuyItNow(buyItNowValue, ref errorMsg))
            {
                itemErrorProvider.SetError(BuyItNowTextBox, errorMsg);
                isValid = false;
            }

            if (bidIncrementTypeId == (int) BidIncrementType.IncrementValue)
            {
                if (!SilentAuctionValidator.ValidateBidIncrementValue(minBid, maxBid, bidIncrementValue, ref errorMsg))
                {
                    itemErrorProvider.SetError(BidIncrementValueTextBox, errorMsg);
                    isValid = false;
                }
            }
            else
            {
                if (!SilentAuctionValidator.ValidateNumberOfBids(numberOfBids, ref errorMsg))
                {
                    itemErrorProvider.SetError(NumberOfBidsTextBox, errorMsg);
                    isValid = false;
                }
            }


            //isValid = MathHelper.ParseIntZeroIfNull(BidIncrementTypesComboBox.SelectedValue.ToString()) ==
            //          (int) BidIncrementType.IncrementValue
            //    ? ValidateBidIncrementValue(minBid, maxBid, isValid)
            //    : ValidateNumberOfBids(isValid);

            return isValid;
        }
        
        private void ClearErrorProviders()
        {
            itemErrorProvider.SetError(AuctionsComboBox, "");
            itemErrorProvider.SetError(DonorsComboBox, "");
            itemErrorProvider.SetError(NameTextBox, "");
            itemErrorProvider.SetError(QtyTextBox, "");
            itemErrorProvider.SetError(RetailValueTextBox, "");
            itemErrorProvider.SetError(MinimumBidTextBox, "");
            itemErrorProvider.SetError(MaximumBidTextBox, "");
            itemErrorProvider.SetError(BuyItNowTextBox, "");
            itemErrorProvider.SetError(BidIncrementValueTextBox, "");
            itemErrorProvider.SetError(NumberOfBidsTextBox, "");
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
            {
                BeginInvoke((Action) textBox.SelectAll);
                itemErrorProvider.SetError(textBox, "");
            }
        }

        private void SetupFormElements()
        {
            AuctionsComboBox.SelectedValue = AuctionId;
            RetailValueTextBox.Text = 0.ToString("C");
            BuyItNowTextBox.Text = 0.ToString("C");
            MinimumBidTextBox.Text = 0.ToString("C");
            MaximumBidTextBox.Text = 1.ToString("C");
            BidIncrementValueTextBox.Text = 1.ToString("C");
            NumberOfBidsTextBox.Text = "1";
            ItemTypesComboBox.SelectedValue = 2;
            NumberOfBidsTextBox.Enabled = false;
            ItemPictureBox.Image = (Bitmap)((new ImageConverter()).ConvertFrom(_emptyImage));
        }
        #endregion

        #region Validation Methods
        //private bool ValidateNumberOfBids(bool isValid)
        //{
        //    if (!string.IsNullOrEmpty(NumberOfBidsTextBox.Text))
        //    {
        //        int numberOfBids = MathHelper.ParseIntZeroIfNull(NumberOfBidsTextBox.Text);
        //        if (numberOfBids <= 0)
        //        {
        //            itemErrorProvider.SetError(NumberOfBidsTextBox, "Number of Bids must be greater than zero");
        //            isValid = false;
        //        }
        //        else if (numberOfBids > Constants.MaxNumberOfLines)
        //        {
        //            itemErrorProvider.SetError(NumberOfBidsTextBox,
        //                string.Format("Number of Bids must be less than or equal to {0}",
        //                    Constants.MaxNumberOfLines));
        //            NumberOfBidsTextBox.Text = Constants.MaxNumberOfLines.ToString();
        //            isValid = false;
        //        }
        //    }
        //    return isValid;
        //}

        //private bool ValidateBidIncrementValue(decimal minBid, decimal maxBid, bool isValid)
        //{
        //    if (!string.IsNullOrEmpty(BidIncrementValueTextBox.Text))
        //    {
        //        BidCalculator calculator = new BidCalculator();
        //        var incrementValue = MathHelper.ParseDecimalZeroIfNull(DigitsOnly(BidIncrementValueTextBox.Text));
        //        int numberOfBids = calculator.CalculateNumberOfLines(minBid, maxBid, incrementValue);

        //        if (incrementValue <= 0)
        //        {
        //            itemErrorProvider.SetError(BidIncrementValueTextBox, "Bid Increment value must be greater than zero");
        //            BidIncrementValueTextBox.Text = 1.ToString("C");
        //            isValid = false;
        //        }
        //        else if (numberOfBids > Constants.MaxNumberOfLines)
        //        {
        //            incrementValue = calculator.CalculateAmountPerLine(minBid, maxBid, Constants.MaxNumberOfLines);
        //            itemErrorProvider.SetError(BidIncrementValueTextBox,
        //                string.Format(
        //                    "Bid Increment value too small. The number of bids must calculate to {0} or less.\nUsing the maximum number of lines, this calculates to approximately {1}",
        //                    Constants.MaxNumberOfLines, Math.Ceiling(incrementValue).ToString("C0")));
        //            isValid = false;
        //        }
        //    }
        //    else
        //    {
        //        itemErrorProvider.SetError(BidIncrementValueTextBox, "Bid Increment value required");
        //        isValid = false;
        //    }
        //    return isValid;
        //}

        //private bool ValidateBuyItNow(bool isValid)
        //{
        //    if (!string.IsNullOrEmpty(BuyItNowTextBox.Text))
        //    {
        //        if (MathHelper.ParseDecimalZeroIfNull(DigitsOnly(BuyItNowTextBox.Text)) < 0)
        //        {
        //            itemErrorProvider.SetError(BuyItNowTextBox, "Buy It Now value must be greater than or equal to zero");
        //            isValid = false;
        //        }
        //    }
        //    return isValid;
        //}

        //private decimal ValidateMaximumBid(decimal maxBid, ref bool isValid)
        //{
        //    if (!string.IsNullOrEmpty(MaximumBidTextBox.Text))
        //    {
        //        maxBid = MathHelper.ParseDecimalZeroIfNull(DigitsOnly(MaximumBidTextBox.Text));
        //        if (maxBid < 0)
        //        {
        //            itemErrorProvider.SetError(MaximumBidTextBox, "Maximum Bid must be greater than or equal to zero");
        //            isValid = false;
        //        }
        //    }
        //    return maxBid;
        //}

        //private decimal ValidateMinimumBid(decimal minBid, ref bool isValid)
        //{
        //    if (!string.IsNullOrEmpty(MinimumBidTextBox.Text))
        //    {
        //        minBid = MathHelper.ParseDecimalZeroIfNull(DigitsOnly(MinimumBidTextBox.Text));
        //        if (minBid < 0)
        //        {
        //            itemErrorProvider.SetError(MinimumBidTextBox, "Minimum Bid must be greater than or equal to zero");
        //            isValid = false;
        //        }
        //    }
        //    return minBid;
        //}

        //private bool ValidateRetailValue(bool isValid)
        //{
        //    if (!string.IsNullOrEmpty(RetailValueTextBox.Text))
        //    {
        //        if (MathHelper.ParseDecimalZeroIfNull(DigitsOnly(RetailValueTextBox.Text)) < 0)
        //        {
        //            itemErrorProvider.SetError(RetailValueTextBox, "Retail Value must be greater than or equal to zero");
        //            isValid = false;
        //        }
        //    }
        //    return isValid;
        //}

        //private bool ValidateQty(bool isValid)
        //{
        //    if (string.IsNullOrEmpty(QtyTextBox.Text))
        //    {
        //        itemErrorProvider.SetError(QtyTextBox, "Quantity required");
        //        isValid = false;
        //    }
        //    else if (MathHelper.ParseIntZeroIfNull(QtyTextBox.Text) <= 0)
        //    {
        //        itemErrorProvider.SetError(QtyTextBox, "Quantity must be greater than zero");
        //        isValid = false;
        //    }
        //    return isValid;
        //}

        //private bool ValidateItemName(bool isValid)
        //{
        //    if (string.IsNullOrEmpty(NameTextBox.Text))
        //    {
        //        itemErrorProvider.SetError(NameTextBox, "Item Name required");
        //        isValid = false;
        //    }
        //    return isValid;
        //}

        //private void ValidateDonor()
        //{
        //    if (DonorsComboBox.SelectedValue == null)
        //    {
        //        itemErrorProvider.SetError(DonorsComboBox, "Donor is required");
        //    }
        //}

        //private void ValidateAuction()
        //{
        //    if (AuctionsComboBox.SelectedValue == null)
        //    {
        //        itemErrorProvider.SetError(AuctionsComboBox, "Auction is required");
        //    }
        //}
        #endregion

    }
}
