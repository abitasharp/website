
using Abitasharp.Models.Validators;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Controllers.GestioneAnnunci
{
    public class CreaAnnuncio : ICreaAnnuncio
    {

        public IActionResult show()
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> crea(CreaAnnuncioValidator data)
        {
            throw new NotImplementedException();
        }

    }
}
