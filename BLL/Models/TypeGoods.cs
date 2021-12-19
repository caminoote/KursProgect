using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TypeGoodsModel
    {
        public int idTypeGoods { get; set; }
        public string TypeGoods { get; set; }

        public TypeGoodsModel() { }
        public TypeGoodsModel(typegoods m)
        {
            idTypeGoods = m.idTypeGoods;
            TypeGoods = m.TypeGoods1;
        }
    }
}
