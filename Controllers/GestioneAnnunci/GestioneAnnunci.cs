
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Controllers.GestioneAnnunci
{
    public class GestioneAnnunci : Controller, IGestioneAnnunci
    {
        public IActionResult show()
        {
            return View("Views/GestioneAnnunci/GestioneAnnunci.cshtml");
        }
    }
}
