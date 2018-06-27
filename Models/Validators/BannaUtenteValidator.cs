using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models.Validators
{
    public class BannaUtenteValidator
    {
        [Required]
        [StringLength(40)]
        public string UtenteId { get; set; }

        [StringLength(1000)]
        public string Messaggio { get; set; }
    }
}
