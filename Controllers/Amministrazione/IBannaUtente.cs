﻿using Abitasharp.Models.Validators;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Controllers.Amministrazione
{
    public interface IBannaUtente
    {
        IActionResult show();

        Task<IActionResult> ban(BannaUtenteValidator data);
    }
}
