using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Abitasharp.Migrations
{
    public partial class test_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                });

            migrationBuilder.CreateTable(
                name: "IdentityUserRole<string>",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserRole<string>", x => new { x.UserId, x.RoleId });
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
                });

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
                });

            migrationBuilder.CreateTable(
                name: "RuoliUtente",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    NormalizedName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RuoliUtente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Segnalazioni",
                columns: table => new
                {
                    UtenteRegolareId = table.Column<string>(type: "text", nullable: false),
                    AnnuncioId = table.Column<string>(type: "text", nullable: false),
                    Messaggio = table.Column<string>(type: "text", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Segnalazioni", x => new { x.UtenteRegolareId, x.AnnuncioId });
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
                });

            migrationBuilder.CreateTable(
                name: "Utenti",
                columns: table => new
                {
                    NomeAzienda = table.Column<string>(type: "text", nullable: true),
                    PartitaIVa = table.Column<string>(type: "text", nullable: true),
                    CaratteristicheUtenteID = table.Column<string>(type: "text", nullable: true),
                    Cognome = table.Column<string>(type: "text", nullable: true),
                    DataNascita = table.Column<DateTime>(type: "timestamp", nullable: true),
                    Nome = table.Column<string>(type: "text", nullable: true),
                    Id = table.Column<string>(type: "text", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int4", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bool", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bool", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "text", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "text", nullable: true),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bool", nullable: false),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bool", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    RecapitiId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utenti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Utenti_CaratteristicheUtente_CaratteristicheUtenteID",
                        column: x => x.CaratteristicheUtenteID,
                        principalTable: "CaratteristicheUtente",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Utenti_Recapiti_RecapitiId",
                        column: x => x.RecapitiId,
                        principalTable: "Recapiti",
                        principalColumn: "RecapitiId",
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
                    PeriodoId = table.Column<string>(type: "text", nullable: true),
                    PrezzoId = table.Column<string>(type: "text", nullable: true),
                    TipologiaAnnunciId = table.Column<string>(type: "text", nullable: true),
                    UtenteRegolareId = table.Column<string>(type: "text", nullable: true)
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
                        name: "FK_Annunci_Periodo_PeriodoId",
                        column: x => x.PeriodoId,
                        principalTable: "Periodo",
                        principalColumn: "PeriodoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Annunci_Prezzo_PrezzoId",
                        column: x => x.PrezzoId,
                        principalTable: "Prezzo",
                        principalColumn: "PrezzoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Annunci_TipologieAnnunci_TipologiaAnnunciId",
                        column: x => x.TipologiaAnnunciId,
                        principalTable: "TipologieAnnunci",
                        principalColumn: "TipologiaAnnunciId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Annunci_Utenti_UtenteRegolareId",
                        column: x => x.UtenteRegolareId,
                        principalTable: "Utenti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Preferiti",
                columns: table => new
                {
                    UtenteRegolareId = table.Column<string>(type: "text", nullable: false),
                    AnnuncioId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preferiti", x => new { x.UtenteRegolareId, x.AnnuncioId });
                    table.ForeignKey(
                        name: "FK_Preferiti_Utenti_UtenteRegolareId",
                        column: x => x.UtenteRegolareId,
                        principalTable: "Utenti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateIndex(
                name: "IX_Annunci_CaratteristicheUtenteID",
                table: "Annunci",
                column: "CaratteristicheUtenteID");

            migrationBuilder.CreateIndex(
                name: "IX_Annunci_IndirizzoPosizioneId",
                table: "Annunci",
                column: "IndirizzoPosizioneId");

            migrationBuilder.CreateIndex(
                name: "IX_Annunci_PeriodoId",
                table: "Annunci",
                column: "PeriodoId");

            migrationBuilder.CreateIndex(
                name: "IX_Annunci_PrezzoId",
                table: "Annunci",
                column: "PrezzoId");

            migrationBuilder.CreateIndex(
                name: "IX_Annunci_TipologiaAnnunciId",
                table: "Annunci",
                column: "TipologiaAnnunciId");

            migrationBuilder.CreateIndex(
                name: "IX_Annunci_UtenteRegolareId",
                table: "Annunci",
                column: "UtenteRegolareId");

            migrationBuilder.CreateIndex(
                name: "IX_Foto_AnnuncioID",
                table: "Foto",
                column: "AnnuncioID");

            migrationBuilder.CreateIndex(
                name: "IX_Utenti_CaratteristicheUtenteID",
                table: "Utenti",
                column: "CaratteristicheUtenteID");

            migrationBuilder.CreateIndex(
                name: "IX_Utenti_RecapitiId",
                table: "Utenti",
                column: "RecapitiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foto");

            migrationBuilder.DropTable(
                name: "IdentityUserRole<string>");

            migrationBuilder.DropTable(
                name: "Preferiti");

            migrationBuilder.DropTable(
                name: "RuoliUtente");

            migrationBuilder.DropTable(
                name: "Segnalazioni");

            migrationBuilder.DropTable(
                name: "Annunci");

            migrationBuilder.DropTable(
                name: "Posizioni");

            migrationBuilder.DropTable(
                name: "Periodo");

            migrationBuilder.DropTable(
                name: "Prezzo");

            migrationBuilder.DropTable(
                name: "TipologieAnnunci");

            migrationBuilder.DropTable(
                name: "Utenti");

            migrationBuilder.DropTable(
                name: "CaratteristicheUtente");

            migrationBuilder.DropTable(
                name: "Recapiti");
        }
    }
}
