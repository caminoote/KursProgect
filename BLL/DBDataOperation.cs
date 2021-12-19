using BLL.Interfaces;
using DAL;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DbDataOperation : IDbCrud
    {
        IDbRepos db;
        public DbDataOperation(IDbRepos repos)
        {
            db = repos;
        }
        #region EnterString

        public List<addStringModel> GetALLEnterString()
        {
            return db.addStrings.GetList().Select(i => new addStringModel(i)).ToList();
        }

        public void CreateEnterString(addStringModel p)
        {
            db.addStrings.Create(new addString() { idProduct = p.idProduct, StorageKool = p.StorageKool, Price = p.Price, DateCreate = p.DateCreate, idSupply =p.idSupply });
            Save();
        }

        public addStringModel GetEnterString(int Id)
        {
            return new addStringModel(db.addStrings.GetItem(Id));
        }

        public void DeleteEnterString(int id)
        {
            if (db.addStrings.GetItem(id) != null)
            {
                db.addStrings.Delete(id);
                Save();
            }
        }
        #endregion
        #region Product

        public List<ProductModel> GetALLProduct()
        {
            return db.Products.GetList().Select(i => new ProductModel(i)).ToList();
        }

        public ProductModel GetProduct(int idProduct)
        {
            return new ProductModel(db.Products.GetItem(idProduct));
        }

        public void CreateProduct(ProductModel p)
        {
            db.Products.Create(new Product() { TimeUse = p.TimeUse, idTypeGoods = p.idTypeGoods, NameProduct = p.NameProduct, });
            Save();
        }

        public void UpdateProduct(ProductModel p)
        {
            Product ph = db.Products.GetItem(p.idProduct);
            ph.NameProduct = p.NameProduct;
            ph.TimeUse = p.TimeUse;
            ph.idTypeGoods = p.idTypeGoods;
            Save();
        }

        public void DeleteProduct(int id)
        {
            Product p = db.Products.GetItem(id);
            if (p != null)
            {
                db.Products.Delete(p.idProduct);
                Save();
            }
        }
        #endregion

        public List<TypeGoodsModel> GetALLTypeGoods()
        {
            return db.TypeGoods.GetList().Select(i => new TypeGoodsModel(i)).ToList();
        }

        public List<UserModel> GetALLUser()
        {
            return db.Users.GetList().Select(i => new UserModel(i)).ToList();
        }

        public bool Save()
        {
            if (db.Save() > 0) return true;
            return false;
        }
    }
}
