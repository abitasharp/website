using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models.Validators
{
    public class RegistrazioneValidator
    {
        [Range(typeof(bool), "false", "true")]
        public bool Privato { get; set; }
        [Range(typeof(bool), "false", "true")]
        public bool Azienda { get; set; }

        [Required]
        [StringLength(40)]
        public string Nome { get; set; }

        [Required]
        [StringLength(40)]
        public string Cognome { get; set; }

        [Required]
        [StringLength(254)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        [MinLength(8, ErrorMessage = "La password deve contenere almeno 8 caratteri")]
        public string Password { get; set; }

        [Required]
        [StringLength(40)]
        [Compare("Password", ErrorMessage = "Le password non sono uguali")]
        public string ConfermaPassword { get; set; }

        [Required]
        [StringLength(30)]
        [Phone]
        public string Telefono { get; set; }

        [Required]
        [StringLength(20)]
        [DataType(DataType.Date)]
        public DateTime DataNascita { get; set; }

        [Required]
        [StringLength(40)]
        public string NomeAzienda { get; set; }

        [Required]
        [StringLength(40)]
        public string PartitaIva { get; set; }


    }
}
