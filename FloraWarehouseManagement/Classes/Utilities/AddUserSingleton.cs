using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.IO;

namespace FloraWarehouseManagement.Classes.Utilities
{
    public class AddUserSingleton
    {
        private static readonly string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;


        public static AddUserSingleton Instance { get; } = new AddUserSingleton();

        public AddUserSingleton() { }

        public void AddUser(string Username, string Password)
        {
            SQLiteConnection connection = new SQLiteConnection(@"data source=" + projectDirectory + @"\Database\db.db");
            string addUserQuery = "INSERT INTO User(Username, Password) VALUES(@Username, @Password)";
            SQLiteCommand addUserCommand = new SQLiteCommand(addUserQuery, connection);
            addUserCommand.Parameters.AddWithValue("Username", Username);
            addUserCommand.Parameters.AddWithValue("Password", Password);
            DataTable userTable = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(addUserCommand);
            adapter.Fill(userTable);
        }
    }
}
