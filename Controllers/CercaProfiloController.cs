using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Abitasharp.Controllers
{
    public class CercaProfiloController : Controller
    {
        public IActionResult Index()
        {
            return View("CercaProfilo");
        }

        public IActionResult Visualizza()
        {
            return View("Views/GestioneProfilo/ProfiloPrivato");
        }
    }
}