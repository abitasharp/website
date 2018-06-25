using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models
{
    public class Indirizzo
    {
        [ForeignKey("Annuncio")]
        public string IndirizzoId { get; set; }

        public double[] Coordinate { get; set; }

        public string Via { get; set; }

        public string Civico { get; set; }

        public string Interno { get; set; }

        public virtual Annuncio Annuncio { get; set; }
    }
}
