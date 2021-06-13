using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FloraWarehouseManagement.Forms.Sales.OutgoingInvoices.Classes;

namespace FloraWarehouseManagement.Classes.Utilities
{
    class InvoiceItems_DbCommunication : DbCommunication
    {
        public static void AddInvoiceItem (int InvoiceNumber, string Code, decimal Quantity, decimal Price)
        {
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO InvoiceItems(Invoice_ID, Item_ID, Quantity, Price) VALUES(@Invoice_ID, @Item_ID, @Quantity, @Price)", connection);

            cmd.Parameters.AddWithValue("Invoice_ID", InvoiceNumber);
            cmd.Parameters.AddWithValue("Item_ID", Code);
            cmd.Parameters.AddWithValue("Quantity", Quantity);
            cmd.Parameters.AddWithValue("Price", Price);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void EditInvoiceItem (int invoiceId, string itemCode, decimal newQuantity, decimal newPrice)
        {
            SQLiteCommand cmd = new SQLiteCommand("UPDATE InvoiceItems SET Quantity=@newQuantity, Price=@newPrice WHERE Invoice_ID=@invoiceId AND Item_ID=@itemCode", connection);
            cmd.Parameters.AddWithValue("newQuantity", newQuantity);
            cmd.Parameters.AddWithValue("newPrice", newPrice);
            cmd.Parameters.AddWithValue("itemCode", itemCode);
            cmd.Parameters.AddWithValue("invoiceId", invoiceId);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void Delete (string FilterType1, int FilterProperty1, string FilterType2, string FilterProperty2)
        {
            SQLiteCommand command = new SQLiteCommand($"DELETE FROM InvoiceItems WHERE {FilterType1}=@FilterProperty1 AND {FilterType2}=@FilterProperty2", connection);
            command.Parameters.AddWithValue("FilterType1", FilterType1);
            command.Parameters.AddWithValue("FilterProperty1", FilterProperty1);
            command.Parameters.AddWithValue("FilterType2", FilterType2);
            command.Parameters.AddWithValue("FilterProperty2", FilterProperty2);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static int Exists(string FilterType1, int FilterProperty1, string FilterType2, string FilterProperty2)
        {
            int productExists;

            connection.Open();
            SQLiteCommand command = new SQLiteCommand($"SELECT EXISTS(SELECT 1 FROM InvoiceItems WHERE {FilterType1}=@FilterProperty1 AND {FilterType2}=@FilterProperty2)", connection);
            command.Parameters.AddWithValue("FilterType1", FilterType1);
            command.Parameters.AddWithValue("FilterProperty1", FilterProperty1);
            command.Parameters.AddWithValue("FilterType2", FilterType2);
            command.Parameters.AddWithValue("FilterProperty2", FilterProperty2);
            productExists = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();

            return productExists;
        }

        public static InvoiceItem GetItem(string Code)
        {
            InvoiceItem item = new InvoiceItem();
            SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM Products WHERE Шифра='{Code}'", connection);

            connection.Open();

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            item.Code = dt.Rows[0].ItemArray[1].ToString();
            item.Name = dt.Rows[0].ItemArray[2].ToString();
            item.Unit = dt.Rows[0].ItemArray[3].ToString();
            item.Tax = decimal.Parse(dt.Rows[0].ItemArray[4].ToString());

            connection.Close();

            return item;
        }
    }
}
