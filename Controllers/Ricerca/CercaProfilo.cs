
using Abitasharp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Controllers.Ricerca
{
    public class CercaProfilo : Controller , ICercaProfilo
    {
        private ApplicationContext _context;
        private ILogger<CercaProfilo> _logger;
        public CercaProfilo(ApplicationContext context, ILogger<CercaProfilo> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void cerca()
        {
            throw new NotImplementedException();
        }

        public IActionResult show()
        {
            return View("Views/Ricerca/CercaProfilo.cshtml");
        }

        public IActionResult visualizza(String userId)
        {
            throw new NotImplementedException();
        }
    }
}
