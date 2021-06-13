using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloraWarehouseManagement.Classes.Utilities
{
    public class Employee_DbCommunication : DbCommunication
    {
        public Employee_DbCommunication() { }

        public static void AddEmployee(string Name, string Lastname, string EMBG, string Salary, string Start, string Address, string Position, string IdNumber, string Phone, string Bank, string BankNumber, string Description)
        {
            SQLiteCommand command = new SQLiteCommand
                (
                "INSERT INTO Employees" +
                "(Име, " +
                "Презиме, " +
                "ЕМБГ, " +
                "Плата, " +
                "Почеток, " +
                "Адреса, " +
                "Работно_место, " +
                "Број_на_лична_карта, " +
                "Телефон, " +
                "Банка, " +
                "Трансакциска_сметка, " +
                "Забелешка) " +

                "VALUES" +
                "(@Name, " +
                "@Lastname, " +
                "@EMBG, " +
                "@Salary, " +
                "@Start, " +
                "@Address, " +
                "@Position, " +
                "@IdNumber, " +
                "@PhoneNumber, " +
                "@Bank, " +
                "@BankNumber, " +
                "@Description)",
                connection
                );

            connection.Open();

            command.Parameters.AddWithValue("Name", Name);
            command.Parameters.AddWithValue("Lastname", Lastname);
            command.Parameters.AddWithValue("EMBG", EMBG);
            command.Parameters.AddWithValue("Salary", Salary);
            command.Parameters.AddWithValue("Start", Start);
            command.Parameters.AddWithValue("Address", Address);
            command.Parameters.AddWithValue("Position", Position);
            command.Parameters.AddWithValue("IdNumber", IdNumber);
            command.Parameters.AddWithValue("PhoneNumber", Phone);
            command.Parameters.AddWithValue("Bank", Bank);
            command.Parameters.AddWithValue("BankNumber", BankNumber);
            command.Parameters.AddWithValue("Description", Description);


            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void EditEmployee(string OldEMBG, string Name, string Lastname, string EMBG, string  Salary, string Start, string  Address, string Position, string IdNumber, string Phone, string Bank, string BankNumber, string Description)
        {
            SQLiteCommand command = new SQLiteCommand
                (
                "UPDATE Employees SET " +
                "Име = @Name, " +
                "Презиме = @Lastname, " +
                "ЕМБГ = @EMBG, " +
                "Плата = @Salary, " +
                "Почеток = @Start, " +
                "Адреса = @Address, " +
                "Работно_место = @Position, " +
                "Број_на_лична_карта = @IdNumber, " +
                "Телефон = @Phone, " +
                "Банка = @Bank, " +
                "Трансакциска_сметка = @BankNumber, " +
                "Забелешка = @Description " +
                "WHERE ЕМБГ = @OldEMBG",
                connection
                );

            connection.Open();

            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Lastname", Lastname);
            command.Parameters.AddWithValue("@EMBG", EMBG);
            command.Parameters.AddWithValue("@Salary", Salary);
            command.Parameters.AddWithValue("@Start", Start);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Position", Position);
            command.Parameters.AddWithValue("@IdNumber", IdNumber);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Bank", Bank);
            command.Parameters.AddWithValue("@BankNumber", BankNumber);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@OldEMBG", OldEMBG);


            command.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable FilterEmployees(string FilterProperty)
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT Име, Презиме, ЕМБГ, Плата, Почеток, Адреса, Работно_место, Број_на_лична_карта, Телефон, Банка, Трансакциска_сметка, Забелешка FROM Employees WHERE Име = @FilterProperty", connection);
            cmd.Parameters.AddWithValue("FilterProperty", FilterProperty);

            connection.Open();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            connection.Close();

            return dt;
        }
    }
}
