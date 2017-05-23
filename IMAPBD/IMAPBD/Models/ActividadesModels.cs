using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMAPBD.Models
{
    public class ActividadesModels
    {
        public String Tipo { get; set; }
        public String Origen { get; set; }
        public String Destino { get; set; }
        public String FechaSalida { get; set; }
        public String FechaLlegada { get; set; }
        public Decimal Costo { get; set; }
        public string Moneda { get; set; }
    }
}