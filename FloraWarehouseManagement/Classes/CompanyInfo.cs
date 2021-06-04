using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloraWarehouseManagement.Classes
{
    [Serializable]
    public class CompanyInfo
    {
        public string Name { get; set; }
        public string AuthorizedPerson { get; set; }
        public string EMBR { get; set; } // Edinstven maticen broj
        public string TaxNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Municipality { get; set; }
        public string Year { get; set; }
        public string Bank1 { get; set; }
        public string BankNum1 { get; set; }
        public string Bank2 { get; set; }
        public string BankNum2 { get; set; }
        public string Bank3 { get; set; }
        public string BankNum3 { get; set; }

        public CompanyInfo() {}

        public void SetInfo (IEnumerable<TextBox> tb)
        {
            List<TextBox> tbList = tb.ToList(); 

            Bank1 = tbList[5].Text;
            Bank2 = tbList[3].Text;
            Bank3 = tbList[1].Text;

            BankNum1 = tbList[4].Text;
            BankNum2 = tbList[2].Text;
            BankNum3 = tbList[0].Text;

            ZipCode = tbList[6].Text;
            City = tbList[7].Text;
            Municipality = tbList[8].Text;
            Address = tbList[9].Text;
            Email = tbList[10].Text;
            Phone = tbList[11].Text;
            TaxNumber = tbList[12].Text;
            EMBR = tbList[13].Text;
            AuthorizedPerson = tbList[14].Text;
            Name = tbList[15].Text;
        }

        public List<string> GetInfo ()
        {
            return  new List<string>()
            {
                Name,
                AuthorizedPerson,
                EMBR,
                TaxNumber,
                Phone,
                Email,
                Address,
                City,
                ZipCode,
                Municipality,
                Year,
                Bank1,
                BankNum1,
                Bank2,
                BankNum2,
                Bank3,
                BankNum3
            };
        }
    }
}
