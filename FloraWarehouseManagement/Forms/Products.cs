using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

using FloraWarehouseManagement.Classes;
using FloraWarehouseManagement.Classes.Utilities;

namespace FloraWarehouseManagement.Forms
{
    public partial class Products : Form
    {
        private static readonly string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        SQLiteConnection connection = new SQLiteConnection(@"data source=" + projectDirectory + @"\Database\db.db");
        private Product Product;

        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            dgvProducts.Height = this.Height;
            dgvProducts.Width = this.Width;
            this.WindowState = FormWindowState.Maximized;

            Product = new Product();

            DisplayData();
        }

        private void DisplayData()
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT Шифра, Артикл, Мерка, Даночна_група, Групна_шифра, Помошна_шифра, Латиница, Потекло, Забелешка FROM Products", connection);
            connection.Open();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            dgvProducts.DataSource = dt;
            connection.Close();
        }

        private void Products_SizeChanged(object sender, EventArgs e)
        {
            pnlControls.Width = this.Width;
            dgvProducts.Height = this.Height;
            dgvProducts.Width = this.Width;
        }

        private void mtbCode_Click(object sender, EventArgs e)
        {
            AlignControls.PositionCursorInMaskedTextBox(this, mtbCode);
        }

        private void mtbGroupCode_Click(object sender, EventArgs e)
        {
            AlignControls.PositionCursorInMaskedTextBox(this, mtbGroupCode);
        }

        private void mtbHelpCode_Click(object sender, EventArgs e)
        {
            AlignControls.PositionCursorInMaskedTextBox(this, mtbHelpCode);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (mtbCode.Text == "" || tbProductName.Text == "" || cbUnit.SelectedIndex == -1 || cbTaxGroup.SelectedIndex == -1)
            {
                errorProviderCode.SetError(mtbCode, "Полето за шифра е задолжително");
                errorProviderProduct.SetError(tbProductName, "Полето за назив на артиклот е задолжително");
                errorProviderUnit.SetError(cbUnit, "Одберете единица мерка");
                errorProviderTaxGroup.SetError(cbTaxGroup, "Одберете даночна група");
            }
            else
            {
                int productExists = ProductFunctions.Instance.ProductExists(mtbCode.Text);

                if (productExists < 1)
                {

                    ProductFunctions.Instance.AddProduct(mtbCode.Text, tbProductName.Text, cbUnit.GetItemText(cbUnit.SelectedItem), cbTaxGroup.GetItemText(cbTaxGroup.SelectedItem), mtbGroupCode.Text, mtbHelpCode.Text, tbProductNameLatin.Text, tbOrigin.Text, tbDescription.Text, cbDDV.Checked == true ? 1 : 0);

                    DisplayData();

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
                    MessageBox.Show("Тој артикл веќе постои!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Products_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                Form mainMenu = new MainMenu();
                mainMenu.Closed += (s, args) => this.Close();
                mainMenu.Show();
            }
        }

        public void FilterProducts(string FilterType, string FilterProperty)
        {
            SQLiteCommand cmd = new SQLiteCommand($"SELECT Шифра, Артикл, Мерка, Даночна_група, Групна_шифра, Помошна_шифра, Латиница, Потекло, Забелешка FROM Products WHERE {FilterType} = @FilterProperty", connection);
            cmd.Parameters.AddWithValue("FilterProperty", FilterProperty);
            connection.Open();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            dgvProducts.DataSource = dt;
            connection.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            Search();
        }

        private void Search ()
        {
            if (tbSearch.Text != "")
            {
                if (rbtnCode.Checked)
                {
                    dgvProducts.DataSource = ProductFunctions.Instance.FilterProducts("Шифра", tbSearch.Text);
                }
                else if (rbtnProduct.Checked)
                {
                    dgvProducts.DataSource = ProductFunctions.Instance.FilterProducts("Артикл", tbSearch.Text);
                }
                else
                {
                    MessageBox.Show("Одберете начин на филтрирање!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {   
            ProductFunctions.Instance.EditProduct(Product.Code, mtbCode.Text, tbProductName.Text, cbUnit.GetItemText(cbUnit.SelectedItem), cbTaxGroup.GetItemText(cbTaxGroup.SelectedItem), mtbGroupCode.Text, mtbHelpCode.Text, tbProductNameLatin.Text, tbOrigin.Text, tbDescription.Text, cbDDV.Checked == true ? 1 : 0);
            Product.Code = mtbCode.Text;

            MessageBox.Show
               (
                   "Артиклот е успешно променет!",
                   "Промени",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
               );

            DisplayData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int productExists = ProductFunctions.Instance.ProductExists(mtbCode.Text);

            if (productExists == 1)
            {

                ProductFunctions.Instance.DeleteProduct(mtbCode.Text);
                DisplayData();

                MessageBox.Show
                (
                    "Артиклот е успешно избришан!",
                    "Избриши",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show("Тоа артикл не постои!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = this.dgvProducts.Rows[e.RowIndex];
                mtbCode.Text = row.Cells[0].Value.ToString();
                tbProductName.Text = row.Cells[1].Value.ToString();
                cbUnit.SelectedIndex = cbUnit.FindString(row.Cells[2].Value.ToString());
                cbTaxGroup.SelectedIndex = cbTaxGroup.FindString(row.Cells[3].Value.ToString());
                mtbGroupCode.Text = row.Cells[4].Value.ToString();
                mtbHelpCode.Text = row.Cells[5].Value.ToString();
                tbProductNameLatin.Text = row.Cells[6].Value.ToString();
                tbOrigin.Text = row.Cells[7].Value.ToString();
                tbDescription.Text = row.Cells[8].Value.ToString();

                connection.Open();

                SQLiteCommand cmd = new SQLiteCommand("SELECT Со_ДДВ from Products WHERE Шифра = @Code", connection);
                cmd.Parameters.AddWithValue("@Code", row.Cells[0].Value.ToString());

                string execution = null;
                var scalar = cmd.ExecuteScalar();

                if (scalar != null)
                {
                    execution = cmd.ExecuteScalar().ToString();
                }

                int checkedTax;

                if (execution != "" && execution != null)
                {
                    checkedTax = int.Parse(execution);
                    cbDDV.Checked = checkedTax == 1 ? true : false;
                    Product.SetProduct(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString(), row.Cells[7].Value.ToString(), row.Cells[8].Value.ToString(), checkedTax.ToString());
                }
                else
                {
                    ClearTextBoxes();
                }

                connection.Close();
            } 
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                DisplayData();
            }
        }

        private void pnlControls_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            mtbCode.Text = "";
            tbProductName.Text = "";
            cbUnit.SelectedIndex = -1;
            cbTaxGroup.SelectedIndex = -1;
            cbDDV.Checked = true;
            mtbGroupCode.Text = "";
            mtbHelpCode.Text = "";
            tbProductNameLatin.Text = "";
            tbOrigin.Text = "";
            tbDescription.Text = "";
        }

        private void mtbCode_TextChanged(object sender, EventArgs e)
        {
            errorProviderCode.SetError(mtbCode, null);
        }

        private void tbProductName_TextChanged(object sender, EventArgs e)
        {
            errorProviderProduct.SetError(tbProductName, null);
        }

        private void cbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUnit.SelectedIndex != -1)
            {
                errorProviderUnit.SetError(cbUnit, null);
            }
        }

        private void cbTaxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTaxGroup.SelectedIndex != -1)
            {
                errorProviderTaxGroup.SetError(cbTaxGroup, null);
            }
        }
    }
}
