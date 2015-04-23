using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using SilentAuction.Utilities;

namespace SilentAuction.Forms
{
    public partial class DocumentPrintForm : Form
    {
        #region Properties
        private int AuctionId { get; set; }
        public List<int> DonorIdsToPrint { get; set; } 
        #endregion

        #region Constructor
        public DocumentPrintForm(int auctionId)
        {
            AuctionId = auctionId;

            InitializeComponent();
        }
        #endregion

        #region Form Event Handlers
        private void PrintFormLoad(object sender, EventArgs e)
        {
            auctionsTableAdapter.FillAuctions(silentAuctionDataSet.Auctions);
            requestStatusTypesTableAdapter.FillRequestStatusType(silentAuctionDataSet.RequestStatusTypes);
            requestFormatTypesTableAdapter.FillRequestFormatTypes(silentAuctionDataSet.RequestFormatTypes);
            donorTypesTableAdapter.FillDonorTypes(silentAuctionDataSet.DonorTypes);

            donorsTableAdapter.FillByAuctionId(silentAuctionDataSet.Donors, AuctionId);

            WindowSettings.SetupInitialWindow(this, "PrintFormInitialLocation");
        }

        private void PrintFormClosing(object sender, FormClosingEventArgs e)
        {
            WindowSettings.SaveWindowSettings(this, "PrintFormInitialLocation");
        }        
        #endregion

        #region Button Event Handlers
        private void PrintButtonClick(object sender, EventArgs e)
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
