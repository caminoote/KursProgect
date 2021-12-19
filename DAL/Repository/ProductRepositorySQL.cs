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
    public class ProductRepositorySQL : IRepository<Product>
    {
        private StorageContext db;

        public ProductRepositorySQL(StorageContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<Product> GetList()
        {
            return db.Product.ToList();
        }

        public Product GetItem(int id)
        {
            return db.Product.Find(id);
        }

        public void Create(Product Product)
        {
            db.Product.Add(Product);
        }

        public void Update(Product Product)
        {
            db.Entry(Product).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Product Product = db.Product.Find(id);
            if (Product != null)
                db.Product.Remove(Product);
        }
    }
}
