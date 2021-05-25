using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace FloraWarehouseManagement.Classes.Utilities
{
    public class CheckCredentials
    {
        private static readonly string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;

        public CheckCredentials() { }

        public static int CheckUsername(string Username)
        {
            int userExists;
            SQLiteConnection connection = new SQLiteConnection(@"data source=" + projectDirectory + @"\Database\db.db");
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("SELECT EXISTS(SELECT 1 FROM User WHERE Username=@Username)", connection);
            command.Parameters.AddWithValue("Username", Username);
            command.ExecuteNonQuery();
            userExists = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return userExists;
        }

        public static int CheckUsernameAndPassword(string Username, string Password)
        {
            int userExists;
            SQLiteConnection connection = new SQLiteConnection(@"data source=" + projectDirectory + @"\Database\db.db");
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("SELECT EXISTS(SELECT 1 FROM User WHERE Username=@Username AND Password=@Password)", connection);
            command.Parameters.AddWithValue("Username", Username);
            command.Parameters.AddWithValue("Password", Password);
            command.ExecuteNonQuery();
            userExists = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return userExists;
        }
    }
}
