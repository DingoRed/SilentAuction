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
            if (File.Exists(DatabaseCreateScripts.DatabaseName)) return true;
            try
            {
                SQLiteConnection.CreateFile(DatabaseCreateScripts.DatabaseName);
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
                using (SQLiteConnection connection = new SQLiteConnection(DatabaseCreateScripts.DatabaseConnectionString))
                {
                    connection.Open();

                    // Auctions table
                    SQLiteCommand command = new SQLiteCommand(DatabaseCreateScripts.AuctionsTableCreateSql, connection);
                    command.ExecuteNonQuery();

                    // AuctionDonorRequestStatus table
                    //command = new SQLiteCommand(DatabaseScripts.AuctionDonorRequestStatusTableCreateSql, connection);
                    //command.ExecuteNonQuery();

                    // BidIncrementTypes table
                    command = new SQLiteCommand(DatabaseCreateScripts.BidIncrementTypesCreateSql, connection);
                    command.ExecuteNonQuery();

                    // DonationDeliveryTypes table
                    command = new SQLiteCommand(DatabaseCreateScripts.DonationDeliveryTypesCreateSql, connection);
                    command.ExecuteNonQuery();
                    
                    // DonorType table
                    command = new SQLiteCommand(DatabaseCreateScripts.DonorTypesTableCreateSql, connection);
                    command.ExecuteNonQuery();

                   // Donors table
                    command = new SQLiteCommand(DatabaseCreateScripts.DonorsTableCreateSql, connection);
                    command.ExecuteNonQuery();
                    
                    // Items table
                    command = new SQLiteCommand(DatabaseCreateScripts.ItemsTableCreateSql, connection);
                    command.ExecuteNonQuery();

                    // ItemTypes table
                    command = new SQLiteCommand(DatabaseCreateScripts.ItemTypesTableCreateSql, connection);
                    command.ExecuteNonQuery();

                    // RequestFormatTypes table
                    command = new SQLiteCommand(DatabaseCreateScripts.RequestFormatTypesCreateSql, connection);
                    command.ExecuteNonQuery();

                    // RequestStatusTypes table
                    command = new SQLiteCommand(DatabaseCreateScripts.RequestStatusTypesCreateSql, connection);
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
                using (SQLiteConnection connection = new SQLiteConnection(DatabaseCreateScripts.DatabaseConnectionString))
                {
                    connection.Open();

                    // BidIncrementTypes table
                    SQLiteCommand command = new SQLiteCommand(DatabaseCreateScripts.BidIncrementTypesPreload, connection);
                    command.ExecuteNonQuery();

                    // DonationDelivery table
                    command = new SQLiteCommand(DatabaseCreateScripts.DonationDeliveryTypesPreload, connection);
                    command.ExecuteNonQuery();

                    // DonorType table
                    command = new SQLiteCommand(DatabaseCreateScripts.DonorTypesPreload, connection);
                    command.ExecuteNonQuery();

                    // ItemTypes table
                    command = new SQLiteCommand(DatabaseCreateScripts.ItemTypesPreload, connection);
                    command.ExecuteNonQuery();

                    // RequestFormatTypes table
                    command = new SQLiteCommand(DatabaseCreateScripts.RequestFormatTypesPreload, connection);
                    command.ExecuteNonQuery();

                    // RequestStatusTypes table
                    command = new SQLiteCommand(DatabaseCreateScripts.RequestStatusTypesPreload, connection);
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
