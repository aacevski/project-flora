using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloraWarehouseManagement.Forms.Sales.OutgoingInvoices.Classes
{
    public class Invoice
    {
        public int InvoiceID { get; set; } // Бројот на фактурата
        public CustomerInfo CustomerInfo { get; set; } // ID на коминтент во базата
        public List<InvoiceItem> InvoiceItems { get; set; }
        public string Valuta { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string DocType { get; set; }

        public Invoice (int InvoiceID, CustomerInfo CustomerInfo, string Valuta, string Description, string Date, string DocType)
        {
            this.InvoiceID = InvoiceID;
            this.CustomerInfo = CustomerInfo;
            this.Valuta = Valuta;
            this.Description = Description;
            this.Date = Date;
            this.DocType = DocType;
        }

    }
}
