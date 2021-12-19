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
    public class OutStringRepositorySQL : IRepository<OutString>
    {
        private StorageContext db;

        public OutStringRepositorySQL(StorageContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<OutString> GetList()
        {
            return db.OutString.ToList();
        }

        public OutString GetItem(int id)
        {
            return db.OutString.Find(id);
        }

        public void Create(OutString OutString)
        {
            db.OutString.Add(OutString);
        }

        public void Update(OutString OutString)
        {
            db.Entry(OutString).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            OutString OutString = db.OutString.Find(id);
            if (OutString != null)
                db.OutString.Remove(OutString);
        }
    }
}
