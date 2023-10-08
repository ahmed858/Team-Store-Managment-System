using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Entities
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal SellPrice { get; set; }
        public decimal PurchasePrice { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }//Foreign Key

        public Category Category { get; set; }// Navigation property
    }
}
