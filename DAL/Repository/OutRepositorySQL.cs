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
    public class OutRepositorySQL : IRepository<Out>
    {
        private StorageContext db;

        public OutRepositorySQL(StorageContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<Out> GetList()
        {
            return db.Out.ToList();
        }

        public Out GetItem(int id)
        {
            return db.Out.Find(id);
        }

        public void Create(Out Out)
        {
            db.Out.Add(Out);
        }

        public void Update(Out Out)
        {
            db.Entry(Out).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Out Out = db.Out.Find(id);
            if (Out != null)
                db.Out.Remove(Out);
        }
    }
}
