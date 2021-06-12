using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FloraWarehouseManagement.Classes;
using FloraWarehouseManagement.Classes.Utilities;

namespace FloraWarehouseManagement.Forms
{
    public partial class Employees : Form
    {
        private Employees Employee;
        private readonly string SearchQuery = "SELECT Име, Презиме, ЕМБГ, Плата, Почеток, Адреса, Работно_место, Број_на_лична_карта, Телефон, Банка, Трансакциска_сметка, Забелешка FROM Employees";

        public Employees()
        {
            InitializeComponent();
        }

        private void UpdateTable()
        {
            dgvEmployees.DataSource = DbCommunication.DisplayData(SearchQuery);
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            dgvEmployees.Height = this.Height;
            dgvEmployees.Width = this.Width;
            this.WindowState = FormWindowState.Maximized;

            UpdateTable();
        }

        private void Employees_SizeChanged(object sender, EventArgs e)
        {
            pnlControls.Width = this.Width;
            dgvEmployees.Height = this.Height;
            dgvEmployees.Width = this.Width;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DbCommunication.Exists("Employees", "ЕМБГ", tbEMBG.Text) < 1)
            {
                string Start = dtpStart.Value.ToString("HH:mm:ss - dd MMM, yyyy");

                Employee_DbCommunication.AddEmployee(tbName.Text, tbLastname.Text, tbEMBG.Text, tbSalary.Text, Start, tbAddress.Text, tbPosition.Text, tbIdNumber.Text, tbPhone.Text, tbBank.Text, tbBankNumber.Text, rtbNote.Text);

                UpdateTable();

                MessageBox.Show
                (
                    "Вработениот е успешно додаден!",
                    "Сними",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show
                (
                    "Тој вработен веќе постои!",
                    "Грешка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
