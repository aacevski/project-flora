using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace FloraWarehouseManagement.Classes.Utilities
{
    public class AddUserSingleton
    {
        private static readonly string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;


        public static AddUserSingleton Instance { get; } = new AddUserSingleton();

        public AddUserSingleton() { }

        public void DisplayData()
        {
            SQLiteConnection connection = new SQLiteConnection(@"data source=" + projectDirectory + @"\Database\db.db");
            SQLiteCommand cmd = new SQLiteCommand("SELECT * from User", connection);
            connection.Open();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            connection.Close();
        }

        public void AddUser(string Username, string Password)
        {
            SQLiteConnection connection = new SQLiteConnection(@"data source=" + projectDirectory + @"\Database\db.db");
            SQLiteCommand command = new SQLiteCommand("INSERT INTO User(Username, Password) VALUES(@Username, @Password)", connection);
            connection.Open();
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.ExecuteNonQuery();
            connection.Close();
            DisplayData();
        }
    }
}
