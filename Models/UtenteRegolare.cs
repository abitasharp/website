﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models
{
    public class UtenteRegolare : Utente
    {
        public Recapiti Recapiti { get; set; }

        public virtual ICollection<Annuncio> ListaAnnunci { get; set; }

        public virtual ICollection<Preferiti> ListaPreferiti { get; set; }

        public UtenteRegolare()
        {
            Recapiti = new Recapiti();
            ListaAnnunci = new List<Annuncio>();
        }
    }
}
