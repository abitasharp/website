using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models
{
    public class Posizione
    {
        [ForeignKey("Annuncio")]
        public string IndirizzoId { get; set; }

        public string Indirizzo { get; set; }

        public float Lat { get; set; }

        public float Long { get; set; }
    }
}
