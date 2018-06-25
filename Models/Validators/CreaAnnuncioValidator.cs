using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models.Validators
{
    public class CreaAnnuncioValidator
    {
        [Required]
        public TipologiaAnnunci TipologiaAnnunci { get; set; }

        [Required]
        public Indirizzo Indirizzo { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public Prezzo Prezzo { get; set; }

        [Required]
        public Periodo Disponibilità { get; set; }

        [Required]
        public CaratteristicheUtente CaratteristicheUtente { get; set; }

        [Required]
        [StringLength(254)]
        public string Note { get; set; }

        [Required]
        public Foto Foto { get; set; }
    }
}
