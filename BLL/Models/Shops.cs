using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ShopsModel
    {
        public int idShop { get; set; }

        public string Locate { get; set; }

        public ShopsModel() { }
        public ShopsModel(Shops p)
        {
            idShop = p.idShop;
            Locate = p.Locate;
        }
    }
}
