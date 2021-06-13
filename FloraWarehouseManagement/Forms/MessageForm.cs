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
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbDontShow_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DontShow = this.cbDontShow.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
