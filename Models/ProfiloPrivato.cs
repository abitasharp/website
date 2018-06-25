using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models
{
    public class ProfiloPrivato : UtenteRegolare
    {
        public string Nome { get; set; }

        public string Cognome { get; set; }

        public DateTime DataNascita { get; set; }

        public CaratteristicheUtente CaratteristicheUtente { get; set; }

    }

}
