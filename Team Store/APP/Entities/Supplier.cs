using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Entities
{
    internal class Supplier
    {
        public int SupplierId{ get; set; }
        public string SupplierName { get; set; }
        public bool? Gender {  get; set; }
        public string? contact {  get; set; }

    }
}
