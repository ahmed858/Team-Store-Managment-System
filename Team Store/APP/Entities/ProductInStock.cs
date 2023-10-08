using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Entities
{
    internal class ProductInStock
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellPrice { get; set; }
        public decimal Quantity { get; set; }
        public string? Description { get; set; }
        [ForeignKey("StockId")]
        public int StockId { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }//Foreign Key
        
        public Category Category { get; set; }// Navigation property
        public Stock Stock { get; set; }// Navigation property
    }
}
