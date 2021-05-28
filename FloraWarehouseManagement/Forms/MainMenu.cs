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

namespace FloraWarehouseManagement.Forms
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            AlignControls.CenterControl(pnlMenuButtons);
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
    }
}
