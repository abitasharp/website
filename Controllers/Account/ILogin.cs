﻿using Abitasharp.Models.Validators;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Controllers.Account
{
    public interface ILogin
    {
        Task<IActionResult> login(LoginValidator login);

        Task<IActionResult> logout();

        IActionResult show();
    }
}
