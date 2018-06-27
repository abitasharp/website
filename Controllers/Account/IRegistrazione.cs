using Abitasharp.Models;
using Abitasharp.Models.Validators;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Controllers.Account
{
    public interface IRegistrazione
    {
        Task<IActionResult> registra(RegistrazioneValidator data);
        IActionResult show();
    }
}
