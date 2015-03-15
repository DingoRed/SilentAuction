using System;
using System.Windows.Forms;
using System.IO;
using SilentAuction.Core.Initialize;
using SilentAuction.Utilities.General;

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
            if (!File.Exists(Constants.DatabaseName))
            {
                Initializer.CreateDatabase();
                Initializer.CreateAllTables();
                Initializer.PreloadDataForTables();
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm2());
        }
    }
}
