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
    public class Registrazione : Controller , IRegistrazione
    {
       private UserManager<Utente> _userManager;
       private ILogger<AccountController> _logger;

        public Registrazione(UserManager<Utente> userManager, ILogger<AccountController> logger)
        {
            _userManager = userManager;
            _logger = logger;
        }

        public async Task<IActionResult> registra(RegistrazioneValidator data)
        {
            if (ModelState.IsValid)
            {
                IdentityResult result = null;
                if (data.TipoProfilo == TipoProfilo.AZIENDA) {
                    ProfiloAzienda azienda = new ProfiloAzienda();
                    azienda.Id = Guid.NewGuid().ToString();
                    azienda.UserName = azienda.Id;
                    azienda.Email = data.EmailAzienda;
                    azienda.NomeAzienda = data.NomeAzienda;
                    azienda.PartitaIVa = data.PartitaIva;
                    result = await _userManager.CreateAsync(azienda, data.PasswordAzienda);
                    if (result.Succeeded)
                    {
                        var roleResult = await _userManager.AddToRoleAsync(azienda, "Azienda");
                        _logger.LogInformation("Registrazione esito:" + roleResult.Succeeded);
                        return RedirectToAction("Index", "Account");
                    }
                    else
                    {
                        _logger.LogError("Registrazione fallita: " + result.Errors);
                        ViewData["Error"] = result.Errors.ToString();
                        return View("Views/Shared/Error.cshtml");
                    }
                } else if (data.TipoProfilo == TipoProfilo.PRIVATO) {
                    ProfiloPrivato privato = new ProfiloPrivato();
                    privato.Id = Guid.NewGuid().ToString();
                    privato.UserName = privato.Id;
                    privato.Email = data.EmailPrivato;
                    privato.Nome = data.Nome;
                    privato.Cognome = data.Cognome;
                    privato.DataNascita = DateTime.Parse(data.DataNascita);
                    privato.Recapiti.Tel1 = data.TelefonoPrivato;
                    result = await _userManager.CreateAsync(privato, data.PasswordPrivato);
                    if (result.Succeeded)
                    {
                        var roleResult = await _userManager.AddToRoleAsync(privato, "Privato");
                        _logger.LogInformation("Registrazione esito:" + roleResult.Succeeded);
                        return RedirectToAction("Index", "CercaAnnunci");
                    }
                    else
                    {
                        _logger.LogError("Registrazione fallita: " + result.Errors);
                        ViewData["Error"] = result.Errors.ToString();
                        return View("Views/Shared/Error.cshtml");
                    }
                } else {
                    _logger.LogError(data.TipoProfilo + " valori passati");
                    result = IdentityResult.Failed();
                }
            }

            return View("Views/Account/Registrazione.cshtml");
        }

        public IActionResult show()
        {
            return View("Views/Account/Registrazione.cshtml");
        }
    }
}
