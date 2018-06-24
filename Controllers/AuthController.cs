using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Abitasharp.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View("Login");
        }

        public IActionResult Registrazione()
        {
            return View("Registrazione");
        }

        public IActionResult Logout()
        {
            return View("Login");
        }
    }
}