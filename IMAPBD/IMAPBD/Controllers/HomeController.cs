using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMAPBD.ViewModel;
using IMAPBD.Models;
using IMAPBD.ViewModel.AdminViewModel;

namespace IMAPBD.Controllers
{
    public class HomeController : Controller
    {
        public string user="";
        public TweetClass obj = new TweetClass();
        public ActionResult Funciones() {
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
             //  var listaCuidad = obj.QueryCity("Florence");
            #endregion

            #region Query Paquete: Retorna todos los paquetes por destino
            //var listaPaquete = obj.QueryPaquete("in");
            #endregion
            return View();
        }
        public ActionResult Index()
        {
            if (!string.Equals(user,"admin"))
                return View();
            else
                return View("~/Views/Home/Index_User.cshtml");
        }


        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Registro_Empresa()
        {
            return View();
        }

        public ActionResult Registro_User()
        {
            return View();
        }

        public ActionResult Index_User()
        {
            return View();
        }

         [HttpPost]
        public ActionResult Lugares(BusquedaViewModel lugar)
        {
            #region Query Lista cuidad: Retorna todos los dias calificados por ciudad de busqueda
             BusquedaCiudadModels listaCuidad = new BusquedaCiudadModels();
             foreach(var busq in obj.QueryCity(lugar.Busqueda)){
                 listaCuidad.BusquedaCiudad.Add(busq);
             }
            
            #endregion
            return View("Lugares",listaCuidad);
        }

        [HttpPost]
         public ActionResult Paquetes(BusquedaViewModel destino)
        {
            #region Query Paquete: Retorna todos los paquetes por destino
            var listaPaquete = obj.QueryPaquete(destino.Busqueda);
            #endregion
            return View(listaPaquete);
        }

        [HttpPost]
        public ActionResult Paises(BusquedaViewModel pais)
        {
            #region Query Lista Pais: Retorna todas las ciudades calificadas por pais de busqueda
           /* BusquedaPaisViewModel listaPais = new BusquedaPaisViewModel();
            foreach (var busq in obj.QueryCountry(pais.Busqueda)) {
                listaPais.BusquedaPais.Add(busq);
            }*/
            #endregion
            return View(obj.QueryCountry(pais.Busqueda));
        }
        public ActionResult Ver_Paquete()
        {
            return View();
        }

        public ActionResult CrearPaquete()
        {
             

            return View("~/Views/Admin/CrearPaquete.cshtml");
        }

        [HttpPost]
        public ActionResult InsertarPaquete(CrearPaquetesViewModel Paquete)
        {
          obj.InsertPaquete(Paquete.Destino, Paquete.Origen,Convert.ToDateTime(Paquete.FechaLlegada).ToUniversalTime(), Convert.ToDateTime(Paquete.FechaSalida).ToUniversalTime(), Convert.ToDateTime(Paquete.FechaVencimiento).ToUniversalTime() ,Paquete.InformacionGeneral, Paquete.Moneda, Convert.ToDouble(Paquete.Costo), "Viajar S.A."/*Paquete.Empresa*/, Paquete.LstActividades);

            return View("~/Views/Admin/CrearPaquete.cshtml");
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (model.User != null)
            {
                user = model.User;
                if (model.User.Equals("admin") && model.Password.Equals("1234"))
                {
                    return View("~/Views/Home/Index.cshtml");
                }

                if (model.User.Equals("user") && model.Password.Equals("1234"))
                {
                    return View("~/Views/Home/Index_User.cshtml");
                }
            } 
            return View();
        }

       
        
       
    }
}


