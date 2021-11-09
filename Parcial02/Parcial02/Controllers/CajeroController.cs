using Parcial02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parcial02.Controllers
{
    public class CajeroController : Controller
    {
        // GET: Cajero
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult IndexCajero()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Correcto()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Incorrecto()
        {
            return View();
        }


        [HttpPost]
        public ActionResult IndexCajero(ClsCajero caj)
        {

            if (caj.monto % 5 == 0)
            {
                return Redirect("Correcto");
            }
            else
            {
                return Redirect("Incorrecto");
            }
            return View();

        }
    }
}