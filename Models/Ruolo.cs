using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models
{
    public class Ruolo
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public ICollection<RuoloUtente> RuoloUtente { get; set; }
    }
}
