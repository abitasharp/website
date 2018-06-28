
using Abitasharp.Models;
using Abitasharp.Models.Validators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Controllers.GestioneAnnunci
{
    public class CreaAnnuncio : Controller , ICreaAnnuncio
    {
        private readonly UserManager<Utente> _userManager;
        private readonly ApplicationContext _context;
        private readonly ILogger<CreaAnnuncio> _logger;
        private readonly IHttpContextAccessor _httpContext;

        public CreaAnnuncio(ApplicationContext context,
            UserManager<Utente> userManager,
            ILogger<CreaAnnuncio> logger,
            IHttpContextAccessor httpContext)
        {
            _context = context;
            _userManager = userManager;
            _logger = logger;
            _httpContext = httpContext;
        }

        public IActionResult show()
        {
            return View("Views/GestioneAnnunci/CreaAnnuncio.cshtml");
        }

        public Task<IActionResult> crea(CreaAnnuncioValidator data)
        {
            throw new NotImplementedException();
        }

    }
}
