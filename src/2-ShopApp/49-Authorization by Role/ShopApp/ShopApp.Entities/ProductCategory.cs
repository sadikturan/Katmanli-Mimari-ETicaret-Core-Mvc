using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Entities
{
   public class ProductCategory
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
