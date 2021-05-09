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

namespace FloraWarehouseManagement.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            CenterControlSingleton.Instance.CenterControl(pnlLogo);
            CenterControlSingleton.Instance.CenterControl(pnlButtons);
        }

        private void RegisterForm_SizeChanged(object sender, EventArgs e)
        {
            CenterControlSingleton.Instance.CenterControl(pnlLogo);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AppDomain.CurrentDomain.BaseDirectory);
            SQLiteConnection connection = new SQLiteConnection(@"data source=" + AppDomain.CurrentDomain.BaseDirectory + @"Database\db.db");
            connection.Open();
            string query = "INSERT INTO User(Username, Password) VALUES(@Username, @Password)";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("Username", tbUsername.Text);
            command.Parameters.AddWithValue("Password", tbPassword.Text);
            DataTable userTable = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(userTable);
        }
    }
}
