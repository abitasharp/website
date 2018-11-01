using Abitasharp.Models.Validators;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Controllers.GestioneAnnunci
{
    public interface IModificaAnnuncio
    {
        IActionResult show();
        Task<IActionResult> modificaAnnuncio(ModificaAnnuncioValidator data);
    }
}
