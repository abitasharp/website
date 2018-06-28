using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abitasharp.Controllers.GestioneProfilo;
using Abitasharp.Models;
using Abitasharp.Models.Validators;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Abitasharp.Controllers
{
    [Authorize(Roles = "Privato, Azienda")]
    public class GestioneProfiloController : Controller
    {
        private readonly IGestioneProfilo _gestioneProfilo;
        private readonly ICancellaProfilo _cancellaProfilo;
        private readonly IModificaInfo _modificaInfo;

        private readonly SignInManager<Utente> _signInManager;


        public GestioneProfiloController(IGestioneProfilo gestioneProfilo,
            ICancellaProfilo cancellaProfilo, 
            IModificaInfo modificaInfo,
            SignInManager<Utente> signInManager)
        {
            _gestioneProfilo = gestioneProfilo;
            _cancellaProfilo = cancellaProfilo;
            _modificaInfo = modificaInfo;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            if (HttpContext.User.IsInRole("Azienda"))
            {
                return _gestioneProfilo.showAzienda();
            }
            else if (HttpContext.User.IsInRole("Privato"))
            {
                return _gestioneProfilo.showPrivato();
            }
            else return RedirectToAction("Index", "Account");
           
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ModificaInfo(ModificaInfoProfiloValidator data) {
            if (HttpContext.User.IsInRole("Azienda"))
            {
                return await _modificaInfo.modificaInfoAzienda(data);
            }
            else if (HttpContext.User.IsInRole("Privato"))
            {
                return await _modificaInfo.modificaInfoPrivato(data);
            }
            else return RedirectToAction("Index", "Account");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Cancella(CancellaProfiloValidator data) {
            return await _cancellaProfilo.cancella(data);
        }
    }
}