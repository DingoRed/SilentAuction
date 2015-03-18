using System;
using System.Data.SQLite;
using System.IO;

namespace SilentAuction.Utilities
{
    public class DatabaseInitializer
    {
        /// <summary>
        /// Creates the database file if it doesn't already exist
        /// </summary>
        /// <returns>true if successful (or already exists); false otherwise</returns>
        public static bool CreateDatabase()
        {
            if (File.Exists(DatabaseScripts.DatabaseName)) return true;
            try
            {
                SQLiteConnection.CreateFile(DatabaseScripts.DatabaseName);
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
                using (SQLiteConnection connection = new SQLiteConnection(DatabaseScripts.DatabaseConnectionString))
                {
                    connection.Open();

                    // Auctions table
                    SQLiteCommand command = new SQLiteCommand(DatabaseScripts.AuctionsTableCreateSql, connection);
                    command.ExecuteNonQuery();

                    // BidIncrementTypes table
                    command = new SQLiteCommand(DatabaseScripts.BidIncrementTypesCreateSql, connection);
                    command.ExecuteNonQuery();

                    // DonationDeliveryTypes table
                    command = new SQLiteCommand(DatabaseScripts.DonationDeliveryTypesCreateSql, connection);
                    command.ExecuteNonQuery();
                    
                    // DonorType table
                    command = new SQLiteCommand(DatabaseScripts.DonorTypesTableCreateSql, connection);
                    command.ExecuteNonQuery();

                   // Donors table
                    command = new SQLiteCommand(DatabaseScripts.DonorsTableCreateSql, connection);
                    command.ExecuteNonQuery();
                    
                    // Items table
                    command = new SQLiteCommand(DatabaseScripts.ItemsTableCreateSql, connection);
                    command.ExecuteNonQuery();

                    // ItemTypes table
                    command = new SQLiteCommand(DatabaseScripts.ItemTypesTableCreateSql, connection);
                    command.ExecuteNonQuery();

                    // RequestFormatTypes table
                    command = new SQLiteCommand(DatabaseScripts.RequestFormatTypesCreateSql, connection);
                    command.ExecuteNonQuery();

                    // RequestStatusTypes table
                    command = new SQLiteCommand(DatabaseScripts.RequestStatusTypesCreateSql, connection);
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
                using (SQLiteConnection connection = new SQLiteConnection(DatabaseScripts.DatabaseConnectionString))
                {
                    connection.Open();

                    // BidIncrementTypes table
                    SQLiteCommand command = new SQLiteCommand(DatabaseScripts.BidIncrementTypesPreload, connection);
                    command.ExecuteNonQuery();

                    // DonationDelivery table
                    command = new SQLiteCommand(DatabaseScripts.DonationDeliveryTypesPreload, connection);
                    command.ExecuteNonQuery();

                    // DonorType table
                    command = new SQLiteCommand(DatabaseScripts.DonorTypesPreload, connection);
                    command.ExecuteNonQuery();

                    // ItemTypes table
                    command = new SQLiteCommand(DatabaseScripts.ItemTypesPreload, connection);
                    command.ExecuteNonQuery();

                    // RequestFormatTypes table
                    command = new SQLiteCommand(DatabaseScripts.RequestFormatTypesPreload, connection);
                    command.ExecuteNonQuery();

                    // RequestStatusTypes table
                    command = new SQLiteCommand(DatabaseScripts.RequestStatusTypesPreload, connection);
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
