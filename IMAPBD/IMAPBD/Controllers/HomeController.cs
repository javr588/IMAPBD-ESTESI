using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IMAPBD.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Load_Tweet()
        {
            ViewBag.Message = "tweet loader";

            return View();
        }

        public ActionResult crearPaquete()
        {
            ViewBag.Message = "crearPaquete";

            return View();
        }

        public ActionResult index_user()
        {
            ViewBag.Message = "index_User";

            return View();
        }

        public ActionResult login()
        {
            ViewBag.Message = "login";

            return View();
        }

        public ActionResult lugares()
        {
            ViewBag.Message = "lugares";

            return View();
        }


        public ActionResult paquete()
        {
            ViewBag.Message = "paquete";

            return View();
        }


        public ActionResult registro_empresa()
        {
            ViewBag.Message = "registro_empresa";

            return View();
        }


        public ActionResult registro_user()
        {
            ViewBag.Message = "registro_user";

            return View();
        }

    }
}
