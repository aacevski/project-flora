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
using FloraWarehouseManagement.Classes.Utilities;

namespace FloraWarehouseManagement.Forms.Sales.OutgoingInvoices
{
    public partial class OutgoingInvoices : Form
    {

        private static readonly string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        static SQLiteConnection connection = new SQLiteConnection(@"data source=" + projectDirectory + @"\Database\db.db");

        public static int InvoiceNumber;
        public static int InvoiceCounter;
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
            tbInvCounter.Text = (InvoiceCounter + 1).ToString();
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
            if (tbCustomer.Text != "")
            {
                GetInvoiceNumber();
                InvoiceCounter++;
                SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Invoices(Customer_ID, Date, InvNumber, Valuta, TypeOfDocument, Description) VALUES(@Customer_ID, @Date, @InvoiceNumber, @Valuta, @TypeOfDocument, @Description)", connection);
                cmd.Parameters.AddWithValue("Customer_ID", Customer_DbCommunication.GetCustomerDBID(CustomerPick.selectecCustomerInfo.Name));
                cmd.Parameters.AddWithValue("InvoiceNumber", InvoiceCounter);
                cmd.Parameters.AddWithValue("Date", mtbDate.Text);
                cmd.Parameters.AddWithValue("Valuta", tbValuta.Text);
                cmd.Parameters.AddWithValue("TypeOfDocument", cbDocType.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("Description", tbDescription.Text);


                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();   

                DisplayData();

                ResetBoxes();
                SetInvoiceNumberTextBox();
            }
            else
            {
                MessageBox.Show
                (
                    "Одберете купувач (F1).",
                    "Грешка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
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
            var num = cmd.ExecuteScalar();

            object scalar = cmd.ExecuteScalar();

            if (scalar != null && (!string.IsNullOrEmpty(scalar.ToString())))
            {
                InvoiceCounter = int.Parse(scalar.ToString());
            }
           else
            {
                InvoiceCounter = 0;
            }

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

                tbCustomer.Text = selectedCustomer.Name;

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

        private void pnlControls_Click(object sender, EventArgs e)
        {
            ResetBoxes();
            SetInvoiceNumberTextBox();
        }
    }
}
