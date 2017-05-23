using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMAPBD.Models;

namespace IMAPBD.Controllers
{
    public class Default1Controller : Controller
    {
        //
        // GET: /Default1/

        public ActionResult Index()
        {
            TweetClass obj = new TweetClass();
            #region Insertar Paquete
            /*  
            List<ActividadesModels> act = new List<ActividadesModels>();
            ActividadesModels actemp = new ActividadesModels();
            actemp.Tipo="inserta";
            actemp.Origen="la";
            actemp.Destino="maldita";
            actemp.FechaSalida = DateTime.Now.ToShortDateString();
            actemp.FechaLlegada = DateTime.Now.ToShortDateString();
            actemp.Costo = 6.7M;
            actemp.Moneda ="actividad";

            act.Add(actemp);
            obj.InsertPaquete("in", "girum", DateTime.Now.ToUniversalTime(), DateTime.Now.ToUniversalTime(), DateTime.Now.ToUniversalTime(),"imus","nocte",6.6,".",act);
           */
            #endregion

            #region Query Lista Pais: Retorna todas las ciudades calificadas por pais de busqueda
          //  var listaPais = obj.QueryCountry("Italy");
            #endregion

            #region Query Lista cuidad: Retorna todos los dias calificados por ciudad de busqueda
        //    var listaCuidad = obj.QueryCity("Florence");
            #endregion

            #region Query Paquete: Retorna todos los paquetes por destino 
            var listaPaquete = obj.QueryPaquete("in");
            #endregion

            return View();
        }

    }
}
