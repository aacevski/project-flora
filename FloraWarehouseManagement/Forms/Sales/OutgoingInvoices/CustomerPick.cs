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
using FloraWarehouseManagement.Classes.Utilities;

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
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Customers", connection);
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

        private void CustomerPick_SizeChanged(object sender, EventArgs e)
        {
            pnlControls.Width = this.Width - 50;
            dgvCustomers.Height = this.Height - 50;
            dgvCustomers.Width = this.Width - 50;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                DisplayData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search ()
        {
            if (tbSearch.Text != "")
            {
                if (rbtnName.Checked)
                {
                    dgvCustomers.DataSource = CustomerFunctions.Instance.FilterCustomers("Назив", tbSearch.Text);
                }

                else if (rbtnCity.Checked)
                {
                    dgvCustomers.DataSource = CustomerFunctions.Instance.FilterCustomers("Град", tbSearch.Text);
                }

                else if (rbtnTaxNum.Checked)
                {
                    dgvCustomers.DataSource = CustomerFunctions.Instance.FilterCustomers("Даночен_број", tbSearch.Text);
                }
                else
                {
                    MessageBox.Show("Одберете начин на филтрирање!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }
    }
}
