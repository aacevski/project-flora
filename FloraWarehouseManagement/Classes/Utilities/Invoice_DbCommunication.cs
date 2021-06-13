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
    public class Invoice_DbCommunication : DbCommunication
    { 
        public Invoice_DbCommunication () { }

        public static void AddInvoice (int Customer_ID, int InvoiceNumber, string Date, string Valuta, string DocType, string Description)
        {
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Invoices(Customer_ID, Date, InvNumber, Valuta, TypeOfDocument, Description) VALUES(@Customer_ID, @Date, @InvoiceNumber, @Valuta, @TypeOfDocument, @Description)", connection);
            cmd.Parameters.AddWithValue("Customer_ID", Customer_ID);
            cmd.Parameters.AddWithValue("InvoiceNumber", InvoiceNumber);
            cmd.Parameters.AddWithValue("Date", Date);
            cmd.Parameters.AddWithValue("Valuta", Valuta);
            cmd.Parameters.AddWithValue("TypeOfDocument", DocType);
            cmd.Parameters.AddWithValue("Description", Description);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void FilterInvoices ()
        {
            // TODO: in the next version we'll implement a search bar for outgoing invoices 
        }

        public static int GetInvoiceNumber()
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT InvNumber FROM Invoices ORDER BY ID DESC LIMIT 1", connection);
            int result = -1;

            connection.Open();
            
            object scalar = cmd.ExecuteScalar();

            if (scalar != null && (!string.IsNullOrEmpty(scalar.ToString())))
            {
                result = int.Parse(scalar.ToString());
            }
            else
            {
                result = 0;
            }

            connection.Close();

            return result;
        }

        public static DataTable DisplayCustomerData (string customerName)
        {
            DataTable dt = new DataTable();

            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand("SELECT Назив, Адреса, Град FROM Customers WHERE Назив = @Name", connection);
            cmd.Parameters.AddWithValue("Name", customerName);      
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            connection.Close();

            return dt;
        }

        public static List<InvoiceItem> GetInvoiceItemsForInvoice(int InvNum)
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT Products.Шифра, Products.Артикл, Products.Мерка, Products.Даночна_група, Quantity, Price FROM InvoiceItems INNER JOIN Products ON Products.Шифра = InvoiceItems.Item_ID WHERE Invoice_ID = @InvoiceNumber", connection);
            cmd.Parameters.AddWithValue("InvoiceNumber", InvNum);
            connection.Open();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            connection.Close();

            List<InvoiceItem> items = new List<InvoiceItem>();

            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                items.Add(new InvoiceItem(dt.Rows[i].ItemArray[0].ToString(), dt.Rows[i].ItemArray[1].ToString(), dt.Rows[i].ItemArray[2].ToString(), decimal.Parse(dt.Rows[i].ItemArray[3].ToString()), decimal.Parse(dt.Rows[i].ItemArray[4].ToString()), decimal.Parse(dt.Rows[i].ItemArray[5].ToString())));
            }

            return items;
        }

        public static void SetPricesForInvoice(decimal totalPriceWithoutTax, decimal totalTax, decimal totalPriceWithTax, int InvoiceNumber)
        {

            SQLiteCommand cmd = new SQLiteCommand("UPDATE Invoices SET Iznos=@TotalPriceWithoutTax, DDV=@Tax, Vkupno=@TotalPrice WHERE InvNumber=@InvoiceNumber", connection);
            cmd.Parameters.AddWithValue("TotalPriceWithoutTax", totalPriceWithoutTax);
            cmd.Parameters.AddWithValue("Tax", totalTax);
            cmd.Parameters.AddWithValue("TotalPrice", totalPriceWithTax);
            cmd.Parameters.AddWithValue("InvoiceNumber", InvoiceNumber);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
