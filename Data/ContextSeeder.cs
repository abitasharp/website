using Abitasharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Data
{
    public class ContextSeeder
    {
        private ApplicationContext _context;

        public ContextSeeder(ApplicationContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            ProfiloAzienda profiloAzienda = new ProfiloAzienda();
            profiloAzienda.ID = Guid.NewGuid().ToString();
            profiloAzienda.NomeAzienda = "Tempocasa";
            profiloAzienda.PartitaIVa = "30528598402";
            profiloAzienda.PasswordHash = "cicirinella90";
            profiloAzienda.Email = "tempocasa@gmail.com";
            profiloAzienda.Recapiti.Tel1 = "0989879876";


            _context.ProfiliAzienda.Add(profiloAzienda);







            _context.SaveChanges();      

        }
    }
}
