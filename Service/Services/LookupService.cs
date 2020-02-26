using Data.Models;
using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.Interfaces;
using Repository.UnitOfWork;
using Service.IServices;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Query;

namespace Service.Services
{
    public class LookupService : ILookupService
    {
      
        private IUnitOfWork db;
        public LookupService(IUnitOfWork db)
        {
            this.db = db;
        }
        public IEnumerable<Lookup> GetLookups()
        {
            return db.Lookup.Get().Include(x => x.ParentFK).ToList();
        }
        public IAsyncEnumerable<Lookup> GetLookupList()
        {
            return db.Lookup.Get().Include(x => x.ParentFK).ToAsyncEnumerable();
        }
        public Lookup GetLookup(long id)
        {
            return db.Lookup.Get().Where(x => x.ID == id).FirstOrDefault();
        }
        public void InsertUser(Lookup lookup)
        {
            db.Lookup.Insert(lookup);
        }
        public void UpdateUser(Lookup lookup)
        {
            db.Lookup.Update(lookup);
        }
        public void DeleteUser(long id)
        {
            Lookup user = GetLookup(id);
            db.Lookup.Remove(user);
            db.Lookup.SaveChanges();
        }
        public IEnumerable<Lookup> GetByType(string type)
        {
            return db.Lookup.Get().Where(x=>x.Type == type).ToList();
        }
        public IEnumerable<IMDetailLookup> GetIMDetailLookups()
        {

            return db.IMDetailLookup.Get().ToList();
        }
    }
}
