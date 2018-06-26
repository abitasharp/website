using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Abitasharp.Migrations
{
    public partial class testSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posizioni",
                columns: table => new
                {
                    PosizioneId = table.Column<string>(type: "text", nullable: false),
                    Indirizzo = table.Column<string>(type: "text", nullable: true),
                    Lat = table.Column<float>(type: "float4", nullable: false),
                    Long = table.Column<float>(type: "float4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posizioni", x => x.PosizioneId);
                });

            migrationBuilder.CreateTable(
                name: "Ruoli",
                columns: table => new
                {
                    ID = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ruoli", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Utenti",
                columns: table => new
                {
                    NomeAzienda = table.Column<string>(type: "text", nullable: true),
                    PartitaIVa = table.Column<string>(type: "text", nullable: true),
                    Cognome = table.Column<string>(type: "text", nullable: true),
                    DataNascita = table.Column<DateTime>(type: "timestamp", nullable: true),
                    Nome = table.Column<string>(type: "text", nullable: true),
                    ID = table.Column<string>(type: "text", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    PasswordHash = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utenti", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CaratteristicheUtente",
                columns: table => new
                {
                    ID = table.Column<string>(type: "text", nullable: false),
                    Animali = table.Column<bool>(type: "bool", nullable: true),
                    Erasmus = table.Column<bool>(type: "bool", nullable: true),
                    Famiglia = table.Column<bool>(type: "bool", nullable: true),
                    Fumatore = table.Column<bool>(type: "bool", nullable: true),
                    Genere = table.Column<bool>(type: "bool", nullable: true),
                    Lavoratore = table.Column<bool>(type: "bool", nullable: true),
                    Studente = table.Column<bool>(type: "bool", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaratteristicheUtente", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CaratteristicheUtente_Utenti_ID",
                        column: x => x.ID,
                        principalTable: "Utenti",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recapiti",
                columns: table => new
                {
                    RecapitiId = table.Column<string>(type: "text", nullable: false),
                    Email1 = table.Column<string>(type: "text", nullable: true),
                    Email2 = table.Column<string>(type: "text", nullable: true),
                    Email3 = table.Column<string>(type: "text", nullable: true),
                    Tel1 = table.Column<string>(type: "text", nullable: true),
                    Tel2 = table.Column<string>(type: "text", nullable: true),
                    Tel3 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recapiti", x => x.RecapitiId);
                    table.ForeignKey(
                        name: "FK_Recapiti_Utenti_RecapitiId",
                        column: x => x.RecapitiId,
                        principalTable: "Utenti",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RuoliUtente",
                columns: table => new
                {
                    ID = table.Column<string>(type: "text", nullable: false),
                    RuoloID = table.Column<string>(type: "text", nullable: true),
                    UtenteID = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RuoliUtente", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RuoliUtente_Ruoli_RuoloID",
                        column: x => x.RuoloID,
                        principalTable: "Ruoli",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RuoliUtente_Utenti_UtenteID",
                        column: x => x.UtenteID,
                        principalTable: "Utenti",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Annunci",
                columns: table => new
                {
                    ID = table.Column<string>(type: "text", nullable: false),
                    CaratteristicheUtenteID = table.Column<string>(type: "text", nullable: true),
                    IndirizzoPosizioneId = table.Column<string>(type: "text", nullable: true),
                    Note = table.Column<string>(type: "text", nullable: true),
                    UtenteRegolareID = table.Column<string>(type: "text", nullable: true),
                    UtenteRegolareID1 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Annunci", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Annunci_CaratteristicheUtente_CaratteristicheUtenteID",
                        column: x => x.CaratteristicheUtenteID,
                        principalTable: "CaratteristicheUtente",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Annunci_Posizioni_IndirizzoPosizioneId",
                        column: x => x.IndirizzoPosizioneId,
                        principalTable: "Posizioni",
                        principalColumn: "PosizioneId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Annunci_Utenti_UtenteRegolareID",
                        column: x => x.UtenteRegolareID,
                        principalTable: "Utenti",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Annunci_Utenti_UtenteRegolareID1",
                        column: x => x.UtenteRegolareID1,
                        principalTable: "Utenti",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Foto",
                columns: table => new
                {
                    Path = table.Column<string>(type: "text", nullable: false),
                    AnnuncioID = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foto", x => x.Path);
                    table.ForeignKey(
                        name: "FK_Foto_Annunci_AnnuncioID",
                        column: x => x.AnnuncioID,
                        principalTable: "Annunci",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Periodo",
                columns: table => new
                {
                    PeriodoId = table.Column<string>(type: "text", nullable: false),
                    A = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Da = table.Column<DateTime>(type: "timestamp", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periodo", x => x.PeriodoId);
                    table.ForeignKey(
                        name: "FK_Periodo_Annunci_PeriodoId",
                        column: x => x.PeriodoId,
                        principalTable: "Annunci",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prezzo",
                columns: table => new
                {
                    PrezzoId = table.Column<string>(type: "text", nullable: false),
                    TipoPagamento = table.Column<int>(type: "int4", nullable: false),
                    Valore = table.Column<double>(type: "float8", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prezzo", x => x.PrezzoId);
                    table.ForeignKey(
                        name: "FK_Prezzo_Annunci_PrezzoId",
                        column: x => x.PrezzoId,
                        principalTable: "Annunci",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Segnalazioni",
                columns: table => new
                {
                    ID = table.Column<string>(type: "text", nullable: false),
                    AnnuncioID = table.Column<string>(type: "text", nullable: true),
                    Messaggio = table.Column<string>(type: "text", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: true),
                    UtenteRegolareID = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Segnalazioni", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Segnalazioni_Annunci_AnnuncioID",
                        column: x => x.AnnuncioID,
                        principalTable: "Annunci",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Segnalazioni_Utenti_UtenteRegolareID",
                        column: x => x.UtenteRegolareID,
                        principalTable: "Utenti",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TipologieAnnunci",
                columns: table => new
                {
                    TipologiaAnnunciId = table.Column<string>(type: "text", nullable: false),
                    TipoAnnuncio = table.Column<int>(type: "int4", nullable: false),
                    TipoContratto = table.Column<int>(type: "int4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipologieAnnunci", x => x.TipologiaAnnunciId);
                    table.ForeignKey(
                        name: "FK_TipologieAnnunci_Annunci_TipologiaAnnunciId",
                        column: x => x.TipologiaAnnunciId,
                        principalTable: "Annunci",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Annunci_CaratteristicheUtenteID",
                table: "Annunci",
                column: "CaratteristicheUtenteID");

            migrationBuilder.CreateIndex(
                name: "IX_Annunci_IndirizzoPosizioneId",
                table: "Annunci",
                column: "IndirizzoPosizioneId");

            migrationBuilder.CreateIndex(
                name: "IX_Annunci_UtenteRegolareID",
                table: "Annunci",
                column: "UtenteRegolareID");

            migrationBuilder.CreateIndex(
                name: "IX_Annunci_UtenteRegolareID1",
                table: "Annunci",
                column: "UtenteRegolareID1");

            migrationBuilder.CreateIndex(
                name: "IX_Foto_AnnuncioID",
                table: "Foto",
                column: "AnnuncioID");

            migrationBuilder.CreateIndex(
                name: "IX_RuoliUtente_RuoloID",
                table: "RuoliUtente",
                column: "RuoloID");

            migrationBuilder.CreateIndex(
                name: "IX_RuoliUtente_UtenteID",
                table: "RuoliUtente",
                column: "UtenteID");

            migrationBuilder.CreateIndex(
                name: "IX_Segnalazioni_AnnuncioID",
                table: "Segnalazioni",
                column: "AnnuncioID");

            migrationBuilder.CreateIndex(
                name: "IX_Segnalazioni_UtenteRegolareID",
                table: "Segnalazioni",
                column: "UtenteRegolareID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foto");

            migrationBuilder.DropTable(
                name: "Periodo");

            migrationBuilder.DropTable(
                name: "Prezzo");

            migrationBuilder.DropTable(
                name: "Recapiti");

            migrationBuilder.DropTable(
                name: "RuoliUtente");

            migrationBuilder.DropTable(
                name: "Segnalazioni");

            migrationBuilder.DropTable(
                name: "TipologieAnnunci");

            migrationBuilder.DropTable(
                name: "Ruoli");

            migrationBuilder.DropTable(
                name: "Annunci");

            migrationBuilder.DropTable(
                name: "CaratteristicheUtente");

            migrationBuilder.DropTable(
                name: "Posizioni");

            migrationBuilder.DropTable(
                name: "Utenti");
        }
    }
}
