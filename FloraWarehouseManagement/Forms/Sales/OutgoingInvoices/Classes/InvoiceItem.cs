using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloraWarehouseManagement.Forms.Sales.OutgoingInvoices.Classes
{
    public class InvoiceItem
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public decimal Tax { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }

        public decimal PriceWithoutTax ()
        {
            return Price - GetTax();
        }

        public decimal GetTax()
        {
            return Price * GetPresmetkovnaStapka();
        }

        // Ne znaev kako da prevedam "presmetkovna stapka" :)
        public decimal GetPresmetkovnaStapka ()
        {
            return ((Tax * 100) / (Tax + 100)) / 100;
        }

        public decimal GetTotalPrice ()
        {
            return Price * Quantity;
        }

        public decimal GetTotalPriceWithoutTax ()
        {
            return PriceWithoutTax() * Quantity;
        }

        public decimal GetTotalTax ()
        {
            return GetTax() * Quantity;
        }
    }
}
