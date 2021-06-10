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

namespace FloraWarehouseManagement.Forms.Sales.OutgoingInvoices
{
    public partial class OutgoingInvoices : Form
    {

        private static readonly string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        SQLiteConnection connection = new SQLiteConnection(@"data source=" + projectDirectory + @"\Database\db.db");

        public static int InvoiceNumber;

        public OutgoingInvoices()
        {
            InitializeComponent();
        }

        private void OutgoingInvoices_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            InitDefaultSettings();
            GetInvoiceNumber();
            SetInvoiceNumberTextBox();

            DisplayData();
        }

        private void InitDefaultSettings()
        {
            mtbDate.Text = DateTime.Now.ToString("dd-MM-yy", new CultureInfo("en-DE"));
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
            Form invoiceItems = new InvoiceItems();
            invoiceItems.Show();
        }

        private void tbDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
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
            // Kako da go prevzemam kupuvacot so toj ID sto e vo Invoices, i da gi dobijam site informacii za nego (moze da gi stavam vo
            // klasa )
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Invoices", connection);
            connection.Open();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            dgvInvoices.DataSource = dt;
            connection.Close();
        }

        public void TestFunc()
        {
            string id = GetCustomerID();

            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand($"SELECT Назив FROM Customers INNER JOIN Invoices ON ({id} = Customers.ID)", connection);
            
            MessageBox.Show(cmd.ExecuteScalar().ToString());
            connection.Close();
        }

        public string GetCustomerID ()
        {
            string id;

            connection.Open();
            
            SQLiteCommand cmd = new SQLiteCommand("SELECT ID FROM Customers WHERE Назив = @Name", connection);
            cmd.Parameters.AddWithValue("Name", CustomerPick.selectecCustomerInfo.Name);
            id = cmd.ExecuteScalar().ToString();

            connection.Close();

            return id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
    }
}
