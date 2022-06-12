using CategoryProduct.WebApi.Data;
using CategoryProduct.WebApi.Interfaces;
using CategoryProduct.WebApi.Models;

namespace CategoryProduct.WebApi.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IGenericRepository<Product>
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }
    }
}
