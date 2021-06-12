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
    public class Customer_DbCommunication : DbCommunication
    {
        public Customer_DbCommunication() { }

        public static void AddCustomer (string Name, string TaxNum, string EMBS, string BankNum1, string BankNum2, string Bank, string Address, string City, string ZipCode, string ContactPerson1, string ContactPerson2, string Phone1, string Phone2, string EMail, string Description)
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

        }

        public static void EditCustomer (string OldTaxNum, string Name, string TaxNumber, string EMBS, string MainBankNumber, string SecondaryBankNumber, string Bank, string Address, string City, string ZipCode, string ContactPerson1, string ContactPerson2, string Phone1, string Phone2, string Email, string Description)
        {
            SQLiteCommand command = new SQLiteCommand
                (
                "UPDATE Customers SET " +
                "Назив = @Name, " +
                "Даночен_број = @TaxNumber, " +
                "ЕМБС = @EMBS, " +
                "Жиро_сметка = @MainBankNumber, " +
                "Жиро_сметка_доп = @SecondaryBankNumber, " +
                "Банка = @Bank, " +
                "Адреса = @Address, " +
                "Контакт_лице_1 = @ContactPerson1, " +
                "Контакт_лице_2 = @ContactPerson2, " +
                "Телефон_1 = @Phone1, " +
                "Телефон_2 = @Phone2, " +
                "Е_пошта = @Email, " +
                "Град = @City, " +
                "Поштенски_број = @ZipCode, " +
                "Забелешка = @Description " +
                "WHERE Даночен_број = @OldTaxNum",
                connection
                );

            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@TaxNumber", TaxNumber);
            command.Parameters.AddWithValue("@EMBS", EMBS);
            command.Parameters.AddWithValue("@MainBankNumber", MainBankNumber);
            command.Parameters.AddWithValue("@SecondaryBankNumber", SecondaryBankNumber);
            command.Parameters.AddWithValue("@Bank", Bank);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@ContactPerson1", ContactPerson1);
            command.Parameters.AddWithValue("@ContactPerson2", ContactPerson2);
            command.Parameters.AddWithValue("@Phone1", Phone1);
            command.Parameters.AddWithValue("@Phone2", Phone2);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@City", City);
            command.Parameters.AddWithValue("@ZipCode", ZipCode);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@OldTaxNum", OldTaxNum);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }

        public static DataTable FilterCustomers(string FilterType, string FilterProperty)
        {
            SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM Customers WHERE {FilterType} = @FilterProperty", connection);
            cmd.Parameters.AddWithValue("FilterProperty", FilterProperty);

            connection.Open();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            connection.Close();

            return dt;
        }

        public static int GetCustomerDBID(string name)
        {
            int id;

            SQLiteCommand cmd = new SQLiteCommand("SELECT ID FROM Customers WHERE Назив = @Name", connection);
            cmd.Parameters.AddWithValue("Name", name);

            connection.Open();
            id = int.Parse(cmd.ExecuteScalar().ToString());
            connection.Close();

            return id;
        }
    }
}
