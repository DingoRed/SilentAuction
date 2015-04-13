using System;
using System.Collections.Generic;
using System.Data;
using System.Security;
using System.Windows.Forms;
using SilentAuction.Utilities;

namespace SilentAuction.Forms
{
    public partial class DocumentEmailForm : Form
    {
        #region Properties
        private int AuctionId { get; set; }
        public string Account { get; set; }
        public SecureString Password { get; set; }
        public List<int> DonorIdsToEmail { get; set; } 
        public List<string> CcAddressList { get; set; } 
        public string Subject { get; set; }
        #endregion

        #region Constructor
        public DocumentEmailForm(int auctionId)
        {
            AuctionId = auctionId;

            InitializeComponent();
        }
        #endregion

        #region Form Event Handlers
        private void EmailFormLoad(object sender, EventArgs e)
        {
            emailAccountsTableAdapter.FillEmailAccounts(silentAuctionDataSet.EmailAccounts);
            donorsWithEmailsTableAdapter.FillDonorsWithEmails(silentAuctionDataSet.DonorsWithEmails, AuctionId);
            
            if (silentAuctionDataSet.EmailAccounts.Rows.Count > 0)
            {
                AccountTextBox.Text = silentAuctionDataSet.EmailAccounts[0].Account;
                PasswordTextBox.Text = silentAuctionDataSet.EmailAccounts[0].Password;
            }

            WindowSettings.SetupInitialWindow(this, "EmailFormInitialLocation");
        }

        private void EmailFormClosing(object sender, FormClosingEventArgs e)
        {
            WindowSettings.SaveWindowSettings(this, "EmailFormInitialLocation");
        }        
        #endregion

        #region Button Event Handlers
        private void EmailButtonClick(object sender, EventArgs e)
        {
            if (!IsValidForm())
                return;

            if (SaveAccountCheckBox.Checked)
                SaveEmailAccount();

            Account = AccountTextBox.Text;
            Password = new SecureString();
            foreach (char c in PasswordTextBox.Text)
            {
                Password.AppendChar(c);
            }
            Subject = SubjectTextBox.Text;

            DonorIdsToEmail = new List<int>();
            foreach (DataRowView selectedItem in DonorsListBox.SelectedItems)
            {
                DonorIdsToEmail.Add(MathHelper.ParseIntZeroIfNull(selectedItem[0].ToString()));
            }

            CcAddressList = new List<string>();
            if (!string.IsNullOrEmpty(CcTextBox.Text))
            {
                foreach (string cc in CcTextBox.Text.Split(';'))
                {
                    CcAddressList.Add(cc);
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }
        #endregion

        #region Private Methods
        private bool IsValidForm()
        {
            bool isValid = true;
            int ccCount = 0;

            if (string.IsNullOrEmpty(AccountTextBox.Text))
            {
                errorProvider1.SetError(AccountTextBox, "Account required to send email");
                isValid = false;
            }
            if (string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                errorProvider1.SetError(PasswordTextBox, "Password required to send email");
                isValid = false;
            }

            if (string.IsNullOrEmpty(SubjectTextBox.Text))
            {
                errorProvider1.SetError(SubjectTextBox, "Subject is required to send email");
                isValid = false;
            }

            if (!string.IsNullOrEmpty(CcTextBox.Text))
            {
                foreach (string cc in CcTextBox.Text.Split(';'))
                {
                    ccCount++;

                    if (!EmailHelper.IsValidEmailAddress(cc))
                    {
                        errorProvider1.SetError(CcTextBox, "Invalid email address");
                        isValid = false;
                        break;
                    }
                }
            }

            if (DonorsListBox.SelectedItems.Count <= 0 && ccCount <= 0)
            {
                errorProvider1.SetError(DonorsListBox, "At least one Donor or Cc address required to send email");
                errorProvider1.SetError(CcTextBox, "At least one Donor or Cc address required to send email");
                isValid = false;
            }

            return isValid;
        }
        
        private void SaveEmailAccount()
        {
            if (silentAuctionDataSet.EmailAccounts.Rows.Count > 0)
            {
                silentAuctionDataSet.EmailAccounts[0].Account = AccountTextBox.Text;
                silentAuctionDataSet.EmailAccounts[0].Password = PasswordTextBox.Text;

                SilentAuctionDataSet.EmailAccountsDataTable modifiedItems =
                    (SilentAuctionDataSet.EmailAccountsDataTable)
                        silentAuctionDataSet.EmailAccounts.GetChanges(DataRowState.Modified);

                if (modifiedItems != null)
                {
                    emailAccountsTableAdapter.Update(modifiedItems);
                    silentAuctionDataSet.AcceptChanges();
                    modifiedItems.Dispose();
                }
            }
            else
            {
                silentAuctionDataSet.EmailAccounts.AddEmailAccountsRow(AccountTextBox.Text, PasswordTextBox.Text);

                SilentAuctionDataSet.EmailAccountsDataTable newDocuments =
                    (SilentAuctionDataSet.EmailAccountsDataTable)
                        silentAuctionDataSet.EmailAccounts.GetChanges(DataRowState.Added);

                if (newDocuments != null)
                {
                    emailAccountsTableAdapter.Update(newDocuments);
                    silentAuctionDataSet.AcceptChanges();
                    newDocuments.Dispose();
                    emailAccountsTableAdapter.FillEmailAccounts(silentAuctionDataSet.EmailAccounts);
                }
            }
        }
        #endregion
    }
}
