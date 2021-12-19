using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class addStringModel
    {
        public int idString { get; set; }

        public int AddKool { get; set; }

        public int StorageKool { get; set; }

        public int Price { get; set; }

        public DateTime DateCreate { get; set; }

        public int idSupply { get; set; }

        public int idProduct { get; set; }

        public addStringModel() { }
        public addStringModel(addString m)
        {
            idString = m.idString;
            AddKool = m.AddKool;
            StorageKool = m.StorageKool;
            Price = m.Price;
            DateCreate = m.DateCreate;
            idSupply = m.idSupply;
            idProduct = m.idProduct;
        }
    }
}
