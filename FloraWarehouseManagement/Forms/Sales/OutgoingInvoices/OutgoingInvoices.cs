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
        private static readonly string SearchQuery = $"SELECT Customers.Назив, Date AS Дата, PRINTF('%05d/%d',InvNumber, {DateTime.Now.Year}) AS 'Број на фактура', Valuta AS Валута, TypeOfDocument AS 'Вид на документ', Description AS Забелешка, Iznos AS Износ, DDV AS ДДВ, Vkupno AS Вкупно FROM Invoices INNER JOIN Customers ON Customers.ID = Invoices.Customer_ID";

        public OutgoingInvoices()
        {
            InitializeComponent();
        }

        private void OutgoingInvoices_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            selectedCustomer = new CustomerInfo();

            InitDefaultSettings();
            InvoiceNumber = Invoice_DbCommunication.GetInvoiceNumber();
            InvoiceCounter = InvoiceNumber;
            SetInvoiceNumberTextBox();

            dgvInvoices.DataSource = DbCommunication.DisplayData(SearchQuery);
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
                if (invoiceItems.ShowDialog() == DialogResult.Cancel)
                {
                    SetPriceSumTextBoxes();
                    Invoice_DbCommunication.SetPricesForInvoice(decimal.Parse(tbPriceWithoutTax.Text), decimal.Parse(tbTax.Text), decimal.Parse(tbTotalPrice.Text), InvoiceNumber);
                    dgvInvoices.DataSource = DbCommunication.DisplayData(SearchQuery);
                }       
            }
            else
            {
                MessageBox.Show("Одберете фактура.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (tbCustomer.Text != "")
            {
                InvoiceNumber = Invoice_DbCommunication.GetInvoiceNumber();
                InvoiceCounter++;

                Invoice_DbCommunication.AddInvoice(Customer_DbCommunication.GetCustomerDBID(CustomerPick.selectecCustomerInfo.Name), InvoiceCounter, mtbDate.Text, tbValuta.Text, cbDocType.SelectedItem.ToString(), tbDescription.Text);

                dgvInvoices.DataSource = DbCommunication.DisplayData(SearchQuery);

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

        private void ResetBoxes ()
        {
            tbCustomer.Text = "";
            tbPriceWithoutTax.Text = "";
            tbTax.Text = "";
            tbTotalPrice.Text = "";
            InitDefaultSettings();
        }

        private void dgvInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != dgvInvoices.Rows.Count - 1 && e.RowIndex != -1)
            {
                InvoiceNumber = int.Parse(dgvInvoices.Rows[e.RowIndex].Cells[2].Value.ToString().Substring(0,5));
                string customerName = dgvInvoices.Rows[e.RowIndex].Cells[0].Value.ToString();

                DataTable dt = Invoice_DbCommunication.DisplayCustomerData(customerName);

                selectedCustomer.Name = dt.Rows[0].ItemArray[0].ToString();
                selectedCustomer.Address = dt.Rows[0].ItemArray[1].ToString();
                selectedCustomer.City = dt.Rows[0].ItemArray[2].ToString();

                tbCustomer.Text = selectedCustomer.Name;

                SetInvoiceNumberTextBox();
                SetPriceSumTextBoxes();
                dgvInvoices.DataSource = DbCommunication.DisplayData(SearchQuery);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvInvoices.SelectedCells.Count == 1)
            {
                Invoice invoiceForPrinting = new Invoice(InvoiceNumber, selectedCustomer, tbValuta.Text, tbDescription.Text, mtbDate.Text, cbDocType.SelectedItem.ToString());
                invoiceForPrinting.InvoiceItems = Invoice_DbCommunication.GetInvoiceItemsForInvoice(InvoiceNumber);

                Form print = new PrintForm(invoiceForPrinting);
                print.ShowDialog();
            }
        }



        private void SetPriceSumTextBoxes()
        {
            List<InvoiceItem> items = Invoice_DbCommunication.GetInvoiceItemsForInvoice(InvoiceNumber);
            decimal totalPriceWithTax = 0.0m;
            decimal totalPriceWithoutTax = 0.0m;
            decimal totalTax = 0.0m;

            foreach (InvoiceItem i in items)
            {
                totalPriceWithTax += i.GetTotalPrice();
                totalPriceWithoutTax += i.GetTotalPriceWithoutTax();
                totalTax += i.GetTax();
            }

            tbTotalPrice.Text = totalPriceWithTax.ToString("N2");
            tbPriceWithoutTax.Text = totalPriceWithoutTax.ToString("N2");
            tbTax.Text = totalTax.ToString("N2");
        }

        private void pnlControls_Click(object sender, EventArgs e)
        {
            ResetBoxes();
            SetInvoiceNumberTextBox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((DbCommunication.Exists("Invoices", "InvNumber", InvoiceNumber.ToString()) == 1) && (InvoiceNumber == InvoiceCounter))
            {

                DbCommunication.Delete("Invoices", "InvNumber", InvoiceNumber.ToString());
                DbCommunication.Delete("InvoiceItems", "Invoice_ID", InvoiceNumber.ToString());

                dgvInvoices.DataSource = DbCommunication.DisplayData(SearchQuery);
                InvoiceNumber = Invoice_DbCommunication.GetInvoiceNumber();
                InvoiceCounter = InvoiceNumber;

                MessageBox.Show
                (
                    "Фактурата е успешно избришана!",
                    "Избриши",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show
                    (
                    "Таа фактура не може да се избрише!",
                    "Грешка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
