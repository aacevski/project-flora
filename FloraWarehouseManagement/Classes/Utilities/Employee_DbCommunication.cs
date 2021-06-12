using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloraWarehouseManagement.Classes.Utilities
{
    public class Employee_DbCommunication : DbCommunication
    {
        public Employee_DbCommunication() { }

        public static void AddEmployee(string Name, string Lastname, string EMBG, string Salary, string Start, string Address, string Position, string IdNumber, string PhoneNumber, string Bank, string BankNumber, string Description)
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
            command.Parameters.AddWithValue("PhoneNumber", PhoneNumber);
            command.Parameters.AddWithValue("Bank", Bank);
            command.Parameters.AddWithValue("BankNumber", BankNumber);
            command.Parameters.AddWithValue("Description", Description);


            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
