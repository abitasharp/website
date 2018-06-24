using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Abitasharp.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View("Dashboard");
        }

        public IActionResult EliminaAnnuncio()
        {
            return View("EliminaAnnuncio");
        }

        public IActionResult BannaUtente()
        {
            return View("BannaUtente");
        }

        public IActionResult Log()
        {
            return View("Log");
        }

        public IActionResult Segnalazioni()
        {
            return View("Segnalazioni");
        }
    }
}