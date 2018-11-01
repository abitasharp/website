using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abitasharp.Controllers.Account;
using Abitasharp.Models;
using Abitasharp.Models.Validators;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Abitasharp.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogin _login;
        private readonly IRegistrazione _registrazione;

        public AccountController(ILogin login, IRegistrazione registrazione)
        {
            _login = login;
            _registrazione = registrazione;
        }

        [HttpGet]
        public IActionResult Index() {
            return _login.show();
        }

        [HttpGet]
        public IActionResult Login() => _login.show();

        [HttpGet]
        public IActionResult Registrazione() => _registrazione.show();

        [HttpGet]
        public Task<IActionResult> Logout() => _login.logout();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginValidator data) { return await _login.login(data); }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registrazione(RegistrazioneValidator data) { return await _registrazione.registra(data); }
    }
}