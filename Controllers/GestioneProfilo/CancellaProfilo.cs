
using Abitasharp.Models.Validators;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Controllers.GestioneProfilo
{
    public class CancellaProfilo : ICancellaProfilo
    {
        public Task<IActionResult> cancella(CancellaProfiloValidator data)
        {
            throw new NotImplementedException();
        }

        public IActionResult show()
        {
            throw new NotImplementedException();
        }
    }
}
