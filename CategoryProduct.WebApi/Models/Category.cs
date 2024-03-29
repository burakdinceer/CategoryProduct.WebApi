﻿using System.Collections.Generic;

namespace CategoryProduct.WebApi.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ProductCategory> productCategories { get; set; }
    }
}
