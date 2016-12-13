using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Formulario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Formulario(string nombre)
        {
            ViewBag.Nombre = nombre;

            return View();
        }
    }
}