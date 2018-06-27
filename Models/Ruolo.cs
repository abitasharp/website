using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models
{
    public class Ruolo : IdentityRole<string>
    {
        public ICollection<RuoloUtente> RuoloUtente { get; set; }

        public Ruolo()
        {
            RuoloUtente = new List<RuoloUtente>();
        }
    }

 }
