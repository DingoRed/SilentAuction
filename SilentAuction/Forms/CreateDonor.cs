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
        private int AuctionId { get; set; }
        #endregion

        #region Constructor
        public CreateNewDonorForm(int auctionId)
        {
            AuctionId = auctionId;
            InitializeComponent();
        }
        #endregion

        #region Form Event Handlers
        private void CreateNewDonorFormLoad(object sender, EventArgs e)
        {
            auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);
            requestFormatTypesTableAdapter.FillRequestFormatTypes(silentAuctionDataSet.RequestFormatTypes);
            requestStatusTypesTableAdapter.FillRequestStatusType(silentAuctionDataSet.RequestStatusTypes);
            donorTypesTableAdapter.FillDonorTypes(silentAuctionDataSet.DonorTypes);

            if (AuctionId > 0)
            {
                donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors, AuctionId);
                AuctionsComboBox.Enabled = false;
            }

            AuctionsComboBox.SelectedValue = AuctionId;

            WindowSettings.SetupInitialWindow(this, "CreateDonorInitialLocation");
        }

        private void CreateNewDonorFormFormClosing(object sender, FormClosingEventArgs e)
        {
            WindowSettings.SaveWindowSettings(this, "CreateDonorInitialLocation");
        }        
        #endregion

        #region Event Handlers
        private void SaveButtonClick(object sender, EventArgs e)
        {
            Text = "Create New Donor";
            if (!IsValidForm())
                return;
            
            SaveDonorData();
            DialogResult = DialogResult.None;
            ClearForm();
            CreateDonorErrorProvider.SetError(NameTextBox, "");
            Text = "Create New Donor - Saved Successful";
        }

        private void SaveAndCloseButtonClick(object sender, EventArgs e)
        {
            if (!IsValidForm())
                return;

            SaveDonorData();
            DialogResult = DialogResult.OK;
            Close();
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

        private void NameTextBoxTextChanged(object sender, EventArgs e)
        {
            CreateDonorErrorProvider.SetError(NameTextBox, "");
            if (string.IsNullOrEmpty(NameTextBox.Text))
                CreateDonorErrorProvider.SetError(NameTextBox, "Donor name required");
            else if (DonorNameExists(AuctionId))
                CreateDonorErrorProvider.SetError(NameTextBox, "Donor name already exists for selected Auction");
        }
        #endregion
        
        #region Private Methods
        private bool IsValidForm()
        {
            bool isValid = true;
            var auctionsComboBoxSelectedValue = AuctionsComboBox.SelectedValue;
            var donorTypesSelectedValue = DonorTypeComboBox.SelectedValue;
            int auctionId = 0;
            int donorTypeId = 0;

            CreateDonorErrorProvider.SetError(AuctionsComboBox, "");
            CreateDonorErrorProvider.SetError(NameTextBox, "");
            CreateDonorErrorProvider.SetError(DonorTypeComboBox, "");
            CreateDonorErrorProvider.SetError(EmailTextBox, "");

            if(auctionsComboBoxSelectedValue != null)
                auctionId = MathHelper.ParseIntZeroIfNull(auctionsComboBoxSelectedValue.ToString());
            if (donorTypesSelectedValue != null)
                donorTypeId = MathHelper.ParseIntZeroIfNull(donorTypesSelectedValue.ToString());

            // Test for Auction...
            if (auctionId <= 0)
            {
                CreateDonorErrorProvider.SetError(AuctionsComboBox, "Auction selection required");
                isValid = false;
            }

            // Test for Donor Name...
            if (string.IsNullOrEmpty(NameTextBox.Text))
            {
                CreateDonorErrorProvider.SetError(NameTextBox, "Donor name required");
                isValid = false;
            }
            else if (DonorNameExists(auctionId))
            {
                NameTextBox.Select(0, NameTextBox.Text.Length);
                CreateDonorErrorProvider.SetError(NameTextBox, "Donor name already exists for selected Auction");
                isValid = false;
            }

            // Test for Donor Type...
            if (donorTypeId <= 0)
            {
                CreateDonorErrorProvider.SetError(DonorTypeComboBox, "Donor Type required");
            }

            // Test for Email Address...
            if (!string.IsNullOrEmpty(EmailTextBox.Text))
            {
                if (!EmailHelper.IsValidEmailAddress(EmailTextBox.Text))
                {
                    CreateDonorErrorProvider.SetError(EmailTextBox, "Invalid email address");
                    isValid = false;
                }
            }

            return isValid;
        }

        private bool DonorNameExists(int auctionId)
        {
            return silentAuctionDataSet.Donors.Any(d => d.Name.ToLower() == NameTextBox.Text.ToLower() 
                                                        && d.AuctionId == auctionId);
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
