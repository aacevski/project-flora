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
    public class CustomerFunctions
    {
        private static readonly string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        SQLiteConnection connection = new SQLiteConnection(@"data source=" + projectDirectory + @"\Database\db.db");

        public static CustomerFunctions Instance { get; } = new CustomerFunctions();

        public CustomerFunctions() { }

        // Dali ovaa funkcija treba nekade?
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

        public void Add(string Name, string TaxNum, string EMBS, string BankNum1, string BankNum2, string Bank, string Address, string City, string ZipCode, string ContactPerson1, string ContactPerson2, string Phone1, string Phone2, string EMail, string Description)
        {
            SQLiteCommand command = new SQLiteCommand
                (
                "INSERT INTO Customers" +
                "(Назив, " +
                "Даночен_број, " +
                "ЕМБС, " +
                "Жиро_сметка, " +
                "Жиро_сметка_доп, " +
                "Банка, " +
                "Адреса, " +
                "Град, " +
                "Поштенски_број, " +
                "Контакт_лице_1, " +
                "Контакт_лице_2, " +
                "Телефон_1, " +
                "Телефон_2, " +
                "Е_пошта, " +
                "Забелешка) " +

                "VALUES" +
                "(@Name, " +
                "@TaxNum, " +
                "@EMBS, " +
                "@BankNum1, " +
                "@BankNum2, " +
                "@Bank, " +
                "@Address, " +
                "@City, " +
                "@ZipCode, " +
                "@ContactPerson1, " +
                "@ContactPerson2, " +
                "@Phone1, " +
                "@Phone2, " +
                "@EMail, " +
                "@Description)",
                connection);

            connection.Open();

            command.Parameters.AddWithValue("Name", Name);
            command.Parameters.AddWithValue("TaxNum", TaxNum);
            command.Parameters.AddWithValue("EMBS", EMBS);
            command.Parameters.AddWithValue("BankNum1", BankNum1);
            command.Parameters.AddWithValue("BankNum2", BankNum2);
            command.Parameters.AddWithValue("Bank", Bank);
            command.Parameters.AddWithValue("Address", Address);
            command.Parameters.AddWithValue("City", City);
            command.Parameters.AddWithValue("ZipCode", ZipCode);
            command.Parameters.AddWithValue("ContactPerson1", ContactPerson1);
            command.Parameters.AddWithValue("ContactPerson2", ContactPerson2);
            command.Parameters.AddWithValue("Phone1", Phone1);
            command.Parameters.AddWithValue("Phone2", Phone2);
            command.Parameters.AddWithValue("EMail", EMail);
            command.Parameters.AddWithValue("Description", Description);

            command.ExecuteNonQuery();
            connection.Close();

            DisplayData();
        }

        public int Exists(string TaxNum)
        {
            int productExists;
            connection.Open();
            string checkIfExistsQuery = "SELECT EXISTS(SELECT 1 FROM Customers WHERE Даночен_број=@TaxNum)";
            SQLiteCommand command = new SQLiteCommand(checkIfExistsQuery, connection);
            command.Parameters.AddWithValue("TaxNum", TaxNum);
            productExists = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return productExists;
        }

        public void Delete(string TaxNum)
        {
            SQLiteCommand command = new SQLiteCommand("DELETE FROM Customers WHERE Даночен_број=@TaxNum", connection);
            connection.Open();
            command.Parameters.AddWithValue("TaxNum", TaxNum);
            command.ExecuteNonQuery();
            DataTable productTable = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(productTable);
            connection.Close();
        }
    }
}
