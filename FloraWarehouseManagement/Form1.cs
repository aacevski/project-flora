using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FloraWarehouseManagement.Forms;
using FloraWarehouseManagement.Classes.Utilities;

namespace FloraWarehouseManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            CenterControlSingleton.Instance.CenterControl(pnlButtons);
        }

        private void LoginForm_SizeChanged(object sender, EventArgs e)
        {
            CenterControlSingleton.Instance.CenterControl(pnlLogo);
            CenterControlSingleton.Instance.CenterControl(gbLogin);
        }

/*        private void CenterControl(Control ctrlToCenter)
        {
            ctrlToCenter.Left = (ctrlToCenter.Parent.Width - ctrlToCenter.Width) / 2;
        }*/

        private void LoginForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if
                (
                    MessageBox.Show
                    (
                        "Дали сакате да ја изгасите апликацијата?",
                        "Изгаси",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button2 // hit Enter == No !
                    )
                    == DialogResult.Yes
                )
                {
                    Application.Exit();
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click!");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form registracija = new RegisterForm();
            registracija.ShowDialog();
        }
    }
}
