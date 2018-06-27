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
        
        public void Empty()
        {
            _context.ProfiliAzienda.RemoveRange(_context.ProfiliAzienda);
            _context.ProfiliPrivati.RemoveRange(_context.ProfiliPrivati);

        }
        public void Seed()
        {
           
            //Profilo azienda 
            ProfiloAzienda profiloAzienda = new ProfiloAzienda();
            profiloAzienda.Id = Guid.NewGuid().ToString();
            profiloAzienda.NomeAzienda = "Tempocasa";
            profiloAzienda.PartitaIVa = "30528598402";
            profiloAzienda.PasswordHash = "cicirinella90";
            profiloAzienda.Email = "tempocasa@gmail.com";
            profiloAzienda.Recapiti.Tel1 = "0989879876";


            _context.ProfiliAzienda.Add(profiloAzienda);


            //Profilo privato
            ProfiloPrivato profiloPrivato = new ProfiloPrivato();
            profiloPrivato.Id = Guid.NewGuid().ToString();
            profiloPrivato.Nome = "Bibbo";
            profiloPrivato.Cognome = "Babbo";
            profiloPrivato.DataNascita = new DateTime(1990, 05, 30);
            profiloPrivato.PasswordHash = "BibboBabbo1990";
            profiloPrivato.Email = "bibbobabbo@gmail.com";
            profiloPrivato.Recapiti.Tel1 = "0569978265";
            profiloPrivato.CaratteristicheUtente.Fumatore = true;
            profiloPrivato.CaratteristicheUtente.Animali = false;
            profiloPrivato.CaratteristicheUtente.Erasmus = true;
            profiloPrivato.CaratteristicheUtente.Famiglia = false;
            profiloPrivato.CaratteristicheUtente.Genere = true;
            profiloPrivato.CaratteristicheUtente.Lavoratore = null;
            profiloPrivato.CaratteristicheUtente.Studente = true;


            _context.ProfiliPrivati.Add(profiloPrivato);

            //



            _context.SaveChanges();      

        }
    }
}
