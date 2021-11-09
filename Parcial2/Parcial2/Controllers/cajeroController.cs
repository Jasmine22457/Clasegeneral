using Parcial2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parcial2.Controllers
{
    public class cajeroController : Controller
    {

        [HttpGet]

        public ActionResult index1()
        {

            return View();
        }

        [HttpPost]

        public ActionResult index1(Cajero cajero)
        {
            if (cajero.Cantidad % 5 == 0)
            {

                return Redirect("MostrarDatos");

            }
            else
            {

                return Redirect("Error");
            }

        }


        [HttpGet]

        public ActionResult Error()
        {

            return View();
        }
        [HttpGet]

        public ActionResult MostrarDatos()
        {

            return View();
        }
    }
}
