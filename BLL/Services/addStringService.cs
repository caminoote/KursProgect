using BLL.Interfaces;
using DAL;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EnterStringService : IEnterStringService
    {
        private IDbRepos db;
        public EnterStringService(IDbRepos repos)
        {
            db = repos;
        }

        public bool MakeEnterString(addStringModel orderDto)
        {
            List<Product> addProduct = new List<Product>();

            addString order;
            order = new addString
            {
                DateCreate = orderDto.DateCreate,
                StorageKool = orderDto.StorageKool,
                Price = orderDto.Price,
                idProduct = orderDto.idProduct,

            };
            db.addStrings.Create(order);
            if (db.Save() > 0)
                return true;
            return false;

        }



    }
}
