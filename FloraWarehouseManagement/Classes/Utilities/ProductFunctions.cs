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
    class ProductFunctions
    {
        private static readonly string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;

        public static ProductFunctions Instance { get; } = new ProductFunctions();

        public ProductFunctions() { }

        public void AddProduct(string Code, string Product, string Measurement, string TaxGroup, string GroupCode, string HelpCode, string Latin, string Origin, string Description)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            SQLiteConnection connection = new SQLiteConnection(@"data source=" + projectDirectory + @"\Database\db.db");
            string addProductQuery = "INSERT INTO Products(Code, Product, Measurement, TaxGroup, GroupCode, HelpCode, Latin, Origin, Description) VALUES(@Code, @Product, @Measurement, @TaxGroup, @GroupCode, @HelpCode, @Latin, @Origin, @Description)";
            SQLiteCommand addProductCommand = new SQLiteCommand(addProductQuery, connection);
            addProductCommand.Parameters.AddWithValue("Code", Code);
            addProductCommand.Parameters.AddWithValue("Product", Product);
            addProductCommand.Parameters.AddWithValue("Measurement", Measurement);
            addProductCommand.Parameters.AddWithValue("TaxGroup", TaxGroup);
            addProductCommand.Parameters.AddWithValue("GroupCode", GroupCode);
            addProductCommand.Parameters.AddWithValue("HelpCode", HelpCode);
            addProductCommand.Parameters.AddWithValue("Latin", Latin);
            addProductCommand.Parameters.AddWithValue("Origin", Origin);
            addProductCommand.Parameters.AddWithValue("Description", Description);
            DataTable productTable = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(addProductCommand);
            adapter.Fill(productTable);
        }

        public int ProductExists(string Code)
        {
            int productExists;
            SQLiteConnection connection = new SQLiteConnection(@"data source=" + projectDirectory + @"\Database\db.db");
            connection.Open();
            string checkIfExistsQuery = "SELECT EXISTS(SELECT 1 FROM Products WHERE Code=@Code)";
            SQLiteCommand command = new SQLiteCommand(checkIfExistsQuery, connection);
            command.Parameters.AddWithValue("Code", Code);
            productExists = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return productExists;
        }
    }
}
