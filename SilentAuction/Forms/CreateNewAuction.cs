using System;
using System.Windows.Forms;

namespace SilentAuction.Forms
{
    public partial class CreateNewAuctionForm : Form
    {
        public int AuctionId { get; set; }

        public CreateNewAuctionForm()
        {
            InitializeComponent();
        }

        #region Event Handlers
        private void CreateAuctionButtonClick(object sender, EventArgs e)
        {
            // TODO:  Check for duplicate again...then save...then set AuctionId with new value
            MessageBox.Show("Save to Database (TBD)");
            AuctionId = 1;  // Change this
            DialogResult = DialogResult.OK;
            Close();
        }


        #endregion

        private void NameTextBoxTextChanged(object sender, EventArgs e)
        {
            // TODO:  Check for duplication
            //MessageBox.Show("Check for duplication (TBD)");
        }

        
    }
}
