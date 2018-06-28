using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abitasharp.Controllers.Amministrazione;
using Abitasharp.Models.Validators;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Abitasharp.Controllers
{
    [Authorize(Roles = "Admin")]
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

        [HttpGet]
        public IActionResult Index() => _dashboard.show();

        [HttpGet]
        public IActionResult EliminaAnnuncio() => _eliminaAnnuncio.show();

        [HttpGet]
        public IActionResult BannaUtente() => _bannaUtente.show();

        [HttpGet]
        public IActionResult Log() => _dashboard.showLog();

        [HttpGet]
        public IActionResult Segnalazioni() => _dashboard.showSegnalazioni();



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EliminaAnnuncio(EliminaAnnuncioValidator data) { return await _eliminaAnnuncio.elimina(data); }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BannaUtente(BannaUtenteValidator data) { return await _bannaUtente.ban(data); }
    }
}