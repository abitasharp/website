using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models
{
    public class CaratteristicheUtente
    {
        public string ID { get; set; }

        public Boolean? Genere { get; set; }

        public Boolean? Fumatore { get; set; }

        public Boolean? Erasmus { get; set; }

        public Boolean? Animali { get; set; }

        public Boolean? Studente { get; set; }

        public Boolean? Lavoratore { get; set; }

        public Boolean? Famiglia { get; set; }

        public virtual ProfiloPrivato ProfiloPrivato { get; set; }

    }
}
