
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Controllers.Amministrazione
{
    public class AmministraPiattaforma : Controller , IAmministraPiattaforma
    {
        public IActionResult show()
        {
            return View("Views/Amministrazione/AmministraPiattaforma.cshtml");
        }

        public IActionResult showLog()
        {
            return View("Views/Amministrazione/Log.cshtml");
        }

        public IActionResult showSegnalazioni()
        {
            return View("Views/Amministrazione/Segnalazioni.cshtml");
        }
    }
}
