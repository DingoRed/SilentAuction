using System;
using System.Windows.Forms;
using SilentAuction.Utilities;

namespace SilentAuction.Forms
{
    public partial class ProgressBarForm : Form
    {
        #region Properties
        public int PercentFinished
        {
            get
            {
                return progressBar1.Value;
            }
            set
            {
                progressBar1.Value = value;
            }
        }

        public string CurrentJobText
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }
        #endregion

        #region Constructor
        public ProgressBarForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Event Handlers
        private void ProgressBarFormLoad(object sender, EventArgs e)
        {
            WindowSettings.SetupInitialWindow(this, "ProgressBarFormInitialLocation");
        }

        private void ProgressBarFormFormClosing(object sender, FormClosingEventArgs e)
        {
            WindowSettings.SaveWindowSettings(this, "ProgressBarFormInitialLocation");
        }
        #endregion
    }
}
