using CategoryProduct.WebApi.Data;
using CategoryProduct.WebApi.Interfaces;
using CategoryProduct.WebApi.Models;

namespace CategoryProduct.WebApi.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, IGenericRepository<Category>
    {
        public CategoryRepository(DataContext context) : base(context)
        {
        }
    }
}
