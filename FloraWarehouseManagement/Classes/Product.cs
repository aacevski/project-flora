using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloraWarehouseManagement.Classes
{
    class Product
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Measurement { get; set; }
        public string TaxGroup { get; set; }
        public string GroupCode { get; set; }
        public string SecondaryCode { get; set; }
        public string Price { get; set; }
        public string Origin { get; set; }
        public string Description { get; set; }     
        public string WithTax { get; set; }
        public string Quantity { get; set; }

        public void SetProduct(params string[] properties)
        {
            Code = properties[0];
            Name = properties[1];
            Measurement = properties[2];
            TaxGroup = properties[3];
            GroupCode = properties[4];
            SecondaryCode = properties[5];
            Price = properties[6];
            Origin = properties[7];
            Description = properties[8];
            Quantity = properties[9];
            WithTax = properties[10];
        }
    }
}
