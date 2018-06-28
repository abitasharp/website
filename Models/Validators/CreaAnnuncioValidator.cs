using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models.Validators
{
    public enum Genere
    {
        NONE, UOMO, DONNA
    }
    public class CreaAnnuncioValidator
    {
        [Required]
        public TipoAnnuncio TipoAnnuncio { get; set; }
        [Required]
        public TipoContratto TipoContratto { get; set; }


        [Required]
        public string Indirizzo { get; set; }

        [Required]
        public float Lat { get; set; }

        [Required]
        public float Lon { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public float Valore { get; set; }
        [Required]
        public TipoPagamento TipoPagamento { get; set; }

                
        [Required]
        [DataType(DataType.Date)]
        public DateTime Da { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime A { get; set; }


        public Genere Genere { get; set; }

        public bool Fumatore { get; set; }
     
        public bool Erasmus { get; set; }
      
        public bool Animali { get; set; }
 
        public bool Studente { get; set; }
    
        public bool Lavoratore { get; set; }
       
        public bool Famiglia { get; set; }


        [StringLength(2000)]
        public string Note { get; set; }


        public List<IFormFile> Foto { get; set; }
    }
}
