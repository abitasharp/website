using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models
{
    public enum TipoAnnuncio { Casa, PostoLetto, Stanza}
    public enum TipoContratto { Affitto, Vendita}

    public class TipologiaAnnunci
    {
        [ForeignKey("Annuncio")]
        public string TipologiaAnnunciId { get; set; }

        public TipoAnnuncio TipoAnnuncio { get; set; }

        public TipoContratto TipoContratto { get; set; }

        public virtual Annuncio Annuncio { get; set; }

        public TipologiaAnnunci()
        {
            Annuncio = new Annuncio();
        }
    }
}
