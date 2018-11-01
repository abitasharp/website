using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Abitasharp.Models;
using Abitasharp.Models.Validators;
using Abitasharp.Controllers.GestioneAnnunci;
using Microsoft.AspNetCore.Authorization;

namespace Abitasharp.Controllers
{
    [Authorize(Roles = "Privato, Azienda")]
    public class GestioneAnnunciController : Controller
    {
        private readonly IGestioneAnnunci _gestioneAnnunci;
        private readonly ICreaAnnuncio _creaAnnuncio;
        private readonly IModificaAnnuncio _modificaAnnuncio;
        private readonly IChiudiAnnuncio _chiudiAnnuncio;

        public GestioneAnnunciController(IGestioneAnnunci gestioneAnnunci, ICreaAnnuncio creaAnnuncio, IModificaAnnuncio modificaAnnuncio, IChiudiAnnuncio chiudiAnnuncio)
        {
            _gestioneAnnunci = gestioneAnnunci;
            _creaAnnuncio = creaAnnuncio;
            _modificaAnnuncio = modificaAnnuncio;
            _chiudiAnnuncio = chiudiAnnuncio;
        }

        [HttpGet]
        public IActionResult Index() => _gestioneAnnunci.show();

        [HttpGet]
        public IActionResult Crea() => _creaAnnuncio.show();

        [HttpGet]
        public IActionResult Modifica() => _modificaAnnuncio.show();

        [HttpGet]
        public IActionResult Chiudi() => _chiudiAnnuncio.show();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crea(CreaAnnuncioValidator data) { return await _creaAnnuncio.crea(data); }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Modifica(ModificaAnnuncioValidator data) { return await _modificaAnnuncio.modificaAnnuncio(data); }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Chiudi(String id) { return await _chiudiAnnuncio.chiudiAnnuncio(id); }

    }
}

