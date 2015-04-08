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

                    DatabaseCreateScripts databaseCreateScripts = new DatabaseCreateScripts();
                    
                    foreach (string tableCreateScript in databaseCreateScripts.TableCreateScripts)
                    {
                        SQLiteCommand cmd = new SQLiteCommand(tableCreateScript, connection);
                        cmd.ExecuteNonQuery();
                    }
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

                    DatabaseCreateScripts databaseCreateScripts = new DatabaseCreateScripts();

                    foreach (string tablePreLoadScript in databaseCreateScripts.TablePreLoadScripts)
                    {
                        SQLiteCommand cmd = new SQLiteCommand(tablePreLoadScript, connection);
                        cmd.ExecuteNonQuery();
                    }
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
