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
using System.Data.SQLite;
using System.IO;
using System.Globalization;

namespace FloraWarehouseManagement
{
    public partial class LoginForm : Form
    {
        private static readonly string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        SQLiteConnection connection = new SQLiteConnection(@"data source=" + projectDirectory + @"\Database\db.db");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            AlignControls.CenterControlHorizontal(pnlButtons);
        }

        private void LoginForm_SizeChanged(object sender, EventArgs e)
        {
            AlignControls.CenterControlHorizontal(pnlLogo);
            AlignControls.CenterControlHorizontal(gbLogin);
        }

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

            if (CheckForEmptyString() && CheckCredentials(tbUsername.Text, tbPassword.Text))
            {
                this.Hide();
                Form mainMenu = new Forms.MainMenu();
                mainMenu.Closed += (s, args) => this.Close();
                mainMenu.Show();

                DateTime date = DateTime.Now;
                string Time = date.ToString("HH:mm:ss - dd MMM, yyyy");

                SQLiteCommand command = new SQLiteCommand
                (
                "INSERT INTO LoggedIn" +
                "(Корисничко_име, " +
                "Време)" +
                "VALUES" +
                "(@Username, " +
                "@Time)",
                connection);
                connection.Open();
                command.Parameters.AddWithValue("Username", tbUsername.Text);
                command.Parameters.AddWithValue("Time", Time);
                command.ExecuteNonQuery();
                connection.Close();
            } 
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

        private bool CheckForEmptyString()
        {
            if (tbUsername.Text == "")
            {
                errProviderUsername.SetError(tbUsername, "Внесете валидно корисничко име.");
                return false;
            }
            else
            {
                errProviderUsername.SetError(tbUsername, null);
            }

            if (tbPassword.Text == "")
            {
                errProviderPassword.SetError(tbPassword, "Внесете валидна лозинка.");
                return false;
            }
            else
            {
                errProviderPassword.SetError(tbPassword, null);
            }

            return true;
        }

        private bool CheckCredentials(string username, string password)
        {
            int userExists = Classes.Utilities.CheckCredentials.CheckUsername(username);

            if (userExists < 1)
            {
                errProviderUsername.SetError(tbUsername, "Корисничкото име не постои.");
                return false;
            }
            else
            {
                errProviderUsername.SetError(tbUsername, null);
            }

            int check = Classes.Utilities.CheckCredentials.CheckUsernameAndPassword(username, password);

            if (check < 1)
            {
                errProviderPassword.SetError(tbPassword, "Погрешна лозинка.");
                return false;
            }

            return true;
        }
    }
}
