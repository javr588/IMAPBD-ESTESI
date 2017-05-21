using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IMAPBD.Models;
namespace IMAPBD.ViewModel.AdminViewModel
{
    public class CrearPaquetesViewModel
    {
        public String InformacionGeneral { get; set; }
        public String Tipo { get; set; }
        public String Origen { get; set; }
        public String Destino { get; set; }
        public String FechaSalida { get; set; }
        public String FechaLlegada { get; set; }
        public String FechaVencimiento { get; set; }
        public Decimal Costo { get; set; }
        public String Moneda { get; set; }
        public List<ActividadesModels> LstActividades { get; set; }

        public CrearPaquetesViewModel()
        {
            LstActividades = new List<ActividadesModels>();     
        }
    }
}