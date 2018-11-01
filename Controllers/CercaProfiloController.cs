using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abitasharp.Controllers.Ricerca;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Abitasharp.Controllers
{
    [Authorize]
    public class CercaProfiloController : Controller
    {
        private readonly ICercaProfilo _cercaProfilo;

        public CercaProfiloController(ICercaProfilo cercaProfilo)
        {
            _cercaProfilo = cercaProfilo;
        }

        [HttpGet]
        public IActionResult Index() => _cercaProfilo.show();

        [HttpGet]
        public IActionResult Visualizza(string id) => _cercaProfilo.visualizza(id);
    }
}