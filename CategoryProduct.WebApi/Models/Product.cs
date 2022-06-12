using System.Collections.Generic;

namespace CategoryProduct.WebApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Decription { get; set; }

        public List<ProductCategory> productCategories { get; set; }
    }
}
