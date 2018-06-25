using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models.Validators
{
    public class ModificaAnnuncioValidator
    {
        public TipologiaAnnunci TipologiaAnnunci { get; set; }
 
        public Prezzo Prezzo { get; set; }

        public Periodo Disponibilità { get; set; }

        public CaratteristicheUtente CaratteristicheUtente { get; set; }

        public string Note { get; set; }

        public Foto Foto { get; set; }
    }
}
