using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloraWarehouseManagement.Classes
{
    class Employee
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string EMBG { get; set; }
        public string Salary { get; set; }
        public string Start { get; set; }
        public string Address { get; set; }
        public string Position { get; set; }
        public string IdNumber { get; set; }
        public string Phone { get; set; }
        public string Bank { get; set; }
        public string BankNumber { get; set; }
        public string Description { get; set; }

        public void SetEmployee(params string[] properties)
        {
            Name = properties[0];
            Lastname = properties[1];
            EMBG = properties[2];
            Salary = properties[3];
            Start = properties[4];
            Address = properties[5];
            Position = properties[6];
            IdNumber = properties[7];
            Phone = properties[8];
            Bank = properties[9];
            BankNumber = properties[10];
            Description = properties[10];
        }
    }
}
