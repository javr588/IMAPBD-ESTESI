using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMAPBD.Models
{
    public class BusquedaCiudadModels
    {
         public List<CiudadDiaModels> BusquedaCiudad { get; set; }

         public BusquedaCiudadModels()
        {
            BusquedaCiudad = new List<CiudadDiaModels>();     
        }
    }
}