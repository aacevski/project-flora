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
        private Product Product;
        private readonly string SearchQuery = "SELECT Шифра, Артикл, Мерка, Даночна_група, Групна_шифра, Помошна_шифра, Цена, Потекло, Забелешка, Залиха FROM Products";

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

            UpdateTable();
            SetColumnsWidth();
        }

        private void Products_SizeChanged(object sender, EventArgs e)
        {
            pnlControls.Width = this.Width;
            dgvProducts.Height = this.Height;
            dgvProducts.Width = this.Width;
        }

        private void SetColumnsWidth()
        {
            dgvProducts.Columns[0].Width = 85;
            dgvProducts.Columns[1].Width = 300;
            dgvProducts.Columns[2].Width = 75;
            dgvProducts.Columns[3].Width = 75;
            dgvProducts.Columns[4].Width = 130;
            dgvProducts.Columns[5].Width = 160;
            dgvProducts.Columns[6].Width = 75;
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
                if (DbCommunication.Exists("Products", "Шифра", mtbCode.Text) < 1)
                {

                    Product_DbCommunication.AddProduct(mtbCode.Text, tbProductName.Text, cbUnit.GetItemText(cbUnit.SelectedItem), cbTaxGroup.GetItemText(cbTaxGroup.SelectedItem), mtbGroupCode.Text, mtbHelpCode.Text, tbPrice.Text, tbOrigin.Text, tbDescription.Text, cbDDV.Checked == true ? 1 : 0, tbQuantity.Text);
                    UpdateTable();

                    MessageBox.Show
                    (
                        "Артиклот е успешно додаден!", 
                        "Сними", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    errorProviderCode.Clear();
                    errorProviderProduct.Clear();
                    errorProviderUnit.Clear();
                    errorProviderTaxGroup.Clear();
                }
                else
                {
                    MessageBox.Show
                    (
                        "Тој артикл веќе постои!", 
                        "Грешка", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error
                    );
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
                    dgvProducts.DataSource = Product_DbCommunication.FilterProducts("Шифра", tbSearch.Text);
                }
                else if (rbtnProduct.Checked)
                {
                    dgvProducts.DataSource = Product_DbCommunication.FilterProducts("Артикл", tbSearch.Text);
                }
                else
                {
                    MessageBox.Show("Одберете начин на филтрирање!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {   
            Product_DbCommunication.EditProduct(Product.Code, mtbCode.Text, tbProductName.Text, cbUnit.GetItemText(cbUnit.SelectedItem), cbTaxGroup.GetItemText(cbTaxGroup.SelectedItem), mtbGroupCode.Text, mtbHelpCode.Text, tbPrice.Text, tbOrigin.Text, tbDescription.Text, cbDDV.Checked == true ? 1 : 0, tbQuantity.Text);
            Product.Code = mtbCode.Text;

            MessageBox.Show
            (
                "Артиклот е успешно променет!",
                "Промени",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
            );

            UpdateTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DbCommunication.Exists("Products", "Шифра", mtbCode.Text) == 1)
            {

                DbCommunication.Delete("Products", "Шифра", mtbCode.Text);
                UpdateTable();

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
                MessageBox.Show
                    (
                    "Тоа артикл не постои!", 
                    "Грешка", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                    );
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // If a valid row is selected       If the last row is not selected (because it's empty)
            if (e.RowIndex != -1 && e.RowIndex != dgvProducts.Rows.Count - 1)
            {
                DataGridViewRow row = this.dgvProducts.Rows[e.RowIndex];
                mtbCode.Text = row.Cells[0].Value.ToString();
                tbProductName.Text = row.Cells[1].Value.ToString();
                cbUnit.SelectedIndex = cbUnit.FindString(row.Cells[2].Value.ToString());
                cbTaxGroup.SelectedIndex = cbTaxGroup.FindString(row.Cells[3].Value.ToString());
                mtbGroupCode.Text = row.Cells[4].Value.ToString();
                mtbHelpCode.Text = row.Cells[5].Value.ToString();
                tbPrice.Text = row.Cells[6].Value.ToString();
                tbOrigin.Text = row.Cells[7].Value.ToString();
                tbDescription.Text = row.Cells[8].Value.ToString();
                tbQuantity.Text = row.Cells[9].Value.ToString();

                int checkedTax = Product_DbCommunication.CheckIfProductIsWithTax(mtbCode.Text);
                cbDDV.Checked = checkedTax == 1 ? true : false;
                Product.SetProduct(mtbCode.Text, tbProductName.Text, cbUnit.SelectedItem.ToString(), cbTaxGroup.SelectedItem.ToString(), mtbGroupCode.Text, mtbHelpCode.Text, tbPrice.Text, tbOrigin.Text, tbDescription.Text, tbQuantity.Text, checkedTax.ToString());
            }
            else
            {
                ClearTextBoxes();
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                UpdateTable();
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
            tbPrice.Text = "";
            tbOrigin.Text = "";
            tbDescription.Text = "";
            tbQuantity.Text = "";
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

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            RegexFunctions.AcceptNumbersOnly(sender, e);
        }

        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            RegexFunctions.AcceptNumbersOnly(sender, e);
        }

        private void UpdateTable()
        {
            dgvProducts.DataSource = DbCommunication.DisplayData(SearchQuery);
        }
    }
}
