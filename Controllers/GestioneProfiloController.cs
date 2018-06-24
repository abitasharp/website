using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Abitasharp.Controllers
{
    public class GestioneProfiloController : Controller
    {
        public IActionResult Index()
        {
            return View("ProfiloPrivato");
        }

        public IActionResult Elimina()
        {
            return View("EliminaProfilo");
        }
    }
}