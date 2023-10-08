using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Entities
{
    internal class Employee
    {
        public int SellerID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public decimal Sale { get; set; }
        public decimal Incentive { get; set; }//حافز
        public bool Gender { get; set; }
        

    }
}
