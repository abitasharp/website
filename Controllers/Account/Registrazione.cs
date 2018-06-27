
using Abitasharp.Models.Validators;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Controllers.Account
{
    public class Registrazione : IRegistrazione
    {
        public Task<IActionResult> registra(RegistrazioneValidator data)
        {
            throw new NotImplementedException();
        }

        public IActionResult show()
        {
            throw new NotImplementedException();
        }
    }
}
