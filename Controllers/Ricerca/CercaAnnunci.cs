
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Controllers.Ricerca
{
    public class CercaAnnunci : Controller , ICercaAnnunci
    {
        public void filtra()
        {
            throw new NotImplementedException();
        }

        public IActionResult show()
        {
            return View("Views/Ricerca/CercaAnnunci.cshtml");
        }

        public virtual IActionResult visualizza()
        {
            throw new NotImplementedException();
        }
    }
}
