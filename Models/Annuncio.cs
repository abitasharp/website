using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models
{
    public class Annuncio
    {
        public string ID { get; set; }

        public virtual TipologiaAnnunci Tipologia { get; set; }

        public virtual Posizione Indirizzo { get; set; }

        public virtual Prezzo Prezzo { get; set; }

        public virtual Periodo Periodo { get; set; }

        public string Note { get; set; }

        public ICollection<Foto> Foto { get; set; }

        public virtual CaratteristicheUtente CaratteristicheUtente { get; set; }

        public Annuncio()
        {
            Tipologia = new TipologiaAnnunci();
            Indirizzo = new Posizione();
            Prezzo = new Prezzo();
            Periodo = new Periodo();
            Foto = new List<Foto>();
            CaratteristicheUtente = new CaratteristicheUtente();            
        }
    }
}
