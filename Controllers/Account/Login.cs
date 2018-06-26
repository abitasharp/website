
using Abitasharp.Models.Validators;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Controllers.Account
{
    public class Login : Controller, ILogin
    {
        public IActionResult login()
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> login(LoginValidator data)
        {
            throw new NotImplementedException();
        }

        public IActionResult logout()
        {
            throw new NotImplementedException();
        }

        public IActionResult show()
        {
            throw new NotImplementedException();
        }
    }
}
