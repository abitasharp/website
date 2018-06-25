using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models.Validators
{
    public class EliminaAnnuncioValidator
    {
        [Required]
        [StringLength()]
        public string AnnuncioId { get; set; }

        [Required]
        [StringLength(1000)]
        public string Messaggio { get; set; }
    }
}
