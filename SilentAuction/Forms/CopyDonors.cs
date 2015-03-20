using System;
using System.Data;
using System.Windows.Forms;
using SilentAuction.Utilities;

namespace SilentAuction.Forms
{
    public partial class CopyDonorsForm : Form
    {
        #region Form Event Handlers
        public CopyDonorsForm()
        {
            InitializeComponent();
        }

        private void CopyDonorsLoad(object sender, EventArgs e)
        {
            requestStatusTypesTableAdapter.FillRequestStatusType(silentAuctionDataSet.RequestStatusTypes);
            requestFormatTypesTableAdapter.FillRequestFormatTypes(silentAuctionDataSet.RequestFormatTypes);
            donorTypesTableAdapter.FillDonorTypes(silentAuctionDataSet.DonorTypes);
            auctionFromTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);

            int id = MathHelper.ParseIntZeroIfNull(AuctionFromComboBox.SelectedValue.ToString());
            donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors, id);

            ValidateForm();
        }
        #endregion

        #region Event Handlers
        private void AuctionFromComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            FillDonorsListBox();
        }
        
        private void AuctionToComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            FillDonorsListBox();
        }

        private void SaveDonorsButtonClick(object sender, EventArgs e)
        {
            if (ValidateForm())
                SaveData();
        }

        private void SaveDonorsAndCloseButtonClick(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveData();
                Close();
            }
        }
        #endregion

        #region Private Methods
        private bool ValidateForm()
        {
            if (AuctionFromComboBox.SelectedValue.ToString() == AuctionToComboBox.SelectedValue.ToString())
            {
                ErrorLabel.Visible = true;
                SaveDonorsButton.Enabled = false;
                SaveDonorsAndCloseButton.Enabled = false;
                return false;
            }

            ErrorLabel.Visible = false;
            SaveDonorsButton.Enabled = true;
            SaveDonorsAndCloseButton.Enabled = true;
            return true;
        }

        private void SaveData()
        {
            if (AuctionFromComboBox.SelectedValue != null && AuctionToComboBox.SelectedValue != null)
            {
                if (!ValidateForm())
                    return;

                int auctionFromId = MathHelper.ParseIntZeroIfNull(AuctionFromComboBox.SelectedValue.ToString());
                int auctionToId = MathHelper.ParseIntZeroIfNull(AuctionToComboBox.SelectedValue.ToString());
                SilentAuctionDataSet.DonorsDataTable fromTable = new SilentAuctionDataSet.DonorsDataTable();
                SilentAuctionDataSet.DonorsDataTable toTable = new SilentAuctionDataSet.DonorsDataTable();

                donorsTableAdapter.FillDonors(fromTable, auctionFromId);
                donorsTableAdapter.FillDonors(toTable, auctionToId);

                foreach (DataRowView selectedItem in DonorsListBox.SelectedItems)
                {
                    foreach (DataRow row in fromTable.Rows)
                    {
                        if (selectedItem["Id"].ToString() == row["id"].ToString())
                        {
                            //row["Id"] = -1;
                            row["AuctionId"] = auctionToId;
                            row["RequestStatusTypeId"] = 1;
                            row["CreateDate"] = DateTime.Now;
                            row["ModifiedDate"] = DateTime.Now;
                            toTable.Rows.Add(row.ItemArray);
                            break;
                        }
                    }
                }

                SilentAuctionDataSet.DonorsDataTable newItems =
                    (SilentAuctionDataSet.DonorsDataTable) toTable.GetChanges(DataRowState.Added);

                if (newItems != null)
                {
                    donorsTableAdapter.Update(newItems);
                    silentAuctionDataSet.AcceptChanges();
                    newItems.Dispose();
                    FillDonorsListBox();
                }
            }
        }

        private void FillDonorsListBox()
        {
            if (AuctionFromComboBox.SelectedValue != null && AuctionToComboBox.SelectedValue != null)
            {
                if (!ValidateForm())
                    return;

                int auctionFromId = MathHelper.ParseIntZeroIfNull(AuctionFromComboBox.SelectedValue.ToString());
                int auctionToId = MathHelper.ParseIntZeroIfNull(AuctionToComboBox.SelectedValue.ToString());

                SilentAuctionDataSet.DonorsDataTable tempTable = new SilentAuctionDataSet.DonorsDataTable();
                donorsTableAdapter.FillDonors(tempTable, auctionToId);
                donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors, auctionFromId);

                foreach (DataRow donorsRow in silentAuctionDataSet.Donors.Rows)
                {
                    foreach (DataRow tempRow in tempTable.Rows)
                    {
                        if (String.Equals(tempRow["Name"].ToString(), donorsRow["Name"].ToString(),
                            StringComparison.CurrentCultureIgnoreCase))
                        {
                            donorsRow.Delete();
                            break;
                        }
                    }
                }
            }
        }
        #endregion


    }
}
