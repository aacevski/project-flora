using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private Employee Employee;
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

            Employee = new Employee();

            UpdateTable();
        }

        private void Employees_SizeChanged(object sender, EventArgs e)
        {
            pnlControls.Width = this.Width;
            dgvEmployees.Height = this.Height;
            dgvEmployees.Width = this.Width;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbLastname.Text == "" ||  mtbEMBG.Text.Length < 13 || mtbPhone.Text.Length < 11 || tbIdNumber.Text.Length < 8)
            {
                errorProviderEMBG.SetError(mtbEMBG, "Полето за ЕМБГ е задолжително");
                errorProviderName.SetError(tbName, "Полето за Име е задолжително");
                errorProviderLastname.SetError(tbLastname, "Полето за Презиме е задолжително");
                errorProviderPhone.SetError(mtbPhone, "Полето за Телефон е задолжително");
                errorProviderIdNumber.SetError(tbIdNumber, "Полето за Број на Лична Карта е задолжително");
            }
            else
            {
                if (DbCommunication.Exists("Employees", "ЕМБГ", mtbEMBG.Text) < 1)
                {
                    string Start = dtpStart.Value.ToString("HH:mm:ss - dd MMM, yyyy");
                    Employee_DbCommunication.AddEmployee(tbName.Text, tbLastname.Text, mtbEMBG.Text, tbSalary.Text, Start, tbAddress.Text, tbPosition.Text, tbIdNumber.Text, mtbPhone.Text, tbBank.Text, mtbBankNumber.Text, rtbNote.Text);

                    UpdateTable();

                    MessageBox.Show
                    (
                        "Вработениот е успешно додаден!",
                        "Сними",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    errorProviderEMBG.Clear();
                    errorProviderName.Clear();
                    errorProviderLastname.Clear();
                    errorProviderPhone.Clear();
                    errorProviderIdNumber.Clear();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string Start = dtpStart.Value.ToString("HH:mm:ss - dd MMM, yyyy");
            Employee_DbCommunication.EditEmployee(Employee.EMBG, tbName.Text, tbLastname.Text, mtbEMBG.Text, tbSalary.Text, Start, tbAddress.Text, tbPosition.Text, tbIdNumber.Text, mtbPhone.Text, tbBank.Text, mtbBankNumber.Text, rtbNote.Text);
            Employee.EMBG = mtbEMBG.Text;

            MessageBox.Show
            (
                "Вработениот е успешно променет!",
                "Промени",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
            );

            UpdateTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DbCommunication.Exists("Employees", "ЕМБГ", mtbEMBG.Text) == 1)
            {

                DbCommunication.Delete("Employees", "ЕМБГ", mtbEMBG.Text);
                UpdateTable();

                MessageBox.Show
                (
                    "Вработениот е успешно избришан!",
                    "Избриши",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show
                    (
                    "Toj вработен не постои!",
                    "Грешка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex != dgvEmployees.Rows.Count - 1)
            {
                string Start = dtpStart.Value.ToString("HH:mm:ss - dd MMM, yyyy");
                DataGridViewRow row = this.dgvEmployees.Rows[e.RowIndex];
                tbName.Text = row.Cells[0].Value.ToString();
                tbLastname.Text = row.Cells[1].Value.ToString();
                mtbEMBG.Text = row.Cells[2].Value.ToString();
                tbSalary.Text = row.Cells[3].Value.ToString();
                dtpStart.Value = DateTime.ParseExact(row.Cells[4].Value.ToString(), "HH:mm:ss - dd MMM, yyyy", CultureInfo.InvariantCulture);
                tbAddress.Text = row.Cells[5].Value.ToString();
                tbPosition.Text = row.Cells[6].Value.ToString();
                tbIdNumber.Text = row.Cells[7].Value.ToString();
                mtbPhone.Text = row.Cells[8].Value.ToString();
                tbBank.Text = row.Cells[9].Value.ToString();
                mtbBankNumber.Text = row.Cells[10].Value.ToString();
                rtbNote.Text = row.Cells[11].Value.ToString();

                Employee.SetEmployee(tbName.Text, tbLastname.Text, mtbEMBG.Text, tbSalary.Text, Start, tbAddress.Text, tbPosition.Text, tbIdNumber.Text, mtbPhone.Text, tbBank.Text, mtbBankNumber.Text, rtbNote.Text);
            }

            else
            {
                ClearTextBoxes();
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                UpdateTable();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            Search();
        }

        private void Search()
        {
            if (tbSearch.Text != "")
            {
                dgvEmployees.DataSource = Employee_DbCommunication.FilterEmployees(tbSearch.Text);    
            }
        }

        private void Employees_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                Form mainMenu = new MainMenu();
                mainMenu.Closed += (s, args) => this.Close();
                mainMenu.Show();
            }
        }

        private void mtbEMBG_Click(object sender, EventArgs e)
        {
            AlignControls.PositionCursorInMaskedTextBox(this, mtbEMBG);
        }

        private void mtbPhone_Click(object sender, EventArgs e)
        {
            AlignControls.PositionCursorInMaskedTextBox(this, mtbPhone);
        }

        private void mtbBankNumber_Click(object sender, EventArgs e)
        {
            AlignControls.PositionCursorInMaskedTextBox(this, mtbBankNumber);
        }

        private void ClearTextBoxes()
        {
            tbName.Text = "";
            tbLastname.Text = "";
            mtbEMBG.Text = "";
            tbSalary.Text = "";
            dtpStart.Value = DateTime.Now;
            tbAddress.Text = "";
            tbPosition.Text = "";
            tbIdNumber.Text = "";
            mtbPhone.Text = "";
            tbBank.Text = "";
            mtbBankNumber.Text = "";
            rtbNote.Text = "";
        }
    }
}
