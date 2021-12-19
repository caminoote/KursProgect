using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SupplyModel
    {
        public int idSupply { get; set; }

        public DateTime EnterDate { get; set; }

        public int idTrader { get; set; }

        public int idUser { get; set; }

        public SupplyModel() { }
        public SupplyModel(Supply p)
        {
            idSupply = p.idSupply;
            EnterDate = p.EnterDate;
            idTrader = p.idTrader;
            idUser = p.idUser;
        }
    }
}
