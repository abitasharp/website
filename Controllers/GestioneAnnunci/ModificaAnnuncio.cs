using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abitasharp.Models.Validators;
using Microsoft.AspNetCore.Mvc;

namespace Abitasharp.Controllers.GestioneAnnunci
{
    public class ModificaAnnuncio : IModificaAnnuncio
    {

        public Task<IActionResult> modificaAnnuncio(ModificaAnnuncioValidator data)
        {
            throw new NotImplementedException();
        }

        public IActionResult show()
        {
            throw new NotImplementedException();
        }
    }
}
