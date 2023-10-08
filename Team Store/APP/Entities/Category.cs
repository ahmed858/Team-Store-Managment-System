using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Entities
{
    internal class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public string? CategoryDescription { get; set; }

        public ICollection<ProductInStock> ProductsInStock { get; set;}
        public ICollection<Product> Products { get; set; }

    }
}
