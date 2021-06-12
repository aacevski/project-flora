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
    public class Product_DbCommunication : DbCommunication
    {
        public Product_DbCommunication() { }

        public static void AddProduct (string Code, string Product, string Measurement, string TaxGroup, string GroupCode, string HelpCode, string Price, string Origin, string Description, int TaxBool, string Quantity)
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
        }

        public static void EditProduct (string OldCode, string Code, string Product, string Measurement, string TaxGroup, string GroupCode, string HelpCode, string Price, string Origin, string Description, int TaxBool, string Quantity)
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
        }

        public static DataTable FilterProducts(string FilterType, string FilterProperty) 
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

        public static int CheckIfProductIsWithTax (string code)
        {
            SQLiteCommand cmd = new SQLiteCommand($"SELECT Со_ДДВ from Products WHERE Шифра = {code}", connection);
            int result = -1;

            connection.Open();
            object scalar = cmd.ExecuteScalar();

            if (scalar != null && (!string.IsNullOrEmpty(scalar.ToString())))
            {
                result = int.Parse(scalar.ToString());
            }
            connection.Close();

            return result;
        }

        public static decimal GetProductQuantity (string code)
        {
            decimal quantity = -1.00m;

            SQLiteCommand cmd = new SQLiteCommand("SELECT Залиха from Products WHERE Шифра = @code", connection);
            cmd.Parameters.AddWithValue("code", code);

            connection.Open();
            object scalar = cmd.ExecuteScalar();

            if (scalar != null && (!string.IsNullOrEmpty(scalar.ToString())))
            {
                quantity = decimal.Parse(scalar.ToString());
            }
            connection.Close();

            return quantity;
        }

        public static void DecreaseQuantity(decimal num, string code)
        {
            SQLiteCommand cmd = new SQLiteCommand("UPDATE Products SET Залиха=@Quantity WHERE Шифра=@code", connection);
            cmd.Parameters.AddWithValue("Quantity", num);
            cmd.Parameters.AddWithValue("code", code);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

    }
}
