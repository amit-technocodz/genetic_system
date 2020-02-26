using Data;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        //T Get(long id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
        IQueryable<T> Get();
        int SaveChanges(int UserId, string IPaddress, int TargetID);
    }
}
