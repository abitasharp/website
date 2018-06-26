using Abitasharp.Models.Validators;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Controllers.GestioneProfilo
{
    public interface ICancellaProfilo
    {
        IActionResult show();

        Task<IActionResult> cancella(CancellaProfiloValidator data);
    }
}
