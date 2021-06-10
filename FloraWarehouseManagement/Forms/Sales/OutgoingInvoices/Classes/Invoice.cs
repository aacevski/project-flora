using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloraWarehouseManagement.Forms.Sales.OutgoingInvoices.Classes
{
    public class Invoice
    {
        private int InvoiceID { get; set; }  // Бројот на фактурата
        private CustomerInfo CustomerInfo { get; set; } // ID на коминтент во базата
        private List<InvoiceItem> InvoiceItems { get; set; }
        private string Valuta { get; set; }
        private string Description { get; set; }
        private string Date { get; set; }
        private string DocType { get;set; }

        public Invoice (int InvoiceID, CustomerInfo CustomerInfo, string Valuta, string Description, string Date, string DocType)
        {
            this.InvoiceID = InvoiceID;
            this.CustomerInfo = CustomerInfo;
            this.Valuta = Valuta;
            this.Description = Description;
            this.Date = Date;
            this.DocType = DocType;
        }

        public void SetInvoiceItems ()
        {

        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", InvoiceID, CustomerInfo.Name, Valuta, Description, Date);
        }

    }
}
