using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        //public List<int> DonorIdsToInclude { get; set; }
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
            DoData(null);

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
            var letterRequestFormatType =
                new RequestFormatTypesTableAdapter().GetRequestFormatTypesData().FirstOrDefault(r => r.Name == "Letter");
            long? requestFormatTypeId = null;

            if (letterRequestFormatType != null)
            {
                if (FilterByContactCheckBox.Checked)
                    requestFormatTypeId = letterRequestFormatType.Id;                
            } 

            DoData(requestFormatTypeId);
        }

        private void MakeFileButtonClick(object sender, EventArgs e)
        {
            List<int> donorIdsToInclude = new List<int>();
            foreach (SilentAuctionDataSet.DonorsRow selectedItem in DonorsListBox.SelectedItems)
            {
                donorIdsToInclude.Add((int) selectedItem.Id);
            }

            SilentAuctionDataSet.DonorsDataTable dt = new SilentAuctionDataSet.DonorsDataTable();

            foreach (SilentAuctionDataSet.DonorsRow row in silentAuctionDataSet.Donors.Rows)
            {
                if (donorIdsToInclude.Contains((int)row.Id))
                {
                    dt.Rows.Add(row.ItemArray);
                }
            }

            dt.Columns.Remove(dt.AuctionIdColumn);
            dt.Columns.Remove(dt.CreateDateColumn);
            dt.Columns.Remove(dt.DonorTypeIdColumn);
            dt.Columns.Remove(dt.IdColumn);
            dt.Columns.Remove(dt.ModifiedDateColumn);
            dt.Columns.Remove(dt.RequestFormatTypeIdColumn);
            dt.Columns.Remove(dt.RequestStatusTypeIdColumn);
            
            string csvFile = dt.DataTableToCsvFormat();

            if (FileHelper.SaveCsvFile(csvFile, "Silent Auction Addresses"))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else DialogResult = DialogResult.None;
        }
        #endregion

        #region Private Methods
        private void DoData(long? requestFormatTypeId)
        {
            donorsTableAdapter.FillByAuctionId(silentAuctionDataSet.Donors, AuctionId);
            List<SilentAuctionDataSet.DonorsRow> donorsFiltered = silentAuctionDataSet.Donors.ToList();

            if (requestFormatTypeId != null)
                donorsFiltered = silentAuctionDataSet.Donors.Where(d => d.RequestFormatTypeId == requestFormatTypeId).ToList();

            DonorsListBox.DataSource = donorsFiltered;
        }
        #endregion
    }
}
