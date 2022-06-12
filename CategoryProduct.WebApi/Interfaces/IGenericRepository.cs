using System.Collections.Generic;

namespace CategoryProduct.WebApi.Interfaces
{
    public interface IGenericRepository<T> where T : class, new()
    {
        public List<T> TGetAll();
        public T TAdd(T entity);
        public void TUpdate(T entity);
        public void TDelete(int id);
        public T GetT(int id);


    }
}
