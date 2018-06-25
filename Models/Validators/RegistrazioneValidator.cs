using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models.Validators
{
    public class RegistrazioneValidator
    {
        /*  public HtmlInputRadioButton   */

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
        public DateTime DataNascita { get; set; }

        [Required]
        [StringLength(40)]
        public string NomeAzienda { get; set; }

        [Required]
        [StringLength(40)]
        public string PartitaIva { get; set; }


    }
}
