using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models.Validators
{
    public class ModificaAnnuncioValidator
    {        

        public TipoAnnuncio TipoAnnuncio { get; set; }      
        public TipoContratto TipoContratto { get; set; }
 
        [DataType(DataType.Currency)]
        public float Valore { get; set; }
        public TipoPagamento TipoPagamento { get; set; }

        [DataType(DataType.Date)]
        public DateTime Da { get; set; }
        [DataType(DataType.Date)]
        public DateTime A { get; set; }

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

        [StringLength(2000)]
        public string Note { get; set; }

        public List<IFormFile> Foto { get; set; }
    }
}
