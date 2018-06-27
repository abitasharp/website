
using Abitasharp.Models.Validators;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Controllers.GestioneProfilo
{
    public class ModificaInfo : IModificaInfo
    {
        public Task<IActionResult> modificaInfoAzienda(ModificaInfoProfiloValidator data)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> modificaInfoPrivato(ModificaInfoProfiloValidator data)
        {
            throw new NotImplementedException();
        }

        public IActionResult show()
        {
            throw new NotImplementedException();
        }
    }
}
