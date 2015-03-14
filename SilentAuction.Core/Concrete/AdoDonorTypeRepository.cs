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
    public class AdoDonorTypeRepository : IDonorTypeRepository
    {
        public List<DonorType> GetDonorTypes()
        {
            DataTable data = new DataTable();
            using (SQLiteConnection connection = new SQLiteConnection(Constants.DatabaseConnectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand("SELECT * FROM DonorTypes", connection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(data);
            }

            List<DonorType> donorTypesList = data.DataTableToList<DonorType>();
            return donorTypesList; 
        }

        public DonorType GetDonorType(int id)
        {
            throw new NotImplementedException();
        }

        public DonorType GetDonorType(string name)
        {
            throw new NotImplementedException();
        }
    }
}
