using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models
{
    public class Periodo
    {
        [ForeignKey("Annuncio")]
        public string PeriodoId { get; set; }

        public DateTime Da { get; set; }

        public DateTime A { get; set; }

        public virtual Annuncio Annuncio { get; set; }

        public Periodo()
        {
            Annuncio = new Annuncio();
        }
    }
}
