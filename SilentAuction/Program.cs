using System;
using System.Windows.Forms;
using System.IO;
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
            if (!File.Exists(DatabaseScripts.DatabaseName))
            {
                DatabaseInitializer.CreateDatabase();
                DatabaseInitializer.CreateAllTables();
                DatabaseInitializer.PreloadDataForTables();
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm2());
        }
    }
}
