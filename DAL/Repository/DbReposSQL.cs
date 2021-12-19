using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class DbReposSQL : IDbRepos
    {
        private StorageContext db;
        private ProductRepositorySQL ProductRepository;
        private addStringRepositorySQL addStringRepository;
        private TypeGoodsRepositorySQL TypeGoodsRepository;
        private OutStringRepositorySQL OutStringRepository;
        private OutRepositorySQL OutRepository;
        private ShopsRepositorySQL ShopsRepository;
        private UserRepositorySQL UserRepository;
        private SupplyRepositorySQL SupplyRepository;
        private TraderRepositorySQL TraderRepository;
        private ReportRepositorySQL reportRepository;


        public DbReposSQL()
        {
            db = new StorageContext();
        }

        public IRepository<Product> Products
        {
            get
            {
                if (ProductRepository == null)
                    ProductRepository = new ProductRepositorySQL(db);
                return ProductRepository;
            }
        }

        public IRepository<addString> addStrings
        {
            get
            {
                if (addStringRepository == null)
                    addStringRepository = new addStringRepositorySQL(db);
                return addStringRepository;
            }
        }

        public IRepository<typegoods> TypeGoods
        {
            get
            {
                if (TypeGoodsRepository == null)
                    TypeGoodsRepository = new TypeGoodsRepositorySQL(db);
                return TypeGoodsRepository;
            }
        }

        public IRepository<OutString> OutStrings
        {
            get
            {
                if (OutStringRepository == null)
                    OutStringRepository = new OutStringRepositorySQL(db);
                return OutStringRepository;
            }
        }

        public IRepository<Out> Outs
        {
            get
            {
                if (OutRepository == null)
                    OutRepository = new OutRepositorySQL(db);
                return OutRepository;
            }
        }

        public IRepository<Shops> Shopss
        {
            get
            {
                if (ShopsRepository == null)
                    ShopsRepository = new ShopsRepositorySQL(db);
                return ShopsRepository;
            }
        }

        public IRepository<User> Users
        {
            get
            {
                if (UserRepository == null)
                    UserRepository = new UserRepositorySQL(db);
                return UserRepository;
            }
        }

        public IRepository<Supply> Supplys
        {
            get
            {
                if (SupplyRepository == null)
                    SupplyRepository = new SupplyRepositorySQL(db);
                return SupplyRepository;
            }
        }

        public IRepository<Trader> Traders
        {
            get
            {
                if (TraderRepository == null)
                    TraderRepository = new TraderRepositorySQL(db);
                return TraderRepository;
            }
        }
        public IReportsRepository Reports
        {
            get
            {
                if (reportRepository == null)
                    reportRepository = new ReportRepositorySQL(db);
                return reportRepository;
            }
        }

        public int Save()
        {
            return db.SaveChanges();
        }
    }
}
