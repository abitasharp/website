using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Controllers.Amministrazione
{
    public interface IAmministraPiattaforma
    {
        IActionResult show();

        IActionResult showSegnalazioni();

        IActionResult showLog();
    }
}
