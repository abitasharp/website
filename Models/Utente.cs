using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models
{
    public class Utente
    {
        public string ID { get; set; }
       
        public string Email { get; set; }

        public string PasswordHash { get; set; }
    }
}
