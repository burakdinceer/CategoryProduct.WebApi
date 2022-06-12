using CategoryProduct.WebApi.Data;
using CategoryProduct.WebApi.Interfaces;
using CategoryProduct.WebApi.Models;

namespace CategoryProduct.WebApi.Repositories
{
    public class ProductCategoryRepository : GenericRepository<ProductCategory>, IGenericRepository<ProductCategory>
    {
        public ProductCategoryRepository(DataContext context) : base(context)
        {
        }
    }
}
