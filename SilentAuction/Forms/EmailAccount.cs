using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilentAuction.Forms
{
    public partial class EmailAccount : Form
    {
        public EmailAccount()
        {
            InitializeComponent();
        }

        private void SendEmailButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
