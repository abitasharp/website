using Abitasharp.Controllers.Interfacce;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Controllers.Classi
{
    public class RegCercaAnnunci : CercaAnnunci , IRegCercaAnnunci
    {
        public void preferisci()
        {
            throw new NotImplementedException();
        }

        public void segnala()
        {
            throw new NotImplementedException();
        }

        public override IActionResult visualizza()
        {
            throw new NotImplementedException();
        }
    }
}
