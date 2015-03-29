using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SilentAuction.Utilities;

namespace SilentAuction.Forms
{
    public partial class EditAuctionForm : Form
    {
        private int AuctionId { get; set; }

        public EditAuctionForm()
        {
            InitializeComponent();
        }

        private void EditAuctionFormLoad(object sender, EventArgs e)
        {
            auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);
            FillTextBoxes();
            AuctionId = MathHelper.ParseIntZeroIfNull(AuctionComboBox.SelectedValue.ToString());
        }

        #region Event Handlers
        private void AuctionComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            FillTextBoxes();
        }

        private void SaveAuctionButtonClick(object sender, EventArgs e)
        {
            Text = "Edit an Auction";
            if (!ValidForm()) return;

            SaveAuctionData();
            DialogResult = DialogResult.None;

            FillTextBoxes();
            AuctionComboBox.SelectedValue = AuctionId;
            Text = "Edit an Auction - Data Updated";
        }

        private void SaveAuctionAndCloseButtonClick(object sender, EventArgs e)
        {
            if (!ValidForm()) return;

            SaveAuctionData();
            DialogResult = DialogResult.OK;
        }

        private void NameTextBoxTextChanged(object sender, EventArgs e)
        {
            if (NameTextBox.Text == AuctionComboBox.Text)
                AuctionNameErrorProvider.SetError(NameTextBox, "");
                //ErrorLabel.Visible = false;
            else if (AuctionNameExists())
                AuctionNameErrorProvider.SetError(NameTextBox, "Name already exists");
                //ErrorLabel.Visible = AuctionNameExists();
        }
        #endregion

        #region Private Methods
        private bool ValidForm()
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
                return false;

            if (AuctionNameExists())
            {
                //ErrorLabel.Visible = true;
                AuctionNameErrorProvider.SetError(NameTextBox,"Name already exists");
                return false;
            }

            //ErrorLabel.Visible = false;
            AuctionNameErrorProvider.SetError(NameTextBox, "");

            return true;
        }

        private void SaveAuctionData()
        {
            AuctionId = MathHelper.ParseIntZeroIfNull(AuctionComboBox.SelectedValue.ToString());
            DateTime currentDate = DateTime.Now;
            string description = DescriptionTextBox.Text;
            string name = NameTextBox.Text;

            SilentAuctionDataSet.AuctionsRow row = silentAuctionDataSet.Auctions.FirstOrDefault(a => a.Id == AuctionId);
            if (row != null)
            {
                row.Name = name;
                row.Description = description;
                row.ModifiedDate = currentDate.ToString();
            }

            SilentAuctionDataSet.AuctionsDataTable modifiedItems =
                (SilentAuctionDataSet.AuctionsDataTable)silentAuctionDataSet.Auctions.GetChanges(DataRowState.Modified);

            if (modifiedItems != null)
            {
                auctionsTableAdapter.Update(modifiedItems);
                silentAuctionDataSet.AcceptChanges();
                modifiedItems.Dispose();
                auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);
            }
        }

        private bool AuctionNameExists()
        {
            AuctionId = MathHelper.ParseIntZeroIfNull(AuctionComboBox.SelectedValue.ToString());
            return silentAuctionDataSet.Auctions.Any(a => a.Name.ToLower() == NameTextBox.Text.ToLower() && a.Id != AuctionId);
        }

        private void FillTextBoxes()
        {
            if (AuctionComboBox.SelectedValue != null)
            {
                AuctionId = MathHelper.ParseIntZeroIfNull(AuctionComboBox.SelectedValue.ToString());
                var row = silentAuctionDataSet.Auctions.FirstOrDefault(a => a.Id == AuctionId);
                if (row != null)
                {
                    NameTextBox.Text = row.Name;
                    DescriptionTextBox.Text = row.Description;
                }
            }
        }
        #endregion
    }
}
