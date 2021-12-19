using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ReportRepositorySQL : IReportsRepository
    {
        private StorageContext wild;
        private class SPResult
        {
            public int idTypeGoods { get; set; }
            public string NameProduct { get; set; }
            public int TimeUse { get; set; }
        }

        public ReportRepositorySQL(StorageContext dbcontext)
        {
            this.wild = dbcontext;
        }
        /*
                //выполнить ХП
                public List<ProductTimeUse> ExecuteSP(int EnterTimeUse)
                {
                    System.Data.SqlClient.SqlParameter param1 = new System.Data.SqlClient.SqlParameter("@TimeUse", EnterTimeUse);
                    ProductContext wild = new ProductContext();
                    var result = wild.Database.SqlQuery<SPResult>("TimeUse_getByDay @TimeUse", new object[] { param1 }).ToList();
                    var data = result.Select(i => new ProductTimeUse() { NameProduct = i.NameProduct, TimeUse = i.TimeUse, idTypeGoods = i.idTypeGoods }).ToList();
                    return data;
                }

                public List<ReportData> ReportTypeGoods(int EnteridTypeGoods)
                {
                    ProductContext wild = new ProductContext();
                    var request = wild.Product
                        .Join(wild.typegoods, ph => ph.idTypeGoods, m => m.idTypeGoods, (ph, m) => ph)
                        .Where(i => i.idTypeGoods == EnteridTypeGoods)
                        .Select(i => new ReportData() { ProductName = i.NameProduct, TimeUse = i.TimeUse })
                        .ToList();
                    return request;
                }*/
    }
}