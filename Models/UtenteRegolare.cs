using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models
{
    public class UtenteRegolare : Utente
    {
        public ICollection<Annuncio> ListaAnnunci { get; set; }

        public ICollection<Recapiti> ListaRecapiti { get; set; }

        public ICollection<Annuncio> ListaPreferiti { get; set; }

        public ICollection<Segnalazione> ListaSegnalazioni { get; set; }
    }
}
