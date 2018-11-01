﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models
{
    public class Preferiti
    {   

        [ForeignKey("UtenteRegolare")]
        public string UtenteRegolareId { get; set; }

        [ForeignKey("Annuncio")]
        public string AnnuncioId { get; set; }

        public Preferiti()
        {

        }
    }
}
