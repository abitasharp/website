using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models.Validators
{
    public class CercaProfiliValidator
    {
        [StringLength(40)]
        public string Nome { get; set; }

        [StringLength(40)]
        public string Cognome { get; set; }

        [StringLength(254)]
        [EmailAddress]
        public string Email { get; set; }
                
        [StringLength(40)]
        public string NomeAzienda { get; set; }
    }
}
