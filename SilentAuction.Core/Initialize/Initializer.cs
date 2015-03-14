using System;
using System.Data.SQLite;
using System.IO;
using SilentAuction.Utilities.General;

namespace SilentAuction.Core.Initialize
{
    public class Initializer
    {
        /// <summary>
        /// Creates the database file if it doesn't already exist
        /// </summary>
        /// <returns>true if successful (or already exists); false otherwise</returns>
        public static bool CreateDatabase()
        {
            if (File.Exists(Constants.DatabaseName)) return true;
            try
            {
                SQLiteConnection.CreateFile(Constants.DatabaseName);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Creates all of the tables necessary for the application if they don't exist
        /// </summary>
        /// <returns>true if successful (or already exists); false otherwise</returns>
        public static bool CreateAllTables()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Constants.DatabaseConnectionString))
                {
                    connection.Open();
                    
                     // DonorType table
                    SQLiteCommand command = new SQLiteCommand(Constants.DonorTypesTableCreateSql, connection);
                    command.ExecuteNonQuery();

                   // Donors table
                    command = new SQLiteCommand(Constants.DonorsTableCreateSql, connection);
                    command.ExecuteNonQuery();
                    
                    // Auctions table
                    command = new SQLiteCommand(Constants.AuctionsTableCreateSql, connection);
                    command.ExecuteNonQuery();

                    // Items table
                    command = new SQLiteCommand(Constants.ItemsTableCreateSql, connection);
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Used to preload data into tables (mainly for lookup tables)
        /// </summary>
        /// <returns>true if successful; false otherwise</returns>
        public static bool PreloadDataForTables()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Constants.DatabaseConnectionString))
                {
                    connection.Open();

                    // DonorType table
                    SQLiteCommand command = new SQLiteCommand(Constants.DonorTypesPreload, connection);
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
