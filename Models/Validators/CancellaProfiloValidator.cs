using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models.Validators
{
    public class CancellaProfiloValidator
    {
            [Required]
            [StringLength(50)]
            [MinLength(8, ErrorMessage = "La password deve essere almeno di 8 caratteri")]
            public string Password { get; set; }
    }
}

