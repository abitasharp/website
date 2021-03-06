﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Controllers.Ricerca
{
    public interface ICercaProfilo
    {
        IActionResult show();

        IActionResult visualizza(String userId);

        void cerca();
    }
}
