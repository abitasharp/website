using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models
{
    public class Segnalazione
    {
        [ForeignKey("Annuncio")]
        public string AnnuncioId { get; set; }

        [ForeignKey("UtenteRegolare")]
        public string UtenteRegolareId { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; } 

        public string Messaggio { get; set; }

        public Segnalazione()
        {
        }
    }
}
