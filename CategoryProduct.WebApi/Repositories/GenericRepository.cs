using CategoryProduct.WebApi.Data;
using CategoryProduct.WebApi.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CategoryProduct.WebApi.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {
        private readonly DataContext _context;

        public GenericRepository(DataContext context)
        {
            _context = context;
        }

        public T GetT(int id)
        {
            var gt = _context.Set<T>().Find(id);
            if (gt == null)
            {
                return null;
            }
            return gt;



        }

        public T TAdd(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entity;

        }

        public void TDelete(int id)
        {
            var dlt = _context.Set<T>().Find(id);
            if (dlt == null)
            {

            }
            _context.Set<T>().Remove(dlt);
        }

        public List<T> TGetAll()
        {
            return _context.Set<T>().ToList();
        }

        public void TUpdate(T entity)
        {
            var upt = _context.Set<T>().Find();
            _context.Entry(upt).CurrentValues.SetValues(entity);
            _context.SaveChanges();



        }
    }
}
