using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abitasharp.Controllers.Interfacce;
using Microsoft.AspNetCore.Mvc;

namespace Abitasharp.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IAmministraPiattaforma _dashboard;
        private readonly IEliminaAnnuncio _eliminaAnnuncio;
        private readonly IBannaUtente _bannaUtente;

        public DashboardController(IAmministraPiattaforma dashboard, IEliminaAnnuncio eliminaAnnuncio, IBannaUtente bannaUtente)
        {
            _dashboard = dashboard;
            _eliminaAnnuncio = eliminaAnnuncio;
            _bannaUtente = bannaUtente;
        }
        public IActionResult Index() => _dashboard.show();

        public IActionResult EliminaAnnuncio() => _eliminaAnnuncio.show();

        public IActionResult BannaUtente() => _bannaUtente.show();

        public IActionResult Log() => _dashboard.showLog();

        public IActionResult Segnalazioni() => _dashboard.showSegnalazioni();
    }
}