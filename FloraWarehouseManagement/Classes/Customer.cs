using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloraWarehouseManagement.Classes
{
    public class Customer
    {
        public string Name { get; set; }
        public string TaxNumber { get; set; }
        public string EMBS { get; set; }
        public string MainBankNumber { get; set; }
        public string SecondaryBankNumber { get; set; }
        public string Bank { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string ContactPerson1 { get; set; }
        public string ContactPerson2 { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }

        public Customer () { }

        public void SetCustomer (params string[] parameters)
        {
            Console.WriteLine(parameters[0]);
            Name = parameters[0];
            TaxNumber = parameters[1];
            EMBS = parameters[2];
            MainBankNumber = parameters[3];
            SecondaryBankNumber = parameters[4];
            Bank = parameters[5];
            Address = parameters[6];
            City = parameters[7];
            ZipCode = parameters[8];
            ContactPerson1 = parameters[9];
            ContactPerson2 = parameters[10];
            Phone1 = parameters[11];
            Phone2 = parameters[12];
            Email = parameters[13];
            Description = parameters[14];
        }


    }
}
