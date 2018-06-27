using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models
{
    public class Foto
    {
        [Key]
        public string Path { get; set; }
    }
}
