using System.Windows.Forms;

namespace SilentAuction.Utilities
{
    public class GenericPageHelper
    {
        /// <summary>
        /// Displays a messagebox to make sure the user knows they have unsaved changes
        /// </summary>
        /// <returns>Yes, No</returns>
        public static bool StayOnPage()
        {
            var result = MessageBox.Show("You have unsaved changes.\n\rAre you sure you want to continue without saving?", "Unsaved Changes",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            return result == DialogResult.No;
        }
    }
}