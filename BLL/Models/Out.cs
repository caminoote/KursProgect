using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OutModel
    {
        public int idOut { get; set; }

        public DateTime OutDate { get; set; }

        public int idShop { get; set; }

        public int? IdUser { get; set; }

        public OutModel() { }
        public OutModel(Out p)
        {
            idOut = p.idOut;
            OutDate = p.OutDate;
            idShop = p.idShop;
            IdUser = p.IdUser;
        }
    }
}
