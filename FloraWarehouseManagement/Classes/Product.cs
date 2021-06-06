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
        public string LatinName { get; set; }
        public string Origin { get; set; }
        public string Description { get; set; }         
    }
}
