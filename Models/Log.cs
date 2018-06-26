using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models
{
    public class Log
    {
        public ICollection<Entry> Entries { get; set; }

        public Log()
        {
            Entries = new List<Entry>();
        }
    }
}
