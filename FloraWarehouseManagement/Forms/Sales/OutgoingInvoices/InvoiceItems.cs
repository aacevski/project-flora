using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FloraWarehouseManagement.Forms.Sales.OutgoingInvoices.Classes;

namespace FloraWarehouseManagement.Forms.Sales.OutgoingInvoices
{
    public partial class InvoiceItems : Form
    {
        private InvoiceItem item;
        private DataTable dt;

        public InvoiceItems()
        {
            item = new InvoiceItem();
            InitializeComponent();
        }

        private void InvoiceItems_Load(object sender, EventArgs e)
        {
            InitDataTable();
            dgvInvoiceItems.DataSource = dt;
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
                }
            }
        }

        private void AddToDgv ()
        {
            dt.Rows.Add
                (
                item.Code,
                item.Name,
                item.Unit,
                item.Tax,
                item.Quantity,
                Convert.ToDecimal(string.Format("{0:N2}", item.PriceWithoutTax())),
                Convert.ToDecimal(string.Format("{0:N2}", item.GetTax())),
                Convert.ToDecimal(string.Format("{0:N2}", item.Price)),
                Convert.ToDecimal(string.Format("{0:N2}", item.GetTotalPriceWithoutTax())),
                Convert.ToDecimal(string.Format("{0:N2}", item.GetTotalTax())),
                Convert.ToDecimal(string.Format("{0:N2}", item.GetTotalPrice()))
                );
        }

        private void InitDataTable()
        {
            dt = new DataTable();
            dt.Columns.Add("Шифра", typeof(string));
            dt.Columns.Add("Артикл", typeof(string));
            dt.Columns.Add("Мерка", typeof(string));
            dt.Columns.Add("Даночна ставка", typeof(decimal));
            dt.Columns.Add("Количина", typeof(decimal));
            dt.Columns.Add("Ед. цена", typeof(decimal));
            dt.Columns.Add("Ед. ДДВ", typeof(decimal));
            dt.Columns.Add("Прод. цена", typeof(decimal));
            dt.Columns.Add("Износ", typeof(decimal));
            dt.Columns.Add("ДДВ", typeof(decimal));
            dt.Columns.Add("Вкупно", typeof(decimal));
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            item.Quantity = nudQuantity.Value;
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbPrice.Text))
            {
                item.Price = int.Parse(tbPrice.Text);
            }

            UpdateTextBoxes();
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void UpdateTextBoxes()
        {
            tbEdCena.Text = string.Format("{0:F2}", item.PriceWithoutTax());
            tbEdDDV.Text = string.Format("{0:F2}", item.GetTax());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddToDgv();
            ClearTextBoxes();
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
            nudQuantity.Value = 0;
        }
    }
}
