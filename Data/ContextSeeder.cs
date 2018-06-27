using Abitasharp.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Data
{
    public class ContextSeeder
    {
        private ApplicationContext _context;
        private UserManager<Utente> _userManager;

        public ContextSeeder(ApplicationContext context, UserManager<Utente> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public void SeedAsync()
        {
            ProfiloAzienda profiloAzienda = new ProfiloAzienda();
            profiloAzienda.Id = Guid.NewGuid().ToString();
            profiloAzienda.NomeAzienda = "Tempocasa";
            profiloAzienda.PartitaIVa = "30528598402";
            profiloAzienda.Email = "tempocasa@gmail.com";
            profiloAzienda.Recapiti.Tel1 = "0989879876";


            _userManager.CreateAsync(profiloAzienda, "password");

            return;

        }
    }
}
