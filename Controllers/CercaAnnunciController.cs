using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abitasharp.Controllers.Interfacce;
using Microsoft.AspNetCore.Mvc;

namespace Abitasharp.Controllers
{
    public class CercaAnnunciController : Controller
    {
        private readonly ICercaAnnunci _cercaAnnunci;

        public CercaAnnunciController(ICercaAnnunci cercaAnnunci)
        {
            _cercaAnnunci = cercaAnnunci;
        }
        public IActionResult Index() => _cercaAnnunci.show();

        public IActionResult Visualizza() => _cercaAnnunci.visualizza();
    }
}