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
    public class TypeGoodsRepositorySQL : IRepository<typegoods>
    {
        private StorageContext db;

        public TypeGoodsRepositorySQL(StorageContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<typegoods> GetList()
        {
            return db.typegoods.ToList();
        }

        public typegoods GetItem(int id)
        {
            return db.typegoods.Find(id);
        }

        public void Create(typegoods item)
        {
            db.typegoods.Add(item);
        }

        public void Update(typegoods item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            typegoods item = db.typegoods.Find(id);
            if (item != null)
                db.typegoods.Remove(item);
        }

        public bool Save()
        {
            return db.SaveChanges() > 0;
        }
    }
}
