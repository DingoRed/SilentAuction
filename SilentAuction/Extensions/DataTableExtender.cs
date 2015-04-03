using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SilentAuction.Extensions
{
    public static class DataTableExtender
    {
        /// <summary>
        /// Converts a DataTable to a list with generic objects
        /// </summary>
        /// <typeparam name="T">Generic object</typeparam>
        /// <param name="table">DataTable</param>
        /// <returns>List with generic objects</returns>
        public static List<T> DataTableToList<T>(this DataTable table) where T : class, new()
        {
            try
            {
                List<T> list = new List<T>();

                foreach (var row in table.AsEnumerable())
                {
                    T obj = new T();

                    foreach (var prop in obj.GetType().GetProperties())
                    {
                        try
                        {
                            PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                            propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);
                        }
                        catch(Exception)
                        {

                        }
                    }

                    list.Add(obj);
                }

                return list;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Converts a DataTable to a String in CSV format
        /// </summary>
        /// <param name="table">The table</param>
        /// <returns>String of the table in CSV format</returns>
        public static String DataTableToCsvFormat(this DataTable table)
        {
            StringBuilder sb = new StringBuilder();
            IEnumerable<string> columnNames = table.Columns.Cast<DataColumn>().Select(c => c.ColumnName);
            sb.AppendLine(string.Join(",", columnNames));

            foreach (DataRow dataRow in table.Rows)
            {
                IEnumerable<string> fields = dataRow.ItemArray.Select(field =>
                    string.Concat("\"", field.ToString().Replace("\"", "\"\""), "\""));
                sb.AppendLine(string.Join(",", fields));
            }

            return sb.ToString();
        }

        /// <summary>
        /// Writes a DataTable to a file in CSV format
        /// </summary>
        /// <param name="table">The table</param>
        /// <param name="filePath">The path to write to, including filename</param>
        public static void WriteToCsvFile(this DataTable table, string filePath)
        {
            System.IO.File.WriteAllText(filePath, DataTableToCsvFormat(table));
        }
    }
}
