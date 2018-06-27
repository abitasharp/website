using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models.Validators
{
    public class LoginValidator
    {
        [Required(ErrorMessage = "Inserisci la tua e-mail")]
        [StringLength(254)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Inserisci la password")]
        [StringLength(50)]
        [MinLength(8, ErrorMessage ="La password deve contenere almeno 8 caratteri")]
        public string Password { get; set; }
    }
}
