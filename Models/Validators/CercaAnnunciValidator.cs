using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models.Validators
{
    public class CercaAnnunciValidator
    {
        public TipologiaAnnunci TipologiaAnnuncio { get; set; }
        
        [Range(180,180)]
        public double ZonaX { get; set; }
        
        [Range(180,180)]
        public double ZonaY { get; set; }

        [Range(0, 18)]
        public double ZonaZ { get; set; }

        [DataType(DataType.Currency)]
        public Prezzo PrezzoMassimo { get; set; }

        [DataType(DataType.Date)]
        public Periodo Da { get; set; }
                
        public CaratteristicheUtente CaratteristicheUtente { get; set; }
    }
}
