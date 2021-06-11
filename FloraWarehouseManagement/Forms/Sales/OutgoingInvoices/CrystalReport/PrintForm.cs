using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FloraWarehouseManagement.Forms.Sales.OutgoingInvoices.Classes;
using FloraWarehouseManagement.Classes;

namespace FloraWarehouseManagement.Forms.Sales.OutgoingInvoices.CrystalReport
{
    public partial class PrintForm : Form
    {
        Invoice invoiceToPrint;
        private readonly CompanyInfo CompanyInfo = Information.CompanyInfo;
        public PrintForm(Invoice invoiceToPrint)
        {
            this.invoiceToPrint = invoiceToPrint;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {
            // Invoice items
            crptInvoices.SetDataSource(invoiceToPrint.InvoiceItems);

            // Seller info
            crptInvoices.SetParameterValue("pTaxNumber", CompanyInfo.TaxNumber);
            crptInvoices.SetParameterValue("pBank1", CompanyInfo.Bank1);
            crptInvoices.SetParameterValue("pBank2", CompanyInfo.Bank2);
            crptInvoices.SetParameterValue("pBank3", CompanyInfo.Bank3);
            crptInvoices.SetParameterValue("pBankNum1", CompanyInfo.BankNum1);
            crptInvoices.SetParameterValue("pBankNum2", CompanyInfo.BankNum2);
            crptInvoices.SetParameterValue("pBankNum3", CompanyInfo.BankNum3);
            crptInvoices.SetParameterValue("pCompanyName", CompanyInfo.Name);
            crptInvoices.SetParameterValue("pCompanyAddress", CompanyInfo.Address);
            crptInvoices.SetParameterValue("pCompanyCity", CompanyInfo.City);
            crptInvoices.SetParameterValue("pCompanyPhone", CompanyInfo.Phone);
            crptInvoices.SetParameterValue("pCompanyEmail", CompanyInfo.Email);

            // Buyer info
            crptInvoices.SetParameterValue("pCustomerName", invoiceToPrint.CustomerInfo.Name);
            crptInvoices.SetParameterValue("pCustomerAddress", invoiceToPrint.CustomerInfo.Address);
            crptInvoices.SetParameterValue("pCustomerCity", invoiceToPrint.CustomerInfo.City);

            // Invoice info
            crptInvoices.SetParameterValue("pInvoiceNumber", invoiceToPrint.InvoiceID);
            crptInvoices.SetParameterValue("pDocumentType", invoiceToPrint.DocType);
            crptInvoices.SetParameterValue("pValuta", invoiceToPrint.Valuta);
            crptInvoices.SetParameterValue("pDate", invoiceToPrint.Date);

            crptViewer.ReportSource = crptInvoices;
            crptViewer.Refresh();
        }
    }
}
