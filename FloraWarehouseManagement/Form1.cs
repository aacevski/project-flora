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
            CheckForEmptyString();
            CheckCredentials(tbUsername.Text, tbPassword.Text);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form registracija = new RegisterForm();
            registracija.ShowDialog();
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            errProviderUsername.SetError(tbUsername, null);
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            errProviderPassword.SetError(tbPassword, null);
        }

        private void CheckForEmptyString()
        {
            if (tbUsername.Text == "")
            {
                errProviderUsername.SetError(tbUsername, "Внесете валидно корисничко име.");
            }
            else
            {
                errProviderUsername.SetError(tbUsername, null);
            }

            if (tbPassword.Text == "")
            {
                errProviderPassword.SetError(tbPassword, "Внесете валидна лозинка.");
            }
            else
            {
                errProviderPassword.SetError(tbPassword, null);
            }
        }

        private void CheckCredentials(string username, string password)
        {
            int userExists = CheckCredentialsSingleton.Instance.CheckUsername(username);

            if (userExists < 1)
            {
                errProviderUsername.SetError(tbUsername, "Корисничкото име не постои.");
                return;
            }
            else
            {
                errProviderUsername.SetError(tbUsername, null);
            }

            int check = CheckCredentialsSingleton.Instance.CheckUsernameAndPassword(username, password);

            if (check < 1)
            {
                errProviderPassword.SetError(tbPassword, "Погрешна лозинка.");
            }
            else
            {
                MessageBox.Show("Успешно логирани");
            }

        }
    }
}
