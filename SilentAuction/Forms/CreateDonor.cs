using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SilentAuction.Utilities;

namespace SilentAuction.Forms
{
    public partial class CreateNewDonorForm : Form
    {
        #region Properties
        public int DonorId { get; set; }
        public string DonorName { get; set; }
        public int AuctionId { get; set; }
        #endregion

        #region Form Event Handlers
        public CreateNewDonorForm()
        {
            InitializeComponent();
        }

        private void CreateNewDonorFormLoad(object sender, EventArgs e)
        {
            auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);
            requestFormatTypesTableAdapter.FillRequestFormatTypes(silentAuctionDataSet.RequestFormatTypes);
            donorTypesTableAdapter.FillDonorTypes(silentAuctionDataSet.DonorTypes);
            donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors, AuctionId);
            
        }
        #endregion

        #region Event Handlers
        private void SaveButtonClick(object sender, EventArgs e)
        {
            if (!ValidForm()) return;
            
            SaveDonorData();
            DialogResult = DialogResult.None;

            ClearForm();
        }

        private void SaveAndCloseButtonClick(object sender, EventArgs e)
        {
            if (!ValidForm()) return;

            SaveDonorData();
            DialogResult = DialogResult.OK;
        }

        private void NameTextBoxTextChanged(object sender, EventArgs e)
        {
            ErrorLabel.Visible = DonorNameExists();
        }
        #endregion
        
        #region Private Methods
        private bool ValidForm()
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
                return false;

            if (DonorNameExists())
            {
                ErrorLabel.Visible = true;
                return false;
            }

            ErrorLabel.Visible = false;

            return true;
        }

        private void SaveDonorData()
        {
            DateTime currentDate = DateTime.Now;
            int donorTypeId = MathHelper.ParseIntZeroIfNull(DonorTypeComboBox.SelectedValue.ToString());
            int requestFormatTypeId = MathHelper.ParseIntZeroIfNull(RequestFormatTypeComboBox.SelectedValue.ToString());
            string state = StateComboBox.SelectedValue == null ? "" : StateComboBox.SelectedValue.ToString();

            SilentAuctionDataSet.DonorTypesRow donorTypesRow =
                silentAuctionDataSet.DonorTypes.FirstOrDefault(d => d.Id == donorTypeId);
            SilentAuctionDataSet.RequestFormatTypesRow requestFormatTypesRow =
                silentAuctionDataSet.RequestFormatTypes.FirstOrDefault(r => r.Id == requestFormatTypeId);
            SilentAuctionDataSet.AuctionsRow auctionsRow =
                silentAuctionDataSet.Auctions.FirstOrDefault(a => a.Id == AuctionId);
            SilentAuctionDataSet.RequestStatusTypesRow requestStatusTypesRow =
                silentAuctionDataSet.RequestStatusTypes.FirstOrDefault(r => r.Id == 1);

            silentAuctionDataSet.Donors.AddDonorsRow(donorTypesRow, NameTextBox.Text,
                ContactNameTextBox.Text, Street1TextBox.Text, Street2TextBox.Text,
                CityTextBox.Text, state, ZipCodeTextBox.Text, Phone1TextBox.Text,
                Ext1TextBox.Text, Phone2TextBox.Text, Ext2TextBox.Text, EmailTextBox.Text,
                currentDate.ToString(), currentDate.ToString(), requestFormatTypesRow, UrlTextBox.Text,
                auctionsRow, requestStatusTypesRow);

            SilentAuctionDataSet.DonorsDataTable newDonors =
                (SilentAuctionDataSet.DonorsDataTable) silentAuctionDataSet.Donors.GetChanges(DataRowState.Added);

            if (newDonors != null)
            {
                donorsTableAdapter.Update(newDonors);
                silentAuctionDataSet.AcceptChanges();
                newDonors.Dispose();
                donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors, AuctionId);
            }

            DonorId = (int) silentAuctionDataSet.Donors.Max(a => a.Id);
        }

        private bool DonorNameExists()
        {
            return silentAuctionDataSet.Donors.Any(d => String.Equals(d.Name, NameTextBox.Text, StringComparison.CurrentCultureIgnoreCase));
        }
        
        private void ClearForm()
        {
            NameTextBox.Text = string.Empty;
            ContactNameTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            Phone1TextBox.Text = string.Empty;
            Ext1TextBox.Text = string.Empty;
            Phone2TextBox.Text = string.Empty;
            Ext2TextBox.Text = string.Empty;
            UrlTextBox.Text = string.Empty;
            Street1TextBox.Text = string.Empty;
            Street2TextBox.Text = string.Empty;
            CityTextBox.Text = string.Empty;
            ZipCodeTextBox.Text = string.Empty;

            DonorTypeComboBox.SelectedIndex = 0;
            RequestFormatTypeComboBox.SelectedIndex = 0;
            StateComboBox.SelectedValue = "";
        }
        #endregion
    }
}
