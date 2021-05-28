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
    public class ProductFunctions
    {
        private static readonly string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        SQLiteConnection connection = new SQLiteConnection(@"data source=" + projectDirectory + @"\Database\db.db");

        public static ProductFunctions Instance { get; } = new ProductFunctions();

        public ProductFunctions() { }

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

        public void AddProduct(string Code, string Product, string Measurement, string TaxGroup, string GroupCode, string HelpCode, string Latin, string Origin, string Description)
        {
            SQLiteCommand command = new SQLiteCommand
                (
                "INSERT INTO Products" +
                "(Шифра, " +
                "Артикл, " +
                "Мерка, " +
                "Даночна_група, " +
                "Групна_шифра, " +
                "Помошна_шифра, " +
                "Латиница, " +
                "Потекло, " +
                "Забелешка) " +

                "VALUES" +
                "(@Code, " +
                "@Product, " +
                "@Measurement, " +
                "@TaxGroup, " +
                "@GroupCode, " +
                "@HelpCode, " +
                "@Latin, " +
                "@Origin, " +
                "@Description)", 
                connection);

            connection.Open();

            command.Parameters.AddWithValue("Code", Code);
            command.Parameters.AddWithValue("Product", Product);
            command.Parameters.AddWithValue("Measurement", Measurement);
            command.Parameters.AddWithValue("TaxGroup", TaxGroup);
            command.Parameters.AddWithValue("GroupCode", GroupCode);
            command.Parameters.AddWithValue("HelpCode", HelpCode);
            command.Parameters.AddWithValue("Latin", Latin);
            command.Parameters.AddWithValue("Origin", Origin);
            command.Parameters.AddWithValue("Description", Description);

            command.ExecuteNonQuery();
            connection.Close();

            DisplayData();
        }

        public int ProductExists(string Code)
        {
            int productExists;
            connection.Open();
            string checkIfExistsQuery = "SELECT EXISTS(SELECT 1 FROM Products WHERE Шифра=@Code)";
            SQLiteCommand command = new SQLiteCommand(checkIfExistsQuery, connection);
            command.Parameters.AddWithValue("Code", Code);
            productExists = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();

            return productExists;
        }

        public void DeleteProduct(string Code)
        {
            SQLiteCommand command = new SQLiteCommand("DELETE FROM Products WHERE Шифра=@Code", connection);
            connection.Open();
            command.Parameters.AddWithValue("@Code", Code);
            command.ExecuteNonQuery();
            DataTable productTable = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(productTable);
            connection.Close();
        }
    }
}
