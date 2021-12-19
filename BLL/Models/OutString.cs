using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OutStringModel
    {
        public int idOutString { get; set; }

        public int OutKool { get; set; }

        public DateTime OutDate { get; set; }

        public int idString { get; set; }

        public int? idOut { get; set; }

        public OutStringModel() { }
        public OutStringModel(OutString p)
        {
            idOutString = p.idOutString;
            OutKool = p.idString;
            OutDate = p.OutDate;
            idString = p.idString;
            idOut = p.idOut;
        }
    }
}
