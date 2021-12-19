using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductModel
    {
        public int idProduct { get; set; }
        public int? TimeUse { get; set; }
        public string NameProduct { get; set; }
        public int idTypeGoods { get; set; }

        public ProductModel() { }
        public ProductModel(Product p)
        {
            idProduct = p.idProduct;
            TimeUse = p.TimeUse;
            NameProduct = p.NameProduct;
            idTypeGoods = p.idTypeGoods;
        }


    }
}
