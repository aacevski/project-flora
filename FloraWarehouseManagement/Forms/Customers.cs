using System;
using System.IO;
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
    public partial class Customers : Form
    {
        private static readonly string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        SQLiteConnection connection = new SQLiteConnection(@"data source=" + projectDirectory + @"\Database\db.db");


        public Customers()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            dgvCustomers.Height = this.Height;
            dgvCustomers.Width = this.Width;
            this.WindowState = FormWindowState.Maximized;

            DisplayData();
        }

        public void DisplayData()
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT Назив, Даночен_број, ЕМБС, Жиро_сметка, Жиро_сметка_доп, Банка, Адреса, Град, Поштенски_број, Забелешка FROM Customers", connection);
            connection.Open();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            dgvCustomers.DataSource = dt;
            connection.Close();
        }

        private void Customers_SizeChanged(object sender, EventArgs e)
        {
            pnlControls.Width = this.Width;
            dgvCustomers.Height = this.Height;
            dgvCustomers.Width = this.Width;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbTaxNum.Text == "")
            {
                errorProviderTaxNum.SetError(tbTaxNum, "Задолжително внесете даночен број.");
            }
            else
            {
                errorProviderTaxNum.SetError(tbTaxNum, null);

                int productExists = CustomerFunctions.Instance.Exists(tbTaxNum.Text);

                if (productExists < 1)
                {
                    CustomerFunctions.Instance.Add
                        (
                        tbName.Text,
                        tbTaxNum.Text,
                        tbEMBS.Text,
                        tbBankNum1.Text,
                        tbBankNum2.Text,
                        cbBank.GetItemText(cbBank.SelectedItem),
                        tbAddress.Text,
                        tbCity.Text,
                        tbZipCode.Text,
                        tbContactPerson1.Text,
                        tbContactPerson2.Text,
                        tbPhone1.Text,
                        tbPhone2.Text,
                        tbEmail.Text,
                        tbDescription.Text
                        );

                    DisplayData();

                    MessageBox.Show
                    (
                        "Коминтентот е успешно додаден!",
                        "Сними",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show("Тој коминтент веќе постои!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Products_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                Form mainMenu = new Forms.MainMenu();
                mainMenu.Closed += (s, args) => this.Close();
                mainMenu.Show();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(rbtnCode.Checked)
            {

               
            }

            else if(rbtnProduct.Checked)
            {
             
            }
            
            else
            {
                MessageBox.Show("Одберете барем еден вид на филтрирање, по шифра или по артикл!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int productExists = CustomerFunctions.Instance.Exists(tbTaxNum.Text);

            if (productExists == 1)
            {

                CustomerFunctions.Instance.Delete(tbTaxNum.Text);
                DisplayData();

                MessageBox.Show
                (
                    "Коминтентот е успешно избришан!",
                    "Избриши",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show("Тој коминтент не постои!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex != -1)
            {
                string TaxNum = dgvCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
                SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM Customers WHERE Даночен_број='{TaxNum}'", connection);
                connection.Open();
                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);

                if (TaxNum != "")   // Smeni go ova, ne smee da bide prazno.
                {
                    tbName.Text = dt.Rows[0].ItemArray[1].ToString();
                    tbTaxNum.Text = dt.Rows[0].ItemArray[2].ToString();
                    tbEMBS.Text = dt.Rows[0].ItemArray[3].ToString();
                    tbBankNum1.Text = dt.Rows[0].ItemArray[4].ToString();
                    tbBankNum2.Text = dt.Rows[0].ItemArray[5].ToString();
                    cbBank.SelectedIndex = cbBank.FindString(dt.Rows[0].ItemArray[6].ToString());
                    tbAddress.Text = dt.Rows[0].ItemArray[7].ToString();
                    tbContactPerson1.Text = dt.Rows[0].ItemArray[8].ToString();
                    tbContactPerson2.Text = dt.Rows[0].ItemArray[9].ToString();
                    tbPhone1.Text = dt.Rows[0].ItemArray[10].ToString();
                    tbPhone2.Text = dt.Rows[0].ItemArray[11].ToString();
                    tbEmail.Text = dt.Rows[0].ItemArray[12].ToString();
                    tbCity.Text = dt.Rows[0].ItemArray[13].ToString();
                    tbZipCode.Text = dt.Rows[0].ItemArray[14].ToString();
                    tbDescription.Text = dt.Rows[0].ItemArray[15].ToString();
                }

                connection.Close();
            }
        }

        private void pnlControls_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            tbName.Text = "";
            tbTaxNum.Text = "";
            tbEMBS.Text = "";
            tbBankNum1.Text = "";
            tbBankNum2.Text = "";
            cbBank.SelectedIndex = -1;
            tbAddress.Text = "";
            tbContactPerson1.Text = "";
            tbContactPerson2.Text = "";
            tbPhone1.Text = "";
            tbPhone2.Text = "";
            tbEmail.Text = "";
            tbCity.Text = "";
            tbZipCode.Text = "";
            tbDescription.Text = "";
        }

        private void tbTaxNum_TextChanged(object sender, EventArgs e)
        {
            errorProviderTaxNum.SetError(tbTaxNum, null);
        }
    }
}
