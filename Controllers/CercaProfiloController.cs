using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abitasharp.Controllers.Interfacce;
using Microsoft.AspNetCore.Mvc;

namespace Abitasharp.Controllers
{
    public class CercaProfiloController : Controller
    {
        private readonly ICercaProfilo _cercaProfilo;

        public CercaProfiloController(ICercaProfilo cercaProfilo)
        {
            _cercaProfilo = cercaProfilo;
        }
        public IActionResult Index() => _cercaProfilo.show();

        public IActionResult Visualizza() => _cercaProfilo.visualizza();
    }
}