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
    public class AdoDonorRepository : IDonorRepository
    {
        public IQueryable<Donor> Donors
        {
            get { throw new NotImplementedException(); }
        }

        public bool Add(Donor donor)
        {
            DateTime currentDate = DateTime.Now;

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Constants.DatabaseConnectionString))
                {
                    connection.Open();

                    string sql = string.Format(@"INSERT INTO [{0}] (DonorTypeId, Name, ContactName, Street1, Street2, City, State, ZipCode, 
                                                                    Phone1, Extension1, Phone2, Extension2, Email, CreateDate, ModifiedDate)
                                                 VALUES ({1}, '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', 
                                                        '{10}', '{11}', '{12}', '{13}', '{14}', '{15}')",
                                                 Constants.DonorsTableName, 
                                                 donor.DonorTypeId, donor.Name, donor.ContactName, donor.Street1, donor.Street2, donor.City,
                                                 donor.State, donor.ZipCode,donor.Phone1, donor.Extension1, donor.Phone2, donor.Extension2,
                                                 donor.Email, currentDate, currentDate);

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

        public bool Update(Donor donor)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Donor donor)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Donor> GetDonors()
        {
            DataTable data = new DataTable();
            using (SQLiteConnection connection = new SQLiteConnection(Constants.DatabaseConnectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand("SELECT Id, DonorTypeId, Name, ContactName, Street1, Street2, City, State, ZipCode, Phone1, Extension1, Phone2, Extension2, Email, CreateDate, ModifiedDate FROM Donors", connection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(data);
            }

            List<Donor> donorsList = data.DataTableToList<Donor>();
            return donorsList; 
        }

        public Donor GetDonor(int id)
        {
            DataTable data = new DataTable();
            using (SQLiteConnection connection = new SQLiteConnection(Constants.DatabaseConnectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(string.Format(@"SELECT Id, DonorTypeId, Name, ContactName, Street1, Street2, City, 
State, ZipCode, Phone1, Extension1, Phone2, Extension2, Email, CreateDate, ModifiedDate FROM Donors WHERE Id = {0}", id), connection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(data);
            }

            List<Donor> donorsList = data.DataTableToList<Donor>();
            return donorsList.FirstOrDefault();
        }

        public Donor GetDonor(string name)
        {
            throw new NotImplementedException();
        }
    }
}
