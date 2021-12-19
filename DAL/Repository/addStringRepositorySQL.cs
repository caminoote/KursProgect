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
     public class addStringRepositorySQL : IRepository<addString>
    {
        private StorageContext db;

        public addStringRepositorySQL(StorageContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<addString> GetList()
        {
            return db.addString.ToList();
        }

        public addString GetItem(int id)
        {
            return db.addString.Find(id);
        }

        public void Create(addString addString)
        {
            db.addString.Add(addString);
        }

        public void Update(addString addString)
        {
            db.Entry(addString).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            addString addString = db.addString.Find(id);
            if (addString != null)
                db.addString.Remove(addString);
        }
    }
}
