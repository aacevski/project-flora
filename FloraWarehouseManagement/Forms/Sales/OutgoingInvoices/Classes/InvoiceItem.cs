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
        public decimal PriceWithoutTax { get; set; }
        public decimal JustTax { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalPriceWithoutTax { get; set; }
        public decimal TotalTax { get; set; }

        public InvoiceItem (string Code="", string Name="", string Unit="", decimal Tax=0.0m, decimal Quantity=0.0m, decimal Price=0.0m)
        {
            this.Code = Code;
            this.Name = Name;
            this.Unit = Unit;
            this.Tax = Tax;
            this.Quantity = Quantity;
            this.Price = Price;
            this.PriceWithoutTax = GetPriceWithoutTax();
            this.JustTax = GetTax();
            this.TotalPrice = GetTotalPrice();
            this.TotalPriceWithoutTax = GetPriceWithoutTax();
            this.TotalTax = GetTotalTax();
        }

        public decimal GetPriceWithoutTax ()
        {
            return Price - GetTax();
        }

        public decimal GetTax()
        {
            return Price * GetAccrualRate();
        }

        // пресметковна стапка 5% = 4.76, 18% = 15.24
        public decimal GetAccrualRate ()
        {
            return ((Tax * 100) / (Tax + 100)) / 100;
        }

        public decimal GetTotalPrice ()
        {
            return Price * Quantity;
        }

        public decimal GetTotalPriceWithoutTax ()
        {
            return GetPriceWithoutTax() * Quantity;
        }

        public decimal GetTotalTax ()
        {
            return GetTax() * Quantity;
        }
    }
}
