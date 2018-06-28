
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
    public class Login : Controller, ILogin
    {
        private SignInManager<Utente> _signInManager;
        private ILogger<Login> _logger;
        private ApplicationContext _context;

        public Login(SignInManager<Utente> signInManager, ILogger<Login> logger, ApplicationContext context)
        {
            _signInManager = signInManager;
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> login(LoginValidator data)
        {
            if (ModelState.IsValid)
            {
                Utente utente = _context.Utenti.Where(u => u.Email == data.Email).First();
                Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(utente, data.Password, true, false);
                if (result.Succeeded)
                {
                    _logger.LogInformation("Login succeded");
                    return RedirectToAction("Index", "CercaAnnunci");
                }
                else
                {
                    _logger.LogInformation("Login failed");
                    return RedirectToAction("Index", "Account");
                }
            }
            else
            {
                return RedirectToAction("Index", "Account");
            }
        }

        public async Task<IActionResult> logout()
        {
            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out.");
            return RedirectToAction("Index", "CercaAnnunci");
        }

        public IActionResult show()
        {
            return View("Views/Account/Login.cshtml");
        }
    }
}
