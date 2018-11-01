using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abitasharp.Controllers.Ricerca;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Abitasharp.Controllers
{
    public class CercaAnnunciController : Controller
    {
        private readonly ICercaAnnunci _cercaAnnunci;
        private readonly IRegCercaAnnunci _regCercaAnnunci;

        public CercaAnnunciController(ICercaAnnunci cercaAnnunci, IRegCercaAnnunci regCercaAnnunci)
        {
            _cercaAnnunci = cercaAnnunci;
            _regCercaAnnunci = regCercaAnnunci;
        }

        [HttpGet]
        public IActionResult Index()
        {
            if(true)
                return _cercaAnnunci.show();
        }

        [HttpGet]
        public IActionResult Visualizza()
        {
            if (true)
                return _cercaAnnunci.visualizza();
        }
    }
}