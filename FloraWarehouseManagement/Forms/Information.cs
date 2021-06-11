using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FloraWarehouseManagement.Classes.Utilities;
using FloraWarehouseManagement.Classes;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace FloraWarehouseManagement.Forms
{
    public partial class Information : Form
    {
        private IEnumerable<TextBox> textBoxes;
        public static CompanyInfo CompanyInfo;
        private static readonly string saveFolder = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\CompanyInfo\";

        public Information()
        {
            InitializeComponent();
        }

        private void Information_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            AlignControls.CenterControl(gbInfo);
            btnEdit.BringToFront();
            btnSave.SendToBack();
            textBoxes = EnumeratorForControls.GetChildControls<TextBox>(gbInfo);
            CompanyInfo = new CompanyInfo();
            Open();
            FillTextBoxes();
        }

        private void Information_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                Form mainMenu = new MainMenu();
                mainMenu.Closed += (s, args) => this.Close();
                mainMenu.Show();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnEdit.SendToBack();

            btnSave.BringToFront();
            btnSave.Enabled = true;

            EnableOrDisableTextBoxes(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnSave.SendToBack();

            btnEdit.Enabled = true;
            btnEdit.BringToFront();

            CompanyInfo.SetInfo(textBoxes);
            Save();

            EnableOrDisableTextBoxes(true);
        }

        private void EnableOrDisableTextBoxes (bool command)
        {
            foreach (TextBox tb in textBoxes)
            {
                tb.ReadOnly = command;
            }
        }

        private void Save ()
        {
            string fileName = saveFolder + @"info.ci";
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, CompanyInfo);
            }
        }

        public static void Open ()
        {
            string fileName = saveFolder + @"info.ci";
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                IFormatter formatter = new BinaryFormatter();
                CompanyInfo = formatter.Deserialize(fs) as CompanyInfo;
            }
        }

        private void FillTextBoxes()
        {
            tbName.Text = CompanyInfo.Name;
            tbAuthorizedPerson.Text = CompanyInfo.AuthorizedPerson;
            tbEMBR.Text = CompanyInfo.EMBR;
            tbTaxNumber.Text = CompanyInfo.TaxNumber;
            tbPhone.Text = CompanyInfo.Phone;
            tbEmail.Text = CompanyInfo.Email;
            tbAddress.Text = CompanyInfo.Address;
            tbMunicipality.Text = CompanyInfo.Municipality;
            tbCity.Text = CompanyInfo.City;
            tbZipCode.Text = CompanyInfo.ZipCode;

            tbBank1.Text = CompanyInfo.Bank1;
            tbBankNum1.Text = CompanyInfo.BankNum1;
            tbBank2.Text = CompanyInfo.Bank2;
            tbBankNum2.Text = CompanyInfo.BankNum2;
            tbBank3.Text = CompanyInfo.Bank3;
            tbBankNum3.Text = CompanyInfo.BankNum3;
        }

        private void Information_SizeChanged(object sender, EventArgs e)
        {
            AlignControls.CenterControl(gbInfo);
        }
    }
}
