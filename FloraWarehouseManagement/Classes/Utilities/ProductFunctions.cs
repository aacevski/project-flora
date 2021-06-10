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
            SQLiteCommand cmd = new SQLiteCommand("SELECT * from Products", connection);
            connection.Open();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            connection.Close();
        }

        public void AddProduct(string Code, string Product, string Measurement, string TaxGroup, string GroupCode, string HelpCode, string Price, string Origin, string Description, int TaxBool, string Quantity)
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
                "Цена, " +
                "Потекло, " +
                "Забелешка, " +
                "Со_ДДВ, " +
                "Залиха) " +

                "VALUES" +
                "(@Code, " +
                "@Product, " +
                "@Measurement, " +
                "@TaxGroup, " +
                "@GroupCode, " +
                "@HelpCode, " +
                "@Price, " +
                "@Origin, " +
                "@Description, " +
                "@TaxBool, " +
                "@Quantity)", 
                connection
                );

            connection.Open();

            command.Parameters.AddWithValue("Code", Code);
            command.Parameters.AddWithValue("Product", Product);
            command.Parameters.AddWithValue("Measurement", Measurement);
            command.Parameters.AddWithValue("TaxGroup", TaxGroup);
            command.Parameters.AddWithValue("GroupCode", GroupCode);
            command.Parameters.AddWithValue("HelpCode", HelpCode);
            command.Parameters.AddWithValue("Price", Price);
            command.Parameters.AddWithValue("Origin", Origin);
            command.Parameters.AddWithValue("Description", Description);
            command.Parameters.AddWithValue("TaxBool", TaxBool);
            command.Parameters.AddWithValue("Quantity", Quantity);

            command.ExecuteNonQuery();
            connection.Close();

            DisplayData();
        }

        public void EditProduct(string OldCode, string Code, string Product, string Measurement, string TaxGroup, string GroupCode, string HelpCode, string Price, string Origin, string Description, int TaxBool, string Quantity)
        {
            SQLiteCommand command = new SQLiteCommand
                (
                "UPDATE Products SET " +
                "Шифра = @Code, " +
                "Артикл = @Product, " +
                "Мерка = @Measurement, " +
                "Даночна_група = @TaxGroup, " +
                "Групна_шифра = @GroupCode, " +
                "Помошна_шифра = @HelpCode, " +
                "Цена = @Price, " +
                "Потекло = @Origin, " +
                "Забелешка = @Description, " +
                "Со_ДДВ = @TaxBool, " +
                "Залиха = @Quantity " +
                "WHERE Шифра = @OldCode",
                connection
                );

            connection.Open();

            command.Parameters.AddWithValue("@Code", Code);
            command.Parameters.AddWithValue("@Product", Product);
            command.Parameters.AddWithValue("@Measurement", Measurement);
            command.Parameters.AddWithValue("@TaxGroup", TaxGroup);
            command.Parameters.AddWithValue("@GroupCode", GroupCode);
            command.Parameters.AddWithValue("@HelpCode", HelpCode);
            command.Parameters.AddWithValue("@Price", Price);
            command.Parameters.AddWithValue("@Origin", Origin);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@TaxBool", TaxBool);
            command.Parameters.AddWithValue("@Quantity", Quantity);
            command.Parameters.AddWithValue("@OldCode", OldCode);

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


        public DataTable FilterProducts(string FilterType, string FilterProperty) 
        {
            SQLiteCommand cmd = new SQLiteCommand($"SELECT Шифра, Артикл, Мерка, Даночна_група, Групна_шифра, Помошна_шифра, Цена, Потекло, Забелешка, Залиха FROM Products WHERE {FilterType} = @FilterProperty", connection);
            cmd.Parameters.AddWithValue("FilterProperty", FilterProperty);
            
            connection.Open();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            connection.Close();

            return dt;
        }

        public void AcceptNumbersOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

    }
}
