using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TraderModel
    {
        public int idTrader { get; set; }

        public string NameTrader { get; set; }

        public string Locate { get; set; }

        public TraderModel() { }
        public TraderModel(Trader p)
        {
            idTrader = p.idTrader;
            NameTrader = p.NameTrader;
            Locate = p.Locate;
        }
    }
}
