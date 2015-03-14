using System;
using MetroFramework.Forms;
using SilentAuction.Core.Concrete;
using SilentAuction.Core.Entities;

namespace SilentAuction.Forms
{
    public partial class AuctionAddForm : MetroForm
    {
        public AuctionAddForm()
        {
            InitializeComponent();
            SubmitButton.Enabled = false;
        }

        #region Event Handlers
        private void SubmitButtonClick(object sender, EventArgs e)
        {
            AdoAuctionRepository auctionEventRepository = new AdoAuctionRepository();

            if (NameTextBox.Text.Length > 0)
            {
                if (auctionEventRepository.AuctionNameExists(NameTextBox.Text)) return;

                Auction auctionEvent = new Auction();
                auctionEvent.Name = NameTextBox.Text;
                auctionEvent.Description = DescriptionTextBox.Text;

                if (auctionEventRepository.Add(auctionEvent))
                    Close();
            }
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void NameTextBoxTextChanged(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;
            bool nameExists = false;

            if (NameTextBox.Text.Length > 0)
            {
                try
                {
                    AdoAuctionRepository auctionRepository = new AdoAuctionRepository();
                    nameExists = auctionRepository.AuctionNameExists(NameTextBox.Text);
                    ErrorLabel.Visible = nameExists;
                }
                catch (Exception)
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "Error with database";
                }
            }

            SubmitButton.Enabled = (NameTextBox.Text.Length > 0) && !nameExists;
        }

        #endregion



    }
}
