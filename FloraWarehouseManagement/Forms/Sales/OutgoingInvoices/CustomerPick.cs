using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FloraWarehouseManagement.Forms.Sales.OutgoingInvoices.Classes;

namespace FloraWarehouseManagement.Forms.Sales.OutgoingInvoices
{
    public partial class CustomerPick : Form
    {
        private static readonly string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        SQLiteConnection connection = new SQLiteConnection(@"data source=" + projectDirectory + @"\Database\db.db");

        public static CustomerInfo selectecCustomerInfo;

        public CustomerPick()
        {
            selectecCustomerInfo = new CustomerInfo();
            InitializeComponent();
        }

        private void CustomerPick_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        public void DisplayData()
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT Назив, Даночен_број, ЕМБС, Жиро_сметка, Жиро_сметка_доп, Банка, Адреса, Град, Поштенски_број, Забелешка FROM Customers", connection);
            connection.Open();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            dgvCustomers.DataSource = dt;
            connection.Close();
        }

        private void dgvCustomers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string TaxNum = dgvCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM Customers WHERE Даночен_број='{TaxNum}'", connection);
                
                connection.Open();

                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);

                selectecCustomerInfo.Name = dt.Rows[0].ItemArray[1].ToString();
                selectecCustomerInfo.Address = dt.Rows[0].ItemArray[7].ToString();
                selectecCustomerInfo.City = dt.Rows[0].ItemArray[13].ToString();

                connection.Close();

                this.Close();
            }
        }
    }
}
