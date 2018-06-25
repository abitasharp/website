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

        public virtual Indirizzo Indirizzo { get; set; }

        public virtual Prezzo Prezzo { get; set; }

        public virtual Periodo Periodo { get; set; }

        public string Note { get; set; }

        public ICollection<Foto> Foto { get; set; }

        public virtual CaratteristicheUtente CaratteristicheUtente { get; set; }
    }
}
