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
    public class ShopsRepositorySQL : IRepository<Shops>
    {
        private StorageContext db;

        public ShopsRepositorySQL(StorageContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<Shops> GetList()
        {
            return db.Shops.ToList();
        }

        public Shops GetItem(int id)
        {
            return db.Shops.Find(id);
        }

        public void Create(Shops Shops)
        {
            db.Shops.Add(Shops);
        }

        public void Update(Shops Shops)
        {
            db.Entry(Shops).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Shops Shops = db.Shops.Find(id);
            if (Shops != null)
                db.Shops.Remove(Shops);
        }
    }
}
