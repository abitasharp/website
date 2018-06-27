
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
        private ILogger<Registrazione> _logger;


        public Registrazione(UserManager<Utente> userManager, ILogger<Registrazione> logger)
        {
            _userManager = userManager;
            _logger = logger;
        }


        public async Task<IActionResult> registra(RegistrazioneValidator data)
        {
            if (ModelState.IsValid)
            {
                IdentityResult result = null;
                if (data.Azienda)
                {
                    ProfiloAzienda azienda = new ProfiloAzienda();
                    azienda.Id = Guid.NewGuid().ToString();
                    azienda.Email = data.Email;
                    azienda.NomeAzienda = data.NomeAzienda;
                    azienda.PartitaIVa = data.PartitaIva;
                    result = await _userManager.CreateAsync(azienda, data.Password);
                } else if (data.Privato)
                {
                    ProfiloPrivato privato = new ProfiloPrivato();
                    privato.Id = Guid.NewGuid().ToString();
                    privato.Email = data.Email;
                    privato.Nome = data.Nome;
                    privato.Cognome = data.Cognome;
                    privato.DataNascita = data.DataNascita;
                    privato.Recapiti.Tel1 = data.Telefono;
                    result = await _userManager.CreateAsync(privato, data.Password);
                }

                if (result.Succeeded)
                {
                    _logger.LogInformation("Registrazione riuscita");
                    return View("Views/Ricerca/CercaAnnunci.cshtml");
                } else
                {
                    _logger.LogError("Registrazione fallita: " + result.Errors);
                    return View("Error");
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
