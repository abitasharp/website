using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abitasharp.Controllers.Interfacce;
using Abitasharp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Abitasharp.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogin _login;
        private readonly ApplicationContext _context;

        public AccountController (ILogin login, ApplicationContext context)
        {
            _login = login;
            _context = context;
        }
        public IActionResult Index()
        {
            return View("Login");
        }

        public IActionResult Registrazione()
        {
            /*ProfiloAzienda profiloAzienda = new ProfiloAzienda();
            profiloAzienda.ID = "idcazzutissimo87";
            profiloAzienda.Email = "gennarino@gmail.com";
            profiloAzienda.NomeAzienda = "ciao";
            profiloAzienda.PartitaIVa = "iushckuschkds";
            profiloAzienda.PasswordHash = "dzfsfdsf";

            _context.ProfiliAzienda.Add(profiloAzienda);
            _context.SaveChanges();
            */
            ProfiloAzienda profiloAzienda = _context.ProfiliAzienda.Find("idcazzutissimo87");
            ViewData["nomeAzienda"] = profiloAzienda.NomeAzienda;
            
     
            return View("Views/Auth/Registrazione.cshtml");
        }

        [Route("login")]
        public IActionResult Logout()
        {
            return View("/Views/Auth/login");
        }
    }
}