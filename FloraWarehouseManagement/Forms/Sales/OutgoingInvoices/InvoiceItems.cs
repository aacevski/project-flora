using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

using FloraWarehouseManagement.Forms.Sales.OutgoingInvoices.Classes;
using FloraWarehouseManagement.Classes.Utilities;
using System.IO;
using System.Data.SQLite;

namespace FloraWarehouseManagement.Forms.Sales.OutgoingInvoices
{
    public partial class InvoiceItems : Form
    {       
        private InvoiceItem item;
        private int selectedItemID;
        private readonly string SearchQuery = $"SELECT Invoice_ID AS Број_на_фактура, Products.Шифра, Products.Артикл, Quantity AS Количина, Price AS Цена FROM InvoiceItems INNER JOIN Invoices ON Invoices.InvNumber = InvoiceItems.Invoice_ID INNER JOIN Products ON Products.Шифра = InvoiceItems.Item_ID WHERE Invoice_ID = {OutgoingInvoices.InvoiceNumber}";

        public InvoiceItems()
        {
            item = new InvoiceItem();
            InitializeComponent();
        }

        private void InvoiceItems_Load(object sender, EventArgs e)
        {
            dgvInvoiceItems.DataSource = DbCommunication.DisplayData(SearchQuery);
            tbQuantity.Text = "1";
        }

        private void InvoiceItems_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.F1)
            {
                Form articlePick = new ArticlePick();

                if (articlePick.ShowDialog() == DialogResult.Cancel)
                {
                    item = ArticlePick.item;

                    tbCode.Text = item.Code;
                    tbName.Text = item.Name;
                    tbTax.Text = item.Tax.ToString();
                    tbUnit.Text = item.Unit;
                    tbPrice.Text = item.Price.ToString("N2");
                }
            }
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbPrice.Text))
            {
                item.Price = decimal.Parse(tbPrice.Text, NumberStyles.Currency);
            }

            UpdateTextBoxes();
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            RegexFunctions.AcceptNumbersOnly(sender, e);
        }

        private void UpdateTextBoxes()
        {
            tbEdCena.Text = string.Format("{0:N2}", item.GetPriceWithoutTax());
            tbEdDDV.Text = string.Format("{0:N2}", item.GetTax());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal ItemTrueQuantity = Product_DbCommunication.GetProductQuantity(item.Code);

            if (item.Quantity <= ItemTrueQuantity)
            {
                if (!DuplicateItem(item.Code))
                {
                    InvoiceItems_DbCommunication.AddInvoiceItem(OutgoingInvoices.InvoiceNumber, item.Code, item.Quantity, item.Price);

                    dgvInvoiceItems.DataSource = DbCommunication.DisplayData(SearchQuery);
                    ClearTextBoxes();
                    Product_DbCommunication.DecreaseQuantity(ItemTrueQuantity - item.Quantity, item.Code);
                }
                else
                {
                    MessageBox.Show
                    (
                        "Ставката веќе постои.",
                        "Грешка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            else
            {
                MessageBox.Show
                (
                    "Нема доволно залиха.",
                    "Грешка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private bool DuplicateItem(string Code)
        {

            foreach (DataGridViewRow dr in dgvInvoiceItems.Rows)
            {
                if (Code == dr.Cells[1].Value.ToString())
                {
                    return true;
                }
            }

            return false;
        }

        private void InvoiceItems_SizeChanged(object sender, EventArgs e)
        {
            pnlControls.Width = this.Width - 50;
            dgvInvoiceItems.Height = this.Height - 50;
            dgvInvoiceItems.Width = this.Width - 50;
        }

        private void ClearTextBoxes ()
        {
            tbCode.Text = "";
            tbName.Text = "";
            tbUnit.Text = "";
            tbPrice.Text = "";
            tbEdCena.Text = "";
            tbEdDDV.Text = "";  
            tbTax.Text = "";
            tbQuantity.Text = "1";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvInvoiceItems.SelectedCells.Count == 1)
            {
                if (InvoiceItems_DbCommunication.Exists("Invoice_ID", selectedItemID, "Item_ID", tbCode.Text) == 1)
                {
                    InvoiceItems_DbCommunication.Delete("Invoice_ID", selectedItemID, "Item_ID", tbCode.Text);
                    dgvInvoiceItems.DataSource = DbCommunication.DisplayData(SearchQuery);

                    ClearTextBoxes();
                }

            }
        }

        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            RegexFunctions.AcceptNumbersOnly(sender, e);
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            item.Quantity = decimal.Parse(tbQuantity.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvInvoiceItems.SelectedCells.Count == 1)
            {
                InvoiceItems_DbCommunication.EditInvoiceItem(OutgoingInvoices.InvoiceNumber, tbCode.Text, decimal.Parse(tbQuantity.Text), decimal.Parse(tbPrice.Text));

                MessageBox.Show
                (
                    "Артиклот е успешно променет!",
                    "Промени",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information
                );

                dgvInvoiceItems.DataSource = DbCommunication.DisplayData(SearchQuery);
            }
        }

        private void dgvInvoiceItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex != dgvInvoiceItems.Rows.Count - 1)
            {
                selectedItemID = int.Parse(dgvInvoiceItems.Rows[e.RowIndex].Cells[0].Value.ToString());
                string Code = dgvInvoiceItems.Rows[e.RowIndex].Cells[1].Value.ToString();
                InvoiceItem i = InvoiceItems_DbCommunication.GetItem(Code);

                tbCode.Text = i.Code;
                tbName.Text = i.Name;
                tbTax.Text = i.Tax.ToString();
                tbUnit.Text = i.Unit;
                tbPrice.Text = dgvInvoiceItems.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbQuantity.Text = dgvInvoiceItems.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            else
            {
                ClearTextBoxes();
            }
        }

        private void pnlControls_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
    }
}
