using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloraWarehouseManagement.Classes.Utilities
{
    abstract public class DbCommunication
    {
        protected static readonly string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        protected static SQLiteConnection connection = new SQLiteConnection(@"data source=" + projectDirectory + @"\Database\db.db");

        public static DataTable DisplayData(string query)
        {
            DataTable dt = new DataTable();
            SQLiteCommand command = new SQLiteCommand(query, connection);

            connection.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(dt);
            connection.Close();

            return dt;
        }

        public static int Exists(string Table, string FilterType, string FilterProperty)
        {
            int productExists;

            connection.Open();
            SQLiteCommand command = new SQLiteCommand($"SELECT EXISTS(SELECT 1 FROM {Table} WHERE {FilterType}=@FilterProperty)", connection);
            command.Parameters.AddWithValue("FilterType", FilterType);
            command.Parameters.AddWithValue("FilterProperty", FilterProperty);
            productExists = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();

            return productExists;
        }

        public static void Delete(string Table, string FilterType, string FilterProperty)
        {
            SQLiteCommand command = new SQLiteCommand($"DELETE FROM {Table} WHERE {FilterType}=@FilterProperty", connection);
            command.Parameters.AddWithValue("FilterType", FilterType);
            command.Parameters.AddWithValue("FilterProperty", FilterProperty);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
