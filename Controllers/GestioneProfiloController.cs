using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abitasharp.Controllers.Interfacce;
using Microsoft.AspNetCore.Mvc;

namespace Abitasharp.Controllers
{
    public class GestioneProfiloController : Controller
    {
        private readonly IGestioneProfilo _gestioneProfilo;
        private readonly ICancellaProfilo _cancellaProfilo;

        public GestioneProfiloController(IGestioneProfilo gestioneProfilo, ICancellaProfilo cancellaProfilo)
        {
            _gestioneProfilo = gestioneProfilo;
            _cancellaProfilo = cancellaProfilo;
        }

        public IActionResult Index() => _gestioneProfilo.show();

        public IActionResult Elimina() => _cancellaProfilo.show();
    }
}