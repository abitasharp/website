using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models
{
    public class CaratteristicheUtente
    {
        public string ID { get; set; }

        public bool? Genere { get; set; }

        public bool? Fumatore { get; set; }

        public bool? Erasmus { get; set; }

        public bool? Animali { get; set; }

        public bool? Studente { get; set; }

        public bool? Lavoratore { get; set; }

        public bool? Famiglia { get; set; }

        public virtual ProfiloPrivato ProfiloPrivato { get; set; }

    }
}
