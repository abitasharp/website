using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models
{
    public class UtenteRegolare : Utente
    {
        public Recapiti Recapiti { get; set; }

        public ICollection<Annuncio> ListaAnnunci { get; set; }

        public ICollection<Annuncio> ListaPreferiti { get; set; }

        public ICollection<Segnalazione> ListaSegnalazioni { get; set; }

        public UtenteRegolare()
        {
            Recapiti = new Recapiti();
            ListaAnnunci = new List<Annuncio>();
            ListaPreferiti = new List<Annuncio>();
            ListaSegnalazioni = new List<Segnalazione>();
        }
    }
}
