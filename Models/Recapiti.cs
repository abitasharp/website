using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models
{
    public class Recapiti
    {
        [ForeignKey("UtenteRegolare")]
        public string RecapitiId { get; set; }

        public string Email1 { get; set; }

        public string Email2 { get; set; }

        public string Email3 { get; set; }

        public string Tel1 { get; set; }

        public string Tel2 { get; set; }

        public string Tel3 { get; set; }

        public virtual UtenteRegolare UtenteRegolare { get; set; }

        public Recapiti()
        {
            UtenteRegolare = new UtenteRegolare();
        }
    }
}
