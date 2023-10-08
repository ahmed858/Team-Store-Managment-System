using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Entities
{
    internal class Stock
    {
        public int StockId { get; set; }

        [Required]
        public string StockName { get; set; }
        public string? Location { get; set; }
        public string? StockDescription { get; set; }


        public virtual ICollection<ProductInStock> ProductsInStock { get; set; } = new HashSet<ProductInStock>();
    }
}
