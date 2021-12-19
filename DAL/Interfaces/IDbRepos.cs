using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IDbRepos
    {
        IRepository<Product> Products { get; }
        IRepository<typegoods> TypeGoods { get; }
        IRepository<addString> addStrings { get; }
        IRepository<Supply> Supplys { get; }
        IRepository<Trader> Traders { get; }
        IRepository<User> Users { get; }
        IRepository<Out> Outs { get; }
        IRepository<OutString> OutStrings { get; }
        IRepository<Shops> Shopss { get; }
        IReportsRepository Reports { get; }
        int Save();
    }
}
