using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FloraWarehouseManagement.Classes.Utilities;

namespace FloraWarehouseManagement.Forms
{
    public partial class Logins : Form
    {
        private static readonly string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        SQLiteConnection connection = new SQLiteConnection(@"data source=" + projectDirectory + @"\Database\db.db");

        public Logins()
        {
            InitializeComponent();
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

        private void Logins_Load(object sender, EventArgs e)
        {
            dgvLogins.Height = this.Height;
            dgvLogins.Width = this.Width;
            this.WindowState = FormWindowState.Maximized;
            DisplayData();
            AlignControls.CenterControlHorizontal(pnlHeader);
        }

        private void Logins_SizeChanged(object sender, EventArgs e)
        {
            dgvLogins.Height = this.Height;
            dgvLogins.Width = this.Width;
        }

        private void DisplayData()
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT Корисничко_име, Време FROM LoggedIn", connection);
            connection.Open();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            dgvLogins.DataSource = dt;
            connection.Close();
        }
    }
}
