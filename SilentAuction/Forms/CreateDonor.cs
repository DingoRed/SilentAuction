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

            AuctionsComboBox.SelectedValue = AuctionId;

        }
        #endregion

        #region Event Handlers
        private void SaveButtonClick(object sender, EventArgs e)
        {
            Text = "Create New Donor";
            if (!MasterIsValid())
                return;
            
            SaveDonorData();
            DialogResult = DialogResult.None;

            ClearForm();

            Text = "Create New Donor - Saved Successful";
        }

        private void SaveAndCloseButtonClick(object sender, EventArgs e)
        {
            if (!MasterIsValid())
                return;

            SaveDonorData();
            DialogResult = DialogResult.OK;
        }

        private void AuctionsComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            var val = AuctionsComboBox.SelectedValue;
            if (val != null)
            {
                AuctionId = MathHelper.ParseIntZeroIfNull(val.ToString());
                donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors, AuctionId);
            }
        }
        #endregion
        
        #region Private Methods
        private bool MasterIsValid()
        {
            bool isValid = true;
            if (!IsAuctionValid())
            {
                AuctionsComboBox.Focus();
                AuctionErrorProvider.SetError(AuctionsComboBox, "Auction selection required");
                isValid = false;
            }

            if (!IsDonorNameNotEmpty())
            {
                NameTextBox.Focus();
                NameErrorProvider.SetError(NameTextBox, "Donor name required");
                isValid = false;
            }
            else if (!IsDonorNameUnique())
            {
                NameTextBox.Select(0, NameTextBox.Text.Length);
                NameErrorProvider.SetError(NameTextBox, "Donor name already exists for selected Auction");
                isValid = false;
            }

            return isValid;
        }

        private bool IsAuctionValid()
        {
            var val = AuctionsComboBox.SelectedValue;
            return val != null && MathHelper.ParseIntZeroIfNull(val.ToString()) > 0;
        }

        private bool IsDonorNameNotEmpty()
        {
            return !string.IsNullOrWhiteSpace(NameTextBox.Text);
        }

        private bool IsDonorNameUnique()
        {
            var val = AuctionsComboBox.SelectedValue;
            if (val == null)
                return false;

            return !silentAuctionDataSet.Donors.Any(d => d.Name.ToLower() == NameTextBox.Text.ToLower() &&
                                                         d.AuctionId == MathHelper.ParseIntZeroIfNull(val.ToString()));
        }

        private void SaveDonorData()
        {
            DateTime currentDate = DateTime.Now;
            int donorTypeId = MathHelper.ParseIntZeroIfNull(DonorTypeComboBox.SelectedValue.ToString());
            int requestFormatTypeId = MathHelper.ParseIntZeroIfNull(RequestFormatTypeComboBox.SelectedValue.ToString());
            string state = StateComboBox.SelectedItem == null ? "" : StateComboBox.SelectedItem.ToString();

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

        #region Individual Controls Validation Event Handlers
        private void AuctionsComboBoxValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var val = AuctionsComboBox.SelectedValue;
            if (val == null || MathHelper.ParseIntZeroIfNull(val.ToString()) <= 0)
            {
                e.Cancel = true;
                AuctionsComboBox.Focus();
                AuctionErrorProvider.SetError(AuctionsComboBox, "Auction selection required");
            }
        }

        private void AuctionsComboBoxValidated(object sender, EventArgs e)
        {
            AuctionErrorProvider.SetError(AuctionsComboBox, "");
        }

        private void NameTextBoxValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                e.Cancel = true;
                NameTextBox.Focus();
                NameErrorProvider.SetError(NameTextBox, "Donor name required");
            }
            else if (silentAuctionDataSet.Donors.Any(d => d.Name.ToLower() == NameTextBox.Text.ToLower() &&
                        d.AuctionId == MathHelper.ParseIntZeroIfNull(AuctionsComboBox.SelectedValue.ToString())))
            {
                e.Cancel = true;
                NameTextBox.Select(0, NameTextBox.Text.Length);
                NameErrorProvider.SetError(NameTextBox, "Donor name already exists for selected Auction");
            }
        }

        private void NameTextBoxValidated(object sender, EventArgs e)
        {
            NameErrorProvider.SetError(NameTextBox, "");
        }

        private void DonorTypeComboBoxValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MathHelper.ParseIntZeroIfNull(DonorTypeComboBox.SelectedValue.ToString()) <= 0)
            {
                e.Cancel = true;
                DonorTypeComboBox.Focus();
                DonorTypeErrorProvider.SetError(DonorTypeComboBox, "Donor type required");
            }
        }

        private void DonorTypeComboBoxValidated(object sender, EventArgs e)
        {
            DonorTypeErrorProvider.SetError(DonorTypeComboBox, "");
        }
        #endregion
    }
}
