using Abitasharp.Models.Validators;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Controllers.GestioneProfilo
{
    public interface IModificaInfo
    {
        IActionResult show();


        Task<IActionResult> modificaInfoAzienda(ModificaInfoProfiloValidator data);
        Task<IActionResult> modificaInfoPrivato(ModificaInfoProfiloValidator data);

    }
}
