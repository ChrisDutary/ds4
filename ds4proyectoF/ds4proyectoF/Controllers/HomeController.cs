using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ds4proyectoF.Models;

namespace ds4proyectoF.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Menu()
        {
            return View();
        }

        public ActionResult Carrito()
        {
            return View();
        }

        public ActionResult OpcionesEntrega()
        {
            return View();
        }
        public ActionResult ConfirmarPedido()
        {
            return View();
        }
    }
}