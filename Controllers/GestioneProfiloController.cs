using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abitasharp.Controllers.GestioneProfilo;
using Abitasharp.Models.Validators;
using Microsoft.AspNetCore.Mvc;

namespace Abitasharp.Controllers
{
    public class GestioneProfiloController : Controller
    {
        private readonly IGestioneProfilo _gestioneProfilo;
        private readonly ICancellaProfilo _cancellaProfilo;
        private readonly IModificaInfo _modificaInfo;

        public GestioneProfiloController(IGestioneProfilo gestioneProfilo, ICancellaProfilo cancellaProfilo, IModificaInfo modificaInfo)
        {
            _gestioneProfilo = gestioneProfilo;
            _cancellaProfilo = cancellaProfilo;
            _modificaInfo = modificaInfo;
        }


        [HttpGet]
        public IActionResult Index() => _gestioneProfilo.show();


        [HttpPost]
        public async Task<IActionResult> modificaInfo(ModificaInfoProfiloValidator data) {
            if (true)
                return await _modificaInfo.modificaInfoPrivato(data);
        }
        [HttpPost]
        public async Task<IActionResult> Cancella(CancellaProfiloValidator data) { return await _cancellaProfilo.cancella(data); }
    }
}