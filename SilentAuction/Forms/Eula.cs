using System;
using System.Windows.Forms;
using SilentAuction.Properties;

namespace SilentAuction.Forms
{
    public partial class Eula : Form
    {
        public Eula()
        {
            InitializeComponent();
            EulaTextBox.Text = Resources.EULA;
            EulaTextBox.Select(0,0);
        }

        private void EulaLoad(object sender, EventArgs e)
        {
            EulaDeclineButton.Focus();
        }

        private void AcceptButtonClick(object sender, EventArgs e)
        {
            Settings.Default.EULAAccepted = true;
            Settings.Default.Save();
            DialogResult = DialogResult.Yes;
        }

        private void DeclineButtonClick(object sender, EventArgs e)
        {
            Settings.Default.EULAAccepted = false;
            Settings.Default.Save();
            DialogResult = DialogResult.No;
        }

    }
}
