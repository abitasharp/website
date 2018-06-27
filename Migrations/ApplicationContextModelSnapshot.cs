﻿// <auto-generated />
using Abitasharp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace Abitasharp.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("Abitasharp.Models.Annuncio", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CaratteristicheUtenteID");

                    b.Property<string>("IndirizzoPosizioneId");

                    b.Property<string>("Note");

                    b.Property<string>("PeriodoId");

                    b.Property<string>("PrezzoId");

                    b.Property<string>("UtenteRegolareId");

                    b.Property<string>("UtenteRegolareId1");

                    b.HasKey("ID");

                    b.HasIndex("CaratteristicheUtenteID");

                    b.HasIndex("IndirizzoPosizioneId");

                    b.HasIndex("PeriodoId");

                    b.HasIndex("PrezzoId");

                    b.HasIndex("UtenteRegolareId");

                    b.HasIndex("UtenteRegolareId1");

                    b.ToTable("Annunci");
                });

            modelBuilder.Entity("Abitasharp.Models.CaratteristicheUtente", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("Animali");

                    b.Property<bool?>("Erasmus");

                    b.Property<bool?>("Famiglia");

                    b.Property<bool?>("Fumatore");

                    b.Property<bool?>("Genere");

                    b.Property<bool?>("Lavoratore");

                    b.Property<bool?>("Studente");

                    b.HasKey("ID");

                    b.ToTable("CaratteristicheUtente");
                });

            modelBuilder.Entity("Abitasharp.Models.Foto", b =>
                {
                    b.Property<string>("Path")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AnnuncioID");

                    b.HasKey("Path");

                    b.HasIndex("AnnuncioID");

                    b.ToTable("Foto");
                });

            modelBuilder.Entity("Abitasharp.Models.Periodo", b =>
                {
                    b.Property<string>("PeriodoId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("A");

                    b.Property<DateTime>("Da");

                    b.HasKey("PeriodoId");

                    b.ToTable("Periodo");
                });

            modelBuilder.Entity("Abitasharp.Models.Posizione", b =>
                {
                    b.Property<string>("PosizioneId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Indirizzo");

                    b.Property<float>("Lat");

                    b.Property<float>("Long");

                    b.HasKey("PosizioneId");

                    b.ToTable("Posizioni");
                });

            modelBuilder.Entity("Abitasharp.Models.Prezzo", b =>
                {
                    b.Property<string>("PrezzoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("TipoPagamento");

                    b.Property<double>("Valore");

                    b.HasKey("PrezzoId");

                    b.ToTable("Prezzo");
                });

            modelBuilder.Entity("Abitasharp.Models.Recapiti", b =>
                {
                    b.Property<string>("RecapitiId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email1");

                    b.Property<string>("Email2");

                    b.Property<string>("Email3");

                    b.Property<string>("Tel1");

                    b.Property<string>("Tel2");

                    b.Property<string>("Tel3");

                    b.HasKey("RecapitiId");

                    b.ToTable("Recapiti");
                });

            modelBuilder.Entity("Abitasharp.Models.RuoloUtente", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedName");

                    b.HasKey("Id");

                    b.ToTable("RuoliUtente");
                });

            modelBuilder.Entity("Abitasharp.Models.Segnalazione", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AnnuncioID");

                    b.Property<string>("Messaggio");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("UtenteRegolareId");

                    b.HasKey("ID");

                    b.HasIndex("AnnuncioID");

                    b.HasIndex("UtenteRegolareId");

                    b.ToTable("Segnalazioni");
                });

            modelBuilder.Entity("Abitasharp.Models.TipologiaAnnunci", b =>
                {
                    b.Property<string>("TipologiaAnnunciId");

                    b.Property<int>("TipoAnnuncio");

                    b.Property<int>("TipoContratto");

                    b.HasKey("TipologiaAnnunciId");

                    b.ToTable("TipologieAnnunci");
                });

            modelBuilder.Entity("Abitasharp.Models.Utente", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Utenti");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Utente");
                });

            modelBuilder.Entity("Abitasharp.Models.Admin", b =>
                {
                    b.HasBaseType("Abitasharp.Models.Utente");


                    b.ToTable("Admin");

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("Abitasharp.Models.UtenteRegolare", b =>
                {
                    b.HasBaseType("Abitasharp.Models.Utente");

                    b.Property<string>("RecapitiId");

                    b.HasIndex("RecapitiId");

                    b.ToTable("UtenteRegolare");

                    b.HasDiscriminator().HasValue("UtenteRegolare");
                });

            modelBuilder.Entity("Abitasharp.Models.ProfiloAzienda", b =>
                {
                    b.HasBaseType("Abitasharp.Models.UtenteRegolare");

                    b.Property<string>("NomeAzienda");

                    b.Property<string>("PartitaIVa");

                    b.ToTable("ProfiloAzienda");

                    b.HasDiscriminator().HasValue("ProfiloAzienda");
                });

            modelBuilder.Entity("Abitasharp.Models.ProfiloPrivato", b =>
                {
                    b.HasBaseType("Abitasharp.Models.UtenteRegolare");

                    b.Property<string>("CaratteristicheUtenteID");

                    b.Property<string>("Cognome");

                    b.Property<DateTime>("DataNascita");

                    b.Property<string>("Nome");

                    b.HasIndex("CaratteristicheUtenteID");

                    b.ToTable("ProfiloPrivato");

                    b.HasDiscriminator().HasValue("ProfiloPrivato");
                });

            modelBuilder.Entity("Abitasharp.Models.Annuncio", b =>
                {
                    b.HasOne("Abitasharp.Models.CaratteristicheUtente", "CaratteristicheUtente")
                        .WithMany()
                        .HasForeignKey("CaratteristicheUtenteID");

                    b.HasOne("Abitasharp.Models.Posizione", "Indirizzo")
                        .WithMany()
                        .HasForeignKey("IndirizzoPosizioneId");

                    b.HasOne("Abitasharp.Models.Periodo", "Periodo")
                        .WithMany()
                        .HasForeignKey("PeriodoId");

                    b.HasOne("Abitasharp.Models.Prezzo", "Prezzo")
                        .WithMany()
                        .HasForeignKey("PrezzoId");

                    b.HasOne("Abitasharp.Models.UtenteRegolare")
                        .WithMany("ListaAnnunci")
                        .HasForeignKey("UtenteRegolareId");

                    b.HasOne("Abitasharp.Models.UtenteRegolare")
                        .WithMany("ListaPreferiti")
                        .HasForeignKey("UtenteRegolareId1");
                });

            modelBuilder.Entity("Abitasharp.Models.Foto", b =>
                {
                    b.HasOne("Abitasharp.Models.Annuncio")
                        .WithMany("Foto")
                        .HasForeignKey("AnnuncioID");
                });

            modelBuilder.Entity("Abitasharp.Models.Segnalazione", b =>
                {
                    b.HasOne("Abitasharp.Models.Annuncio", "Annuncio")
                        .WithMany()
                        .HasForeignKey("AnnuncioID");

                    b.HasOne("Abitasharp.Models.UtenteRegolare", "UtenteRegolare")
                        .WithMany()
                        .HasForeignKey("UtenteRegolareId");
                });

            modelBuilder.Entity("Abitasharp.Models.TipologiaAnnunci", b =>
                {
                    b.HasOne("Abitasharp.Models.Annuncio", "Annuncio")
                        .WithOne("Tipologia")
                        .HasForeignKey("Abitasharp.Models.TipologiaAnnunci", "TipologiaAnnunciId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Abitasharp.Models.UtenteRegolare", b =>
                {
                    b.HasOne("Abitasharp.Models.Recapiti", "Recapiti")
                        .WithMany()
                        .HasForeignKey("RecapitiId");
                });

            modelBuilder.Entity("Abitasharp.Models.ProfiloPrivato", b =>
                {
                    b.HasOne("Abitasharp.Models.CaratteristicheUtente", "CaratteristicheUtente")
                        .WithMany()
                        .HasForeignKey("CaratteristicheUtenteID");
                });
#pragma warning restore 612, 618
        }
    }
}
