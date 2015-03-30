﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SilentAuction.Utilities;

namespace SilentAuction.Forms
{
    public partial class DonorSelections : Form
    {
        #region Properties
        private int AuctionId { get; set; }
        public List<int> DonorIdsToPrint { get; set; } 
        #endregion

        #region Constructor
        public DonorSelections(int auctionId)
        {
            AuctionId = auctionId;

            InitializeComponent();
        }
        #endregion

        #region Form Event Handlers
        private void DonorSelectionsLoad(object sender, EventArgs e)
        {
            auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);
            requestStatusTypesTableAdapter.FillRequestStatusType(silentAuctionDataSet.RequestStatusTypes);
            requestFormatTypesTableAdapter.FillRequestFormatTypes(silentAuctionDataSet.RequestFormatTypes);
            donorTypesTableAdapter.FillDonorTypes(silentAuctionDataSet.DonorTypes);

            donorsTableAdapter.FillDonors(silentAuctionDataSet.Donors, AuctionId);
        }
        #endregion

        #region Button Event Handlers
        private void PrintDonorsButtonClick(object sender, EventArgs e)
        {
            DonorIdsToPrint = new List<int>();
            foreach (DataRowView selectedItem in DonorsListBox.SelectedItems)
            {
                DonorIdsToPrint.Add(MathHelper.ParseIntZeroIfNull(selectedItem[0].ToString()));
            }

            DialogResult = DialogResult.OK;
            Close();
        }
        #endregion
    }
}