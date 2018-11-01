
using Abitasharp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Abitasharp.Controllers.GestioneProfilo
{
    public class GestioneProfilo : Controller, IGestioneProfilo
    {
        private readonly UserManager<Utente> _userManager;
        private readonly ApplicationContext _context;
        private readonly ILogger<GestioneProfilo> _logger;
        private readonly IHttpContextAccessor _httpContext;

        public GestioneProfilo(ApplicationContext context,
            UserManager<Utente> userManager,
            ILogger<GestioneProfilo> logger,
            IHttpContextAccessor httpContext)
        {
            _context = context;
            _userManager = userManager;
            _logger = logger;
            _httpContext = httpContext;
        }

        public IActionResult showAzienda()
        {
            string uId = _httpContext.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            Task<Utente> u = _userManager.FindByIdAsync(uId);
            Task.WaitAll(u);
            ViewData["NomeAzienda"] = ((ProfiloAzienda) u.Result).NomeAzienda;
            ViewData["PartitaIva"] = ((ProfiloAzienda)u.Result).PartitaIVa;

            ViewData["Email1"] = ((ProfiloAzienda)u.Result).Recapiti.Email1;
            ViewData["Email2"] = ((ProfiloAzienda)u.Result).Recapiti.Email2;
            ViewData["Email3"] = ((ProfiloAzienda)u.Result).Recapiti.Email3;
            ViewData["Tel1"] = ((ProfiloAzienda)u.Result).Recapiti.Tel1;
            ViewData["Tel2"] = ((ProfiloAzienda)u.Result).Recapiti.Tel2;
            ViewData["Tel3"] = ((ProfiloAzienda)u.Result).Recapiti.Tel3;

            return View("Views/GestioneProfilo/ProfiloAzienda.cshtml");
        }
        public IActionResult showPrivato()
        {
            string uId = _httpContext.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            Task<Utente> u = _userManager.FindByIdAsync(uId);
            Task.WaitAll(u);
            ViewData["Nome"] = ((ProfiloPrivato)u.Result).Nome;
            ViewData["Cognome"] = ((ProfiloPrivato)u.Result).Cognome;
            ViewData["DataNascita"] = ((ProfiloPrivato)u.Result).DataNascita.Date.ToString();

            ViewData["Email1"] = ((ProfiloPrivato)u.Result).Recapiti.Email1;
            ViewData["Email2"] = ((ProfiloPrivato)u.Result).Recapiti.Email2;
            ViewData["Email3"] = ((ProfiloPrivato)u.Result).Recapiti.Email3;
            ViewData["Tel1"] = ((ProfiloPrivato)u.Result).Recapiti.Tel1;
            ViewData["Tel2"] = ((ProfiloPrivato)u.Result).Recapiti.Tel2;
            ViewData["Tel3"] = ((ProfiloPrivato)u.Result).Recapiti.Tel3;

            return View("Views/GestioneProfilo/ProfiloPrivato.cshtml");
        }
    }
}
