using System;
using System.IO;
using System.Windows.Forms;

namespace SilentAuction.Utilities
{
    public class FileHelper
    {
        /// <summary>
        /// Saves the string to a .csv file
        /// </summary>
        /// <param name="dataToSave">Comma separated list of quoted values</param>
        /// <param name="initialFilename">Initial filename for dialog box</param>
        /// <returns>true if successful, false otherwise</returns>
        public static bool SaveCsvFile(string dataToSave, string initialFilename)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "csv files (*.csv)|*.csv";
            saveFileDialog.DefaultExt = "csv";
            saveFileDialog.FileName = initialFilename;
            saveFileDialog.RestoreDirectory = true;

            DialogResult saveResult = saveFileDialog.ShowDialog();
            if (saveResult == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, dataToSave);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    return false;
                }
            }
            return true;
        }
    }
}
