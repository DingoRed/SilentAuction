using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using SilentAuction.Utilities;

namespace SilentAuction.Forms
{
    public partial class DonorEmailSelections : Form
    {
        #region Properties
        private int AuctionId { get; set; }
        public List<int> DonorIdsToEmail { get; set; } 
        #endregion

        #region Constructor
        public DonorEmailSelections(int auctionId)
        {
            AuctionId = auctionId;

            InitializeComponent();
        }
        #endregion

        #region Form Event Handlers
        private void DonorSelectionsLoad(object sender, EventArgs e)
        {
            donorsWithEmailsTableAdapter.FillDonorsWithEmails(silentAuctionDataSet.DonorsWithEmails, AuctionId);

            WindowSettings.SetupInitialWindow(this, "DonorEmailSelectionsInitialLocation");
        }

        private void DonorSelectionsFormClosing(object sender, FormClosingEventArgs e)
        {
            WindowSettings.SaveWindowSettings(this, "DonorEmailSelectionsInitialLocation");
        }        
        #endregion

        #region Button Event Handlers
        private void EmailDonorsButtonClick(object sender, EventArgs e)
        {
            DonorIdsToEmail = new List<int>();
            foreach (DataRowView selectedItem in DonorsListBox.SelectedItems)
            {
                DonorIdsToEmail.Add(MathHelper.ParseIntZeroIfNull(selectedItem[0].ToString()));
            }

            DialogResult = DialogResult.OK;
            Close();
        }
        #endregion
    }
}
