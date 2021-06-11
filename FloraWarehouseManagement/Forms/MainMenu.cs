using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FloraWarehouseManagement.Classes.Utilities;
using FloraWarehouseManagement.Forms.Sales;

namespace FloraWarehouseManagement.Forms
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            DoubleBuffered = true;
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            AlignControls.CenterControl(pnlMenuButtons);
            pnlMenuButtons.BackColor = Color.FromArgb(0, 88, 44, 55);

            Information.Open(); // Loading the company info
        }

        private void MainMenu_SizeChanged(object sender, EventArgs e)
        {
            AlignControls.CenterControl(pnlMenuButtons);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form products = new Products();
            products.Closed += (s, args) => this.Close();
            products.Show();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form customers = new Customers();
            customers.Closed += (s, args) => this.Close();
            customers.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form info = new Information();
            info.Closed += (s, args) => this.Close();
            info.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            Form salesMain = new SalesMain();
            salesMain.Show();
        }

        private void btnLogins_Click(object sender, EventArgs e)
        {
            Form logins = new Logins();
            logins.Show();
        }
    }
}
