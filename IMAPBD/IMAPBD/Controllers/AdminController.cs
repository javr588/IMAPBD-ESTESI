using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IMAPBD.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult CrearPaquete()
        {

            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Registro_Empresa()
        {
            return View("~/Views/Admin/Registro_Empresa.cshtml");
        }

        public ActionResult Registro_User()
        {
            return View("~/Views/Admin/Registro_User.cshtml");
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

        

    }
}
