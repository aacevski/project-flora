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
    public partial class ArticlePick : Form
    {
        private static readonly string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        SQLiteConnection connection = new SQLiteConnection(@"data source=" + projectDirectory + @"\Database\db.db");

        public static InvoiceItem item;
        public ArticlePick()
        {
            item = new InvoiceItem();
            InitializeComponent();
        }

        private void ArticlePick_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT Шифра, Артикл, Мерка, Даночна_група, Групна_шифра, Помошна_шифра, Латиница, Потекло, Забелешка FROM Products", connection);
            connection.Open();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            dgvProducts.DataSource = dt;
            connection.Close();
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string Code = dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM Products WHERE Шифра='{Code}'", connection);

                connection.Open();

                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);
                MessageBox.Show(Code);
                item.Code = dt.Rows[0].ItemArray[1].ToString();
                item.Name = dt.Rows[0].ItemArray[2].ToString();
                item.Unit = dt.Rows[0].ItemArray[3].ToString();
                item.Tax = decimal.Parse(dt.Rows[0].ItemArray[4].ToString());
                
                connection.Close();

                this.Close();
            }
        }

        private void ArticlePick_SizeChanged(object sender, EventArgs e)
        {
            pnlControls.Width = this.Width - 50;
            dgvProducts.Height = this.Height - 50;
            dgvProducts.Width = this.Width - 50;
        }
    }
}
