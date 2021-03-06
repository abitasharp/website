﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Abitasharp.Models;
using Microsoft.AspNetCore.Identity;

namespace Abitasharp.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext (DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Preferiti>().HasKey(p => new { p.UtenteRegolareId, p.AnnuncioId });
            modelBuilder.Entity<Segnalazione>().HasKey(p => new { p.UtenteRegolareId, p.AnnuncioId });
            modelBuilder.Entity<IdentityUserRole<string>>().HasKey(p => new { p.UserId, p.RoleId });
        }

        /* Annunci */

        public DbSet<Annuncio> Annunci{ get; set; }

        public DbSet<CaratteristicheUtente> CaratteristicheUtente{ get; set; }

        public DbSet<Foto> Foto { get; set; }

        public DbSet<Posizione> Posizioni { get; set; }

        public DbSet<Periodo> Periodo{ get; set; }

        public DbSet<Prezzo> Prezzo{ get; set; }

        public DbSet<TipologiaAnnunci> TipologieAnnunci { get; set; }

        public DbSet<Recapiti> Recapiti{ get; set; }

        public DbSet<Segnalazione> Segnalazioni { get; set; }

        public DbSet<Preferiti> Preferiti { get; set; }

        /* Account */

        public DbSet<Utente> Utenti{ get; set; }

        public DbSet<UtenteRegolare> UtentiRegolari{ get; set; }

        public DbSet<ProfiloAzienda> ProfiliAzienda { get; set; }

        public DbSet<ProfiloPrivato> ProfiliPrivati { get; set; }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<IdentityRole> RuoliUtente { get; set; }

        public DbSet<IdentityUserClaim<string>> ClaimUtenti { get; set; }

        public DbSet<IdentityRoleClaim<string>> ClaimRuoli { get; set; }

    }
}