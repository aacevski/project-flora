using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloraWarehouseManagement.Forms.Sales.OutgoingInvoices
{
    public partial class OutgoingInvoices : Form
    {
        

        public OutgoingInvoices()
        {
            InitializeComponent();
        }

        private void OutgoingInvoices_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            mtbDate.Text = DateTime.Now.ToString("dd-MM-yy", new CultureInfo("en-GB"));
            tbValuta.Text = "60 дена";
            tbDescription.Text = "За ненавремено плаќање пресметуваме законска затезна камата. " +
                                 "Рекламации се примаат во рок од 8 дена по приемот на фактурата. " +
                                 "Во случај на спор надлежен е Основниот суд во Скопје.";
            cbDocType.SelectedIndex = 0;
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
    }
}
