using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SilentAuction.Utilities;

namespace SilentAuction.Forms
{
    public partial class BidCalculatorForm : Form
    {
        // Implementing Singleton, so only one copy of the form can be opened
        private static BidCalculatorForm _instance;
        public static BidCalculatorForm GetForm
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) 
                    _instance = new BidCalculatorForm();
                return _instance;
            }
        }


        #region Constructor
        public BidCalculatorForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Event Handlers
        private void BidCalculatorFormLoad(object sender, EventArgs e)
        {
            WindowSettings.SetupInitialWindow(this, "BidCalculatorFormInitialLocation");
        }

        private void BidCalculatorFormFormClosing(object sender, FormClosingEventArgs e)
        {
            WindowSettings.SaveWindowSettings(this, "BidCalculatorFormInitialLocation");
        }
        #endregion

        #region Event Handlers
        private void BCalcButtonClick(object sender, EventArgs e)
        {
            Calc(BidIncrementType.IncrementNumber);
        }
        
        private void VCalcButtonClick(object sender, EventArgs e)
        {
            Calc(BidIncrementType.IncrementValue);
        }

        private void TextBoxEnter(object sender, EventArgs e)
        {
            SelectTextInTextBox((TextBox)sender);
        }
        #endregion

        #region Private Methods
        private void Calc(BidIncrementType bidIncrementType)
        {
            decimal minValue;
            decimal maxValue;
            int numberOfBids = 0;
            decimal incrementValue = 0;

            if (bidIncrementType == BidIncrementType.IncrementNumber)
            {
                minValue = MathHelper.ParseDecimalZeroIfNull(BMinValueTextBox.Text);
                maxValue = MathHelper.ParseDecimalZeroIfNull(BMaxValueTextBox.Text);
                numberOfBids = MathHelper.ParseIntZeroIfNull(BNbrOfBidsTextBox.Text);
            }
            else
            {
                minValue = MathHelper.ParseDecimalZeroIfNull(VMinValueTextBox.Text);
                maxValue = MathHelper.ParseDecimalZeroIfNull(VMaxValueTextBox.Text);
                incrementValue = MathHelper.ParseDecimalZeroIfNull(VIncrValueTextBox.Text);
            }

            if (!IsValid(bidIncrementType, minValue, maxValue, incrementValue, numberOfBids))
                return;

            BidCalculator bidCalculator = new BidCalculator();
            List<decimal> bidList = bidCalculator.GetBidList(bidIncrementType,
                minValue, maxValue, incrementValue, numberOfBids);

            BidsListView.Clear();
            int i = 1;
            foreach (decimal bid in bidList)
            {
                ListViewItem item = new ListViewItem(new[] { string.Format("Line {0}: {1:C}", i, bid) });
                BidsListView.Items.Add(item);
                i++;
            }
        }

        private bool IsValid(BidIncrementType bidIncrementType, decimal minValue, decimal maxValue, decimal incrementValue, int numberOfBids)
        {
            bool isValid = true;
            bidCalculatorErrorProvider.Clear();

            TextBox minValueTextBox = bidIncrementType == BidIncrementType.IncrementNumber
                ? BMinValueTextBox
                : VMinValueTextBox;

            TextBox maxValueTextBox = bidIncrementType == BidIncrementType.IncrementNumber
                ? BMaxValueTextBox
                : VMaxValueTextBox;
            
            // Validate Min Value...
            if (string.IsNullOrEmpty(minValueTextBox.Text))
            {
                bidCalculatorErrorProvider.SetError(minValueTextBox, "Min Value Required");
                isValid = false;
            }
            else if (minValue <= 0)
            {
                bidCalculatorErrorProvider.SetError(minValueTextBox, "Min Value must be greater than 0");
                isValid = false;
            }
            else if (minValue >= maxValue)
            {
                bidCalculatorErrorProvider.SetError(minValueTextBox, "Min Value must be greater than Max Value");
                isValid = false;
            }
            
            // Validate Max Value...
            if (string.IsNullOrEmpty(maxValueTextBox.Text))
            {
                bidCalculatorErrorProvider.SetError(maxValueTextBox, "Max Value Required");
                isValid = false;
            }
            else if (minValue <= 0)
            {
                bidCalculatorErrorProvider.SetError(maxValueTextBox, "Max Value must be greater than 0");
                isValid = false;
            }
            else if (minValue >= maxValue)
            {
                bidCalculatorErrorProvider.SetError(maxValueTextBox, "Max Value must be less than Min Value");
                isValid = false;
            }
            
            if (bidIncrementType == BidIncrementType.IncrementNumber)
            {
                // Validate Number of Bids...
                if (string.IsNullOrEmpty(BNbrOfBidsTextBox.Text))
                {
                    bidCalculatorErrorProvider.SetError(BNbrOfBidsTextBox, "Number of Bids Value Required");
                    isValid = false;
                }
                else if (numberOfBids <= 0)
                {
                    bidCalculatorErrorProvider.SetError(BNbrOfBidsTextBox, "Number of Bids Value must be greater than 0");
                    isValid = false;
                }
            }
            else
            {
                // Validate Increment Value...
                if (string.IsNullOrEmpty(VIncrValueTextBox.Text))
                {
                    bidCalculatorErrorProvider.SetError(VIncrValueTextBox, "Increment Value Required");
                    isValid = false;
                }
                else if (incrementValue <= 0)
                {
                    bidCalculatorErrorProvider.SetError(VIncrValueTextBox, "Increment Value must be greater than 0");
                    isValid = false;
                }
            }

            return isValid;
        }

        private void SelectTextInTextBox(TextBox textBox)
        {
            if (textBox != null)
                BeginInvoke((Action)textBox.SelectAll);
        }
        #endregion
    }
}
