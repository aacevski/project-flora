using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FloraWarehouseManagement.Forms.Sales.OutgoingInvoices.Classes;
using FloraWarehouseManagement.Forms.Sales.OutgoingInvoices.CrystalReport;

namespace FloraWarehouseManagement.Forms.Sales.OutgoingInvoices
{
    public partial class OutgoingInvoices : Form
    {

        private static readonly string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        static SQLiteConnection connection = new SQLiteConnection(@"data source=" + projectDirectory + @"\Database\db.db");

        public static int InvoiceNumber;
        private CustomerInfo selectedCustomer;

        public OutgoingInvoices()
        {
            InitializeComponent();
        }

        private void OutgoingInvoices_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            selectedCustomer = new CustomerInfo();

            InitDefaultSettings();
            GetInvoiceNumber();
            SetInvoiceNumberTextBox();

            DisplayData();
        }

        private void InitDefaultSettings()
        {
            mtbDate.Text = DateTime.Now.ToString("dd.MM.yy", CultureInfo.GetCultureInfo("en-DE"));
            tbValuta.Text = "60 дена";
            tbDescription.Text = "За ненавремено плаќање пресметуваме законска затезна камата. " +
                                 "Рекламации се примаат во рок од 8 дена по приемот на фактурата. " +
                                 "Во случај на спор надлежен е Основниот суд во Скопје.";
            cbDocType.SelectedIndex = 0;
        }

        private void SetInvoiceNumberTextBox ()
        {
            mtbInvoiceNum.Text = string.Format("{0:00000}/{1}", InvoiceNumber, DateTime.Now.Year);
        }

        private void OutgoingInvoices_SizeChanged(object sender, EventArgs e)
        {
            pnlControls.Width = this.Width;
            dgvInvoices.Height = this.Height;
            dgvInvoices.Width = this.Width;
        }

        private void OutgoingInvoices_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.F1)
            {
                Form customerPick = new CustomerPick();
                
                if (customerPick.ShowDialog() == DialogResult.Cancel)
                {
                    tbCustomer.Text = CustomerPick.selectecCustomerInfo.Name;
                }
            }
        }

        private void btnInvoiceItems_Click(object sender, EventArgs e)
        {
            if (dgvInvoices.SelectedCells.Count == 1)
            {
                Form invoiceItems = new InvoiceItems();
                invoiceItems.Show();
            }
            else
            {
                MessageBox.Show("Одберете фактура.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //TODO: dodadi gi ostanatite parametri od Invoices
            GetInvoiceNumber();
            InvoiceNumber++;
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Invoices(Customer_ID, Date, InvNumber) VALUES(null, @Date, @InvoiceNumber)", connection);
            cmd.Parameters.AddWithValue("InvoiceNumber", InvoiceNumber);
            cmd.Parameters.AddWithValue("Date", mtbDate.Text);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            ResetBoxes();
            SetInvoiceNumberTextBox();
        }

        public static int GetInvoiceDBID ()
        {
            int id;

            SQLiteCommand cmd = new SQLiteCommand($"SELECT ID FROM Invoices WHERE InvNumber = {InvoiceNumber}", connection);

            connection.Open();
            id = int.Parse(cmd.ExecuteScalar().ToString());
            connection.Close();

            return id;
        }

        private void ResetBoxes ()
        {
            tbCustomer.Text = "";
            tbPriceWithoutTax.Text = "";
            tbTax.Text = "";
            tbTotalPrice.Text = "";
            InitDefaultSettings();
        }

        private void GetInvoiceNumber ()
        {
            connection.Open();

            SQLiteCommand cmd = new SQLiteCommand("SELECT InvNumber FROM Invoices ORDER BY ID DESC LIMIT 1", connection);
            InvoiceNumber = int.Parse(cmd.ExecuteScalar().ToString());

            connection.Close();
        }

        public void DisplayData()
        {
            SQLiteCommand cmd = new SQLiteCommand($"SELECT Customers.Назив, Date AS Дата, PRINTF('%05d/%d',InvNumber, {DateTime.Now.Year}) AS 'Број на фактура', Valuta AS Валута, TypeOfDocument AS 'Вид на документ', Description AS Забелешка, Iznos AS Износ, DDV AS ДДВ, Vkupno AS Вкупно FROM Invoices INNER JOIN Customers ON Customers.ID = Invoices.Customer_ID", connection);
            connection.Open();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            dgvInvoices.DataSource = dt;
            connection.Close();
        }

        // MOZE DA NE TREBA
/*        public string GetCustomerID ()
        {
            string id;

            connection.Open();
            
            SQLiteCommand cmd = new SQLiteCommand("SELECT ID FROM Customers WHERE Назив = @Name", connection);
            cmd.Parameters.AddWithValue("Name", CustomerPick.selectecCustomerInfo.Name);
            id = cmd.ExecuteScalar().ToString();

            connection.Close();

            return id;
        }*/

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != dgvInvoices.Rows.Count - 1 && e.RowIndex != -1)
            {
                InvoiceNumber = int.Parse(dgvInvoices.Rows[e.RowIndex].Cells[2].Value.ToString().Substring(0,5));
                string customerName = dgvInvoices.Rows[e.RowIndex].Cells[0].Value.ToString();

                connection.Open();

                SQLiteCommand cmd = new SQLiteCommand("SELECT Назив, Адреса, Град FROM Customers WHERE Назив = @Name", connection);
                cmd.Parameters.AddWithValue("Name", customerName);
                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);

                connection.Close();

                selectedCustomer.Name = dt.Rows[0].ItemArray[0].ToString();
                selectedCustomer.Address = dt.Rows[0].ItemArray[1].ToString();
                selectedCustomer.City = dt.Rows[0].ItemArray[2].ToString();

                SetInvoiceNumberTextBox();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvInvoices.SelectedCells.Count == 1)
            {
                Invoice invoiceForPrinting = new Invoice(InvoiceNumber, selectedCustomer, tbValuta.Text, tbDescription.Text, mtbDate.Text, cbDocType.SelectedItem.ToString());
                invoiceForPrinting.InvoiceItems = GetInvoiceItemsForInvoice();

                Form print = new PrintForm(invoiceForPrinting);
                print.ShowDialog();
            }
        }

        private List<InvoiceItem> GetInvoiceItemsForInvoice()
        {
            SQLiteCommand cmd = new SQLiteCommand($"SELECT Products.Шифра, Products.Артикл, Products.Мерка, Products.Даночна_група, Quantity, Price FROM InvoiceItems INNER JOIN Products ON Products.Шифра = InvoiceItems.Item_ID WHERE Invoice_ID = {InvoiceNumber}", connection);
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
    }
}
