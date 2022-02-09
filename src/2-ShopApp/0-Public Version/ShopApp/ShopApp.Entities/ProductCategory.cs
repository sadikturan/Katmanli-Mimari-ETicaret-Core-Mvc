using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Entities
{
   public class ProductCategory
    {
        [Key]
        [Column(Order = 1)]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [Key]
        [Column(Order = 2)]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
