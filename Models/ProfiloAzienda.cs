using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models
{
    public class ProfiloAzienda : UtenteRegolare
    {
        public  string NomeAzienda { get; set; }

        public  string PartitaIVa { get; set; }
    }
}
