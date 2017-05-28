using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMAPBD.ViewModel;
namespace IMAPBD.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
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

        public ActionResult Lugares()
        {
            return View();
        }

        public ActionResult Ver_Paquete()
        {
            return View();
        }

        public ActionResult CrearPaquete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if(model.User.Equals("admin") && model.User.Equals("1234"))
            {
                RedirectToAction("Index", "Admin");
            }
            return View();
        }
    }
}


