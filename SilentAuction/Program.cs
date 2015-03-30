using System;
using System.Windows.Forms;
using System.IO;
using SilentAuction.Forms;
using SilentAuction.Utilities;

namespace SilentAuction
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!File.Exists(DatabaseCreateScripts.DatabaseName))
            {
                DatabaseInitializer.CreateDatabase();
                DatabaseInitializer.CreateAllTables();
                DatabaseInitializer.PreloadDataForTables();
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            //Application.Run(new SearchByDonorName());
        }
    }
}
