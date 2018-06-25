using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Abitasharp.Models;
using Abitasharp.Controllers.Interfacce;

namespace Abitasharp.Controllers
{
    public class GestioneAnnunciController : Controller
    {
        private readonly IGestioneAnnunci _gestioneAnnunci;

        public GestioneAnnunciController(IGestioneAnnunci gestioneAnnunci)
        {
            _gestioneAnnunci = gestioneAnnunci;
        }

        // GET: Examples
        public async Task<IActionResult> Index() => _gestioneAnnunci.show();



        // GET: Examples/Create
        public async Task<IActionResult> Crea()
        {
            return View("EditAnnuncio");
        }

        public async Task<IActionResult> Modifica()
        {
            return View("EditAnnuncio");
        }

        public async Task<IActionResult> Chiudi()
        {
            return View("ChiudiAnnuncio");
        }

        

       

        

        

        
    }
}

