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
            var listaPaquete = obj.QueryPaquete("Madrid");
            return View("Index", listaPaquete);

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
            var listaPaquete = obj.QueryPaquete("Madrid");
            return View("Index_User", listaPaquete);
        }

         [HttpPost]
        public ActionResult Lugares(string lugar)
        {
            #region Query Lista cuidad: Retorna todos los dias calificados por ciudad de busqueda
            var lugares = obj.QueryCity(lugar);
            #endregion
            return View("Lugares",lugares);
        }

        [HttpPost]
         public ActionResult Paquetes(string destino)
        {
            #region Query Paquete: Retorna todos los paquetes por destino
            var listaPaquete = obj.QueryPaquete(destino);
            #endregion
            return View("Paquetes", listaPaquete.AsEnumerable());
        }

        [HttpPost]
        public ActionResult Paises(string pais)
        {
            #region Query Lista Pais: Retorna todas las ciudades calificadas por pais de busqueda
            var listaPais = obj.QueryCountry(pais);
            #endregion
            return View(listaPais);
        }

        [HttpPost]
        public ActionResult Ver_Paquete( CrearPaquetesViewModel paquete)
        {
            return View(paquete);
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
                    var listaPaquete = obj.QueryPaquete("Madrid");
                    
                    return View("Index", listaPaquete);
                }

                if (model.User.Equals("user") && model.Password.Equals("1234"))
                {
                    var listaPaquete = obj.QueryPaquete("Madrid");
                    return View("Index_User", listaPaquete);
                }
            } 
          return View();
        }

       
        
       
    }
}


