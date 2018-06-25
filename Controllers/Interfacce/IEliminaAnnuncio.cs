using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Controllers.Interfacce
{
    interface IEliminaAnnuncio
    {

        IActionResult show();

        IActionResult elimina();

    }
}
