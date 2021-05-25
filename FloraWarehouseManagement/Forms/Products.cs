using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

using FloraWarehouseManagement.Classes.Utilities;
using System.IO;

namespace FloraWarehouseManagement.Forms
{
    public partial class Products : Form
    {
        private static readonly string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;

        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            dgvProducts.Height = this.Height;
            dgvProducts.Width = this.Width;


            this.WindowState = FormWindowState.Maximized;
            SQLiteConnection con = new SQLiteConnection(@"data source=" + projectDirectory + @"\Database\db.db");

            string query = "SELECT Code, Product, Measurement, TaxGroup, GroupCode, HelpCode, Latin, Origin, Description FROM Products";
            SQLiteCommand cmd = new SQLiteCommand(query, con);

            DataTable dt = new DataTable();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dgvProducts.DataSource = dt;
        }

        private void Products_SizeChanged(object sender, EventArgs e)
        {
            pnlControls.Width = this.Width;

            dgvProducts.Height = this.Height;
            dgvProducts.Width = this.Width;

        }

        private void mtbCode_Click(object sender, EventArgs e)
        {
            PositionCursorInMaskedTextBox(mtbCode);
        }

        private void mtbGroupCode_Click(object sender, EventArgs e)
        {
            PositionCursorInMaskedTextBox(mtbGroupCode);
        }

        private void mtbHelpCode_Click(object sender, EventArgs e)
        {
            PositionCursorInMaskedTextBox(mtbHelpCode);
        }

        private void PositionCursorInMaskedTextBox(MaskedTextBox mtb)
        {
            if (mtb == null) return;

            int pos = mtb.SelectionStart;

            if (pos > mtb.Text.Length)
                this.BeginInvoke((MethodInvoker)delegate () { mtb.Select(mtb.Text.Length, 0); });
        }

        private void mtbCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show(mtbCode.Text);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int productExists = ProductFunctions.Instance.ProductExists(mtbCode.Text);

            if (productExists < 1)
            {

                ProductFunctions.Instance.AddProduct(mtbCode.Text, tbProductName.Text, cbUnit.GetItemText(cbUnit.SelectedItem), cbTaxGroup.GetItemText(cbTaxGroup.SelectedItem), mtbGroupCode.Text, mtbHelpCode.Text, tbProductNameLatin.Text, tbOrigin.Text, tbDescription.Text);

                SQLiteConnection con = new SQLiteConnection(@"data source=" + projectDirectory + @"\Database\db.db");

                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                string sqlSelectAll = "SELECT Code, Product, Measurement, TaxGroup, GroupCode, HelpCode, Latin, Origin, Description FROM Products";
                adapter.SelectCommand = new SQLiteCommand(sqlSelectAll, con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;
                dgvProducts.DataSource = bSource;

                MessageBox.Show
                (
                    "Артиклот е успешно додаден!",
                    "Сними",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show("Тоа артикл веќе постои!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Products_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                Form mainMenu = new Forms.MainMenu();
                mainMenu.Closed += (s, args) => this.Close();
                mainMenu.Show();
            }
        }
    }
}
