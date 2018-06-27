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
        //private readonly UserManager<Utente> _userManager;
        //private readonly SignInManager<Utente> _signInManager;
        /*private readonly IEmailSender _emailSender;*/
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogin login, IRegistrazione registrazione,
            //UserManager<Utente> userManager, SignInManager<Utente> signInManager,
            ILogger<AccountController> logger)
        {
            _login = login;
            _registrazione = registrazione;
           // _userManager = userManager;
           // _signInManager = signInManager;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index() {
            _logger.LogError("AAAAAAHHHHHHH");
            return _login.show();
        }

        [HttpGet]
        public IActionResult Login() => _login.show();

        [HttpGet]
        public IActionResult Registrazione() => _registrazione.show();

        [HttpGet]
        public IActionResult Logout() => _login.logout();


        [HttpPost]
        public async Task<IActionResult> Login(LoginValidator data) { return await _login.login(data); }

        [HttpPost]
        public async Task<IActionResult> Registrazione(RegistrazioneValidator data) { return await _registrazione.registra(data); }
    }
}