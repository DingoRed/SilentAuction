using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using SilentAuction.Core.Abstract;
using SilentAuction.Core.Entities;
using SilentAuction.Utilities.Extensions;
using SilentAuction.Utilities.General;

namespace SilentAuction.Core.Concrete
{
    public class AdoItemRepository : IItemRepository
    {
        public bool Add(Item item)
        {
            DateTime currentDate = DateTime.Now;

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Constants.DatabaseConnectionString))
                {
                    connection.Open();

                    string sql = string.Format(@"INSERT INTO [{0}] (DonorId, AuctionId, Name, Description, Qty, Notes, CreateDate, ModifiedDate)
                                                 VALUES ({1}, {2}, '{3}', '{4}', {5}, '{6}', '{7}', '{8}')",
                                                 Constants.ItemsTableName,
                                                 item.DonorId, item.AuctionId, item.Name, item.Description, item.Qty,
                                                 item.Notes, currentDate, currentDate);

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

        public bool Update(Item item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Item item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Item> GetItems(int auctionId)
        {
            DataTable data = new DataTable();
            using (SQLiteConnection connection = new SQLiteConnection(Constants.DatabaseConnectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(string.Format("SELECT * FROM Items WHERE AuctionId = {0}", auctionId), connection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(data);
            }

            List<Item> itemsList = data.DataTableToList<Item>();
            return itemsList;
        }

        public Item GetItem(int id)
        {
            throw new NotImplementedException();
        }
    }
}
