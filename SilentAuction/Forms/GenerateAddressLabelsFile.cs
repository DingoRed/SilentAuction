using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using SilentAuction.Extensions;
using SilentAuction.SilentAuctionDataSetTableAdapters;
using SilentAuction.Utilities;

namespace SilentAuction.Forms
{
    public partial class GenerateAddressLabelsFile : Form
    {
        #region Properties
        private int AuctionId { get; set; }
        public List<int> DonorIdsToInclude { get; set; }
        #endregion

        #region Constructor
        public GenerateAddressLabelsFile(int auctionId)
        {
            AuctionId = auctionId;

            InitializeComponent();
        }
        #endregion

        #region Form Event Handlers
        private void GenerateLabelsFileLoad(object sender, EventArgs e)
        {
            donorsWithLettersTableAdapter.FillDonorsWithLetters(silentAuctionDataSet.DonorsWithLetters, AuctionId, null);

            WindowSettings.SetupInitialWindow(this, "GenerateAddressLabelsFileInitialLocation");
        }

        private void GenerateLabelsFileFormClosing(object sender, FormClosingEventArgs e)
        {
            WindowSettings.SaveWindowSettings(this, "GenerateAddressLabelsFileInitialLocation");
        }
        #endregion

        #region Event Handlers
        private void FilterByContactCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            long? requestFormatTypeId = null;

            if (FilterByContactCheckBox.Checked)
                requestFormatTypeId = 1;

            donorsWithLettersTableAdapter.FillDonorsWithLetters(silentAuctionDataSet.DonorsWithLetters, AuctionId, requestFormatTypeId);
        }

        private void MakeFileButtonClick(object sender, EventArgs e)
        {
            DonorIdsToInclude = new List<int>();
            foreach (DataRowView selectedItem in DonorsListBox.SelectedItems)
            {
                DonorIdsToInclude.Add(MathHelper.ParseIntZeroIfNull(selectedItem[0].ToString()));
            }

            SilentAuctionDataSet.DonorAddressesDataTable donorAddressesDataTable =
                new SilentAuctionDataSet.DonorAddressesDataTable();
            new DonorAddressesTableAdapter().FillDonorAddresses(donorAddressesDataTable, AuctionId);

            DataTable dt = new SilentAuctionDataSet.DonorAddressesDataTable();

            foreach (SilentAuctionDataSet.DonorAddressesRow row in donorAddressesDataTable.Rows)
            {
                if (DonorIdsToInclude.Contains((int)row.Id))
                {
                    dt.Rows.Add(row.ItemArray);
                }
            }

            string csvFile = dt.DataTableToCsvFormat();

            if (FileHelper.SaveCsvFile(csvFile, "Silent Auction Addresses"))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else DialogResult = DialogResult.None;
        }
        #endregion
    }
}
