using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoDAS.Models;

namespace ProyectoDAS.Controllers
{
    public class AccesoController : Controller
    {



        // GET: Acceso
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Registro()
        {
            return View();
        }


    }
}