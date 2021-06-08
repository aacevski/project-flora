using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloraWarehouseManagement.Forms.Sales
{
    public partial class SalesMain : Form
    {
        public SalesMain()
        {
            InitializeComponent();
        }

        private void SalesMain_Load(object sender, EventArgs e)
        {

        }

        private void btnOutgoingInvoices_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form outgoingInvoices = new OutgoingInvoices.OutgoingInvoices();
            outgoingInvoices.Closed += (s, args) => this.Close();
            outgoingInvoices.Show();
        }

        private void btnPaymentOperations_Click(object sender, EventArgs e)
        {

        }

    }
}
