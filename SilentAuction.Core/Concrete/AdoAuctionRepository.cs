using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using SilentAuction.Core.Abstract;
using SilentAuction.Core.Entities;
using SilentAuction.Utilities.Extensions;
using SilentAuction.Utilities.General;

namespace SilentAuction.Core.Concrete
{
    public class AdoAuctionRepository : IAuctionRepository
    {
        public bool Add(Auction auction)
        {
            DateTime currentDate = DateTime.Now;

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Constants.DatabaseConnectionString))
                {
                    connection.Open();

                    string sql = string.Format(@"INSERT INTO [{0}] (Name, Description, CreateDate, ModifiedDate)
                                                 VALUES ('{1}', '{2}', '{3}', '{3}')",
                                                 Constants.AuctionsTableName, auction.Name, 
                                                 auction.Description, currentDate);

                    SQLiteCommand command = new SQLiteCommand(sql, connection);
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Auction auction)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Auction auction)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Auction> GetAuctions()
        {
            DataTable data = new DataTable();
            using (SQLiteConnection connection = new SQLiteConnection(Constants.DatabaseConnectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand("SELECT Id, Name, Description, CreateDate, ModifiedDate FROM Auctions", connection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(data);
            }

            List<Auction> auctionsList = data.DataTableToList<Auction>();
            return auctionsList;
        }

        public Auction GetAuction(int id)
        {
            DataTable data = new DataTable();
            using (SQLiteConnection connection = new SQLiteConnection(Constants.DatabaseConnectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(string.Format("SELECT Id, Name, Description, CreateDate, ModifiedDate FROM Auctions WHERE Id = {0}", id), connection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(data);
            }

            List<Auction> auctionsList = data.DataTableToList<Auction>();
            return auctionsList.FirstOrDefault();
        }

        public Auction GetAuction(string name)
        {
            throw new NotImplementedException();
        }

        public bool AuctionNameExists(string name)
        {
            try
            {
                int count;
                using (SQLiteConnection connection = new SQLiteConnection(Constants.DatabaseConnectionString))
                {
                    connection.Open();

                    string sql = string.Format(@"SELECT COUNT(*) FROM {0} WHERE Name LIKE '{1}'", Constants.AuctionsTableName, name);

                    SQLiteCommand command = new SQLiteCommand(sql, connection);
                    count = MathHelper.ParseIntZeroIfNull(command.ExecuteScalar().ToString());
                }
                return count > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
