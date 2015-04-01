using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SilentAuction.Properties;
using SilentAuction.Utilities;

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
            requestStatusTypesTableAdapter.FillRequestStatusType(silentAuctionDataSet.RequestStatusTypes);
            requestFormatTypesTableAdapter.FillRequestFormatTypes(silentAuctionDataSet.RequestFormatTypes);
            donorTypesTableAdapter.FillDonorTypes(silentAuctionDataSet.DonorTypes);
            
            auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);
            
            WindowSettings.SetupInitialWindow(this, "CreateAuctionInitialLocation");
        }

        private void CreateNewAuctionFormFormClosing(object sender, FormClosingEventArgs e)
        {
            WindowSettings.SaveWindowSettings(this, "CreateAuctionInitialLocation");
        }
        #endregion

        #region Event Handlers
        private void SaveButtonClick(object sender, EventArgs e)
        {
            Text = "Create New Auction";

            if (!ValidForm()) return;
            
            SaveAuctionData();

            if (CopyDonorsCheckBox.Checked)
                CopyDonors();

            DialogResult = DialogResult.None;

            ClearForm();

            Text = "Create New Auction - New Auction Created";
        }

        private void SaveAuctionAndCloseButtonClick(object sender, EventArgs e)
        {
            Text = "Create New Auction";

            if (!ValidForm()) return;

            SaveAuctionData();

            if (CopyDonorsCheckBox.Checked)
                CopyDonors();

            DialogResult = DialogResult.OK;
        }

        private void NameTextBoxTextChanged(object sender, EventArgs e)
        {
            if (AuctionNameExists())
            {
                AuctionNameErrorProvider.SetError(NameTextBox, "Auction already exists");
            }
        }

        private void CopyDonorsCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            if (CopyDonorsCheckBox.Checked)
            {
                CopyFromAuctionLabel.Enabled = true;
                CopyFromAuctionComboBox.Enabled = true;
            }
            else
            {
                CopyFromAuctionLabel.Enabled = false;
                CopyFromAuctionComboBox.Enabled = false;
            }
        }
        #endregion

        #region Private Methods
        private bool ValidForm()
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                AuctionNameErrorProvider.SetError(NameTextBox, "Auction name required");
                return false;
            }

            if (AuctionNameExists())
            {
                AuctionNameErrorProvider.SetError(NameTextBox, "Auction already exists");
                return false;
            }

            AuctionNameErrorProvider.SetError(NameTextBox, "");

            return true;
        }

        private void SaveAuctionData()
        {
            DateTime currentDate = DateTime.Now;
            silentAuctionDataSet.Auctions.AddAuctionsRow(NameTextBox.Text, DescriptionTextBox.Text,
                currentDate.ToString(), currentDate.ToString(), "", "");

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

        private void CopyDonors()
        {
            int copyFromAuctionId = MathHelper.ParseIntZeroIfNull(CopyFromAuctionComboBox.SelectedValue.ToString());

            donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors, copyFromAuctionId);
            SilentAuctionDataSet.DonorsDataTable toTable = new SilentAuctionDataSet.DonorsDataTable();

            foreach (DataRow row in silentAuctionDataSet.Donors.Rows)
            {
                    row["AuctionId"] = AuctionId;
                    row["RequestStatusTypeId"] = 1;
                    row["CreateDate"] = DateTime.Now;
                    row["ModifiedDate"] = DateTime.Now;
                    toTable.Rows.Add(row.ItemArray);
            }

            SilentAuctionDataSet.DonorsDataTable newItems =
                    (SilentAuctionDataSet.DonorsDataTable)toTable.GetChanges(DataRowState.Added);

            if (newItems != null)
            {
                donorsTableAdapter.Update(newItems);
                silentAuctionDataSet.AcceptChanges();
                newItems.Dispose();
            }
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
