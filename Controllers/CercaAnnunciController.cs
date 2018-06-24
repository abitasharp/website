using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Abitasharp.Controllers
{
    public class CercaAnnunciController : Controller
    {
        public IActionResult Index()
        {
            return View("CercaAnnunci");
        }

        public IActionResult Visualizza()
        {
            return View("Annuncio");
        }
    }
}