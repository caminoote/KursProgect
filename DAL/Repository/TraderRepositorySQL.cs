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
    public class TraderRepositorySQL : IRepository<Trader>
    {
        private StorageContext db;

        public TraderRepositorySQL(StorageContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<Trader> GetList()
        {
            return db.Trader.ToList();
        }

        public Trader GetItem(int id)
        {
            return db.Trader.Find(id);
        }

        public void Create(Trader Trader)
        {
            db.Trader.Add(Trader);
        }

        public void Update(Trader Trader)
        {
            db.Entry(Trader).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Trader Trader = db.Trader.Find(id);
            if (Trader != null)
                db.Trader.Remove(Trader);
        }
    }
}
