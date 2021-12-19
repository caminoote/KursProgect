using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class SupplyRepositorySQL : IRepository<Supply>
    {
        private StorageContext db;

        public SupplyRepositorySQL(StorageContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<Supply> GetList()
        {
            return db.Supply.ToList();
        }

        public Supply GetItem(int id)
        {
            return db.Supply.Find(id);
        }

        public void Create(Supply Supply)
        {
            db.Supply.Add(Supply);
        }

        public void Update(Supply Supply)
        {
            db.Entry(Supply).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Supply Supply = db.Supply.Find(id);
            if (Supply != null)
                db.Supply.Remove(Supply);
        }
    }
}
