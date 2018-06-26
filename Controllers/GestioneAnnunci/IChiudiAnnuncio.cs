using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Controllers.GestioneAnnunci
{
    public interface IChiudiAnnuncio
    {
        IActionResult show();
        Task<IActionResult> chiudiAnnuncio(String id);
    }
}
