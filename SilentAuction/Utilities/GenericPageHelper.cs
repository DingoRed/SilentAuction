using System.Drawing;
using System.Windows.Forms;
using SilentAuction.Properties;

namespace SilentAuction.Utilities
{
    public class GenericPageHelper
    {
        public static bool StayOnPage()
        {
            var result = MessageBox.Show("You have unsaved changes.\n\rAre you sure you want to close without saving?", "Unsaved Changes",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            return result == DialogResult.No;
        }
    }
}