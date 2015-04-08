using System;
using System.Windows.Forms;

namespace SilentAuction.Forms
{
    public partial class DocumentNameEntry : Form
    {
        public string DocumentName { get; set; }
        public DocumentNameEntry()
        {
            InitializeComponent();
        }

        private void DocumentNameEntryLoad(object sender, EventArgs e)
        {
            // TODO: Set Window location
        }

        private void DocumentNameEntryFormClosing(object sender, FormClosingEventArgs e)
        {
            // TODO: Set Window location
        }
        
        private void SaveButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DocumentNameTextBox.Text))
            {
                errorProvider1.SetError(DocumentNameTextBox, "Name required");
                return;
            }

            DocumentName = DocumentNameTextBox.Text;
            DialogResult = DialogResult.OK;
    
            Close();
        }
    }
}
