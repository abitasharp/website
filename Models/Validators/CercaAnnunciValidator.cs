using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models.Validators
{
    public class CercaAnnunciValidator
    {
        public TipoAnnuncio TipoAnnuncio { get; set; }
        public TipoContratto TipoContratto { get; set; }


        [Range(180,180)]
        public double ZonaX { get; set; }        
        [Range(180,180)]
        public double ZonaY { get; set; }
        [Range(0, 18)]
        public double ZonaZ { get; set; }



        [DataType(DataType.Currency)]
        public float Valore { get; set; }
        public TipoPagamento TipoPagamento { get; set; }

        [DataType(DataType.Date)]
        public DateTime Da { get; set; }


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
    }
}
