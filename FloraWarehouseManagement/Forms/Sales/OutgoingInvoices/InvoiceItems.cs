using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

using FloraWarehouseManagement.Forms.Sales.OutgoingInvoices.Classes;
using FloraWarehouseManagement.Classes.Utilities;
using System.IO;
using System.Data.SQLite;

namespace FloraWarehouseManagement.Forms.Sales.OutgoingInvoices
{
    public partial class InvoiceItems : Form
    {       
        private static readonly string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        SQLiteConnection connection = new SQLiteConnection(@"data source=" + projectDirectory + @"\Database\db.db");

        private InvoiceItem item;

        public InvoiceItems()
        {
            item = new InvoiceItem();
            InitializeComponent();
        }

        private void InvoiceItems_Load(object sender, EventArgs e)
        {
            DisplayData();
            tbQuantity.Text = "1";
        }

        private void InvoiceItems_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.F1)
            {
                Form articlePick = new ArticlePick();

                if (articlePick.ShowDialog() == DialogResult.Cancel)
                {
                    item = ArticlePick.item;

                    tbCode.Text = item.Code;
                    tbName.Text = item.Name;
                    tbTax.Text = item.Tax.ToString();
                    tbUnit.Text = item.Unit;
                    tbPrice.Text = item.Price.ToString("N2");
                }
            }
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbPrice.Text))
            {
                item.Price = decimal.Parse(tbPrice.Text, NumberStyles.Currency);
            }

            UpdateTextBoxes();
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            RegexFunctions.AcceptNumbersOnly(sender, e);
        }

        private void UpdateTextBoxes()
        {
            tbEdCena.Text = string.Format("{0:N2}", item.GetPriceWithoutTax());
            tbEdDDV.Text = string.Format("{0:N2}", item.GetTax());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal ItemTrueQuantity = Product_DbCommunication.GetProductQuantity(item.Code);

            if (item.Quantity <= ItemTrueQuantity)
            {
                SQLiteCommand cmd = new SQLiteCommand("INSERT INTO InvoiceItems(Invoice_ID, Item_ID, Quantity, Price) VALUES(@Invoice_ID, @Item_ID, @Quantity, @Price)", connection);

                cmd.Parameters.AddWithValue("Invoice_ID", OutgoingInvoices.InvoiceNumber);
                cmd.Parameters.AddWithValue("Item_ID", item.Code);
                cmd.Parameters.AddWithValue("Quantity", item.Quantity);
                cmd.Parameters.AddWithValue("Price", item.Price);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                DisplayData();
                ClearTextBoxes();
                Product_DbCommunication.DecreaseQuantity(ItemTrueQuantity - item.Quantity, item.Code);
            }
            else
            {
                MessageBox.Show
                (
                    "Нема доволно залиха.",
                    "Грешка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void InvoiceItems_SizeChanged(object sender, EventArgs e)
        {
            pnlControls.Width = this.Width - 50;
            dgvInvoiceItems.Height = this.Height - 50;
            dgvInvoiceItems.Width = this.Width - 50;
        }

        private void ClearTextBoxes ()
        {
            tbCode.Text = "";
            tbName.Text = "";
            tbUnit.Text = "";
            tbPrice.Text = "";
            tbEdCena.Text = "";
            tbEdDDV.Text = "";  
            tbTax.Text = "";
            tbQuantity.Text = "1";
        }

        private void DisplayData()
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT Products.Артикл, Quantity, Price FROM InvoiceItems INNER JOIN Invoices ON Invoices.InvNumber = InvoiceItems.Invoice_ID INNER JOIN Products ON Products.Шифра = InvoiceItems.Item_ID WHERE Invoice_ID = @InvID", connection);
            cmd.Parameters.AddWithValue("InvID", OutgoingInvoices.InvoiceNumber);
            connection.Open();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            dgvInvoiceItems.DataSource = dt;
            connection.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvInvoiceItems.SelectedCells.Count >= 1)
            {
                //TODO implement
            }
        }

        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            RegexFunctions.AcceptNumbersOnly(sender, e);
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            item.Quantity = decimal.Parse(tbQuantity.Text);
        }
    }
}
