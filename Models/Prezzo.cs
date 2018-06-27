using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models
{
    public enum TipoPagamento { Giornaliero, Settimanale, Mensile, Totale}
    public class Prezzo
    {
        [ForeignKey("Annuncio")]
        public string PrezzoId { get; set; }

        public TipoPagamento TipoPagamento { get; set; }

        public double Valore { get; set; }

        public virtual Annuncio Annuncio { get; set; }

        public Prezzo()
        {
            Annuncio = new Annuncio();
        }
    }
}
