using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models
{
    public class Annuncio
    {
        public string ID { get; set; }

        public TipologiaAnnunci Tipologia { get; set; }

        public Posizione Indirizzo { get; set; }

        public Prezzo Prezzo { get; set; }

        public Periodo Periodo { get; set; }

        public string Note { get; set; }

        public ICollection<Foto> Foto { get; set; }

        public virtual ICollection<Preferiti> Preferiti { get; set; }

        public virtual ICollection<Segnalazione> Segnalazioni { get; set; }

        public CaratteristicheUtente CaratteristicheUtente { get; set; }

        public Annuncio()
        {
            Tipologia = new TipologiaAnnunci();
            Indirizzo = new Posizione();
            Prezzo = new Prezzo();
            Periodo = new Periodo();
            Foto = new List<Foto>();
            Preferiti = new List<Preferiti>();
            CaratteristicheUtente = new CaratteristicheUtente();            
        }
    }
}
