using System;
using System.Linq;
using System.Windows.Forms;
using SilentAuction.Utilities;

namespace SilentAuction.Forms
{
    public partial class DocumentNameEntry : Form
    {
        #region Properties
        public string DocumentName { get; set; }
        #endregion

        #region Constructor
        public DocumentNameEntry()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Event Handlers
        private void DocumentNameEntryLoad(object sender, EventArgs e)
        {
            documentNamesTableAdapter.FillDocumentNames(silentAuctionDataSet.DocumentNames);

            WindowSettings.SetupInitialWindow(this, "DocumentNameEntryInitialLocation");
        }

        private void DocumentNameEntryFormClosing(object sender, FormClosingEventArgs e)
        {
            WindowSettings.SaveWindowSettings(this, "DocumentNameEntryInitialLocation");
        }
        #endregion

        #region Event Handlers
        private void SaveButtonClick(object sender, EventArgs e)
        {
            if(!IsValidForm())
                return;

            DocumentName = DocumentNameTextBox.Text;
            DialogResult = DialogResult.OK;
    
            Close();
        }

        private void DocumentNameTextBoxTextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(DocumentNameTextBox, "");
            if (silentAuctionDataSet.DocumentNames.Any(n => n.Name.ToLower() == DocumentNameTextBox.Text.ToLower()))
            {
                errorProvider1.SetError(DocumentNameTextBox, "Name already exists");
            }
        }
        #endregion

        #region Private Methods
        private bool IsValidForm()
        {
            errorProvider1.SetError(DocumentNameTextBox, "");

            bool isValid = true;

            if (string.IsNullOrEmpty(DocumentNameTextBox.Text))
            {
                errorProvider1.SetError(DocumentNameTextBox, "Name required");
                isValid = false;
            }
            else if (silentAuctionDataSet.DocumentNames.Any(n => n.Name.ToLower() == DocumentNameTextBox.Text.ToLower()))
            {
                errorProvider1.SetError(DocumentNameTextBox, "Name already exists");
                isValid = false;
            }
            
            return isValid;
        }
        #endregion
    }
}
