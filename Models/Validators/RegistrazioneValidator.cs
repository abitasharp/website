using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models.Validators
{

    public enum TipoProfilo
    {
        PRIVATO, AZIENDA
    }

    public class RegistrazioneValidator
    {
        public TipoProfilo TipoProfilo { get; set; }

        [Required]
        [StringLength(40)]
        public string Nome { get; set; }

        [Required]
        [StringLength(40)]
        public string Cognome { get; set; }

        [Required]
        [StringLength(254)]
        [EmailAddress]
        public string EmailPrivato { get; set; }

        [Required]
        [StringLength(254)]
        [EmailAddress]
        public string EmailAzienda { get; set; }

        [Required]
        [StringLength(50)]
        [MinLength(8, ErrorMessage = "La password deve contenere almeno 8 caratteri")]
        public string PasswordPrivato { get; set; }

        [Required]
        [StringLength(40)]
        [Compare("PasswordPrivato", ErrorMessage = "Le password non sono uguali")]
        public string ConfermaPasswordPrivato { get; set; }

        [Required]
        [StringLength(50)]
        [MinLength(8, ErrorMessage = "La password deve contenere almeno 8 caratteri")]
        public string PasswordAzienda { get; set; }

        [Required]
        [StringLength(40)]
        [Compare("PasswordAzienda", ErrorMessage = "Le password non sono uguali")]
        public string ConfermaPasswordAzienda { get; set; }

        [Required]
        [StringLength(30)]
        [Phone]
        public string TelefonoPrivato { get; set; }

        [Required]
        [StringLength(30)]
        [Phone]
        public string TelefonoAzienda { get; set; }

        [Required]
        [StringLength(20)]
        [DataType(DataType.Date)]
        public string DataNascita { get; set; }

        [Required]
        [StringLength(40)]
        public string NomeAzienda { get; set; }

        [Required]
        [StringLength(40)]
        public string PartitaIva { get; set; }

        [Range(typeof(bool), "false", "true")]
        public bool Notifiche { get; set; }

       // [Required(ErrorMessage = "Acconsenti alla privacy policy.")]
        public bool PrivacyPrivato { get; set; }

        public bool PrivacyAzienda { get; set; }

    }
}
