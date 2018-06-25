using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abitasharp.Controllers.Interfacce;
using Microsoft.AspNetCore.Mvc;

namespace Abitasharp.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogin _login;

        public AccountController (ILogin login)
        {
            _login = login;
        }
        public IActionResult Index()
        {
            return View("Login");
        }

        public IActionResult Registrazione()
        {
            return View("Registrazione");
        }

        [Route("login")]
        public IActionResult Logout()
        {
            return View("/Views/Auth/login");
        }
    }
}