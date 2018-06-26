using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models.Validators
{
    public class ModificaInfoProfiloValidator
    {
        [StringLength(40)]
        public string Nome { get; set; }


        [StringLength(40)]
        public string Cognome { get; set; }


        [StringLength(50)]
        public string Password { get; set; }
        [Required]
        [StringLength(40)]
        [Compare("Password", ErrorMessage = "Le password non sono uguali")]
        public string ConfermaPassword { get; set; }


        [StringLength(254)]
        [EmailAddress]
        public string Email1 { get; set; }
        [StringLength(254)]
        [EmailAddress]
        public string Email2 { get; set; }
        [StringLength(254)]
        [EmailAddress]
        public string Email3 { get; set; }


        [StringLength(30)]
        [Phone]
        public string Tel1 { get; set; }
        [StringLength(30)]
        [Phone]
        public string Tel2 { get; set; }
        [StringLength(30)]
        [Phone]
        public string Tel3 { get; set; }


        [StringLength(20)]
        [DataType(DataType.Date)]
        public DateTime DataNascita { get; set; }


        [StringLength(40)]
        public string NomeAzienda { get; set; }


        [StringLength(40)]
        public string PartitaIva { get; set; }


        [Range(typeof(bool), "false", "true")]
        public bool Uomo { get; set; }
        [Range(typeof(bool), "false", "true")]
        public bool Donna { get; set; }
        [Range(typeof(bool), "false", "true")]
        public bool? Fumatore { get; set; }
        [Range(typeof(bool), "false", "true")]
        public bool? Erasmus { get; set; }
        [Range(typeof(bool), "false", "true")]
        public bool? Animali { get; set; }
        [Range(typeof(bool), "false", "true")]
        public bool? Studente { get; set; }
        [Range(typeof(bool), "false", "true")]
        public bool? Lavoratore { get; set; }
        [Range(typeof(bool), "false", "true")]
        public bool? Famiglia { get; set; }


    }
}
