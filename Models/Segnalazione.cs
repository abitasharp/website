using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models
{
    public class Segnalazione
    {
        public string ID { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; } 

        public string Messaggio { get; set; }

        public Annuncio Annuncio { get; set; }
    }
}
