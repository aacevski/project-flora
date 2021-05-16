using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloraWarehouseManagement.Forms
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
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
    }
}
