using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models
{
    public class RuoloUtente
    {
        public string ID { get; set; }

        public string UtenteID { get; set; }

        public string RuoloID { get; set; }

        public Ruolo Ruolo { get; set; }

        public Utente Utente { get; set; }

        public RuoloUtente()
        {
            Ruolo = new Ruolo();
            Utente = new Utente();
        }
    }
}
