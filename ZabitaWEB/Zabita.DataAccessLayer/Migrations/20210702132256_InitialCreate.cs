using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Zabita.DataAccessLayer.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IsTipleris",
                columns: table => new
                {
                    IstipiID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsTipi = table.Column<string>(type: "text", nullable: true),
                    AmirlikId = table.Column<string>(type: "text", nullable: true),
                    AmirlikIsim = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsTipleris", x => x.IstipiID);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    LogID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LogTarih = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LogPersonel = table.Column<string>(type: "text", nullable: true),
                    LogYapilanIs = table.Column<string>(type: "text", nullable: true),
                    LogYapilanTur = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.LogID);
                });

            migrationBuilder.CreateTable(
                name: "Moduls",
                columns: table => new
                {
                    ModulId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ModulIsim = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moduls", x => x.ModulId);
                });

            migrationBuilder.CreateTable(
                name: "Mudurluks",
                columns: table => new
                {
                    MudurlukId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MudurlukIsim = table.Column<string>(type: "text", nullable: true),
                    MudurlukSeriNo = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mudurluks", x => x.MudurlukId);
                });

            migrationBuilder.CreateTable(
                name: "SeriNo",
                columns: table => new
                {
                    SeriNoId = table.Column<int>(type: "integer", nullable: false),
                    SeriNoAdresleme = table.Column<string>(type: "text", nullable: true),
                    SeriNoYerleskeIsim = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriNo", x => x.SeriNoId);
                });

            migrationBuilder.CreateTable(
                name: "Takvims",
                columns: table => new
                {
                    TakvimId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TakvimIsım = table.Column<string>(type: "text", nullable: true),
                    TakvimTip = table.Column<int>(type: "integer", nullable: false),
                    TakvimSahibi = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Takvims", x => x.TakvimId);
                });

            migrationBuilder.CreateTable(
                name: "TalepAltSonucus",
                columns: table => new
                {
                    TalepAltSonucuId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TalepAltSonucuTipi = table.Column<int>(type: "integer", nullable: false),
                    TalepAltSonucuIlgiliTalepTipi = table.Column<int>(type: "integer", nullable: false),
                    TalepAltSonucuAciklama = table.Column<string>(type: "text", nullable: true),
                    TalepAltSonucuKapanisBilgisi = table.Column<string>(type: "text", nullable: true),
                    TalepId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TalepAltSonucus", x => x.TalepAltSonucuId);
                });

            migrationBuilder.CreateTable(
                name: "TalepSonucus",
                columns: table => new
                {
                    TalepSonucuId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TalepSonucuTipi = table.Column<int>(type: "integer", nullable: false),
                    TalepSonucuAciklama = table.Column<string>(type: "text", nullable: true),
                    TalepSonucuKapanisBilgisi = table.Column<string>(type: "text", nullable: true),
                    TalepId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TalepSonucus", x => x.TalepSonucuId);
                });

            migrationBuilder.CreateTable(
                name: "Tanimlamalars",
                columns: table => new
                {
                    TanimlamalarId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Insaattipi = table.Column<string>(type: "text", nullable: true),
                    Aydinlatma = table.Column<string>(type: "text", nullable: true),
                    Catitipi = table.Column<string>(type: "text", nullable: true),
                    Zeminbilgisi = table.Column<string>(type: "text", nullable: true),
                    Isitmatipi = table.Column<string>(type: "text", nullable: true),
                    Sogutmatipi = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tanimlamalars", x => x.TanimlamalarId);
                });

            migrationBuilder.CreateTable(
                name: "UygulamaAyarlaris",
                columns: table => new
                {
                    UygulamaAyarId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UygulamaYetkiTipleri = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UygulamaAyarlaris", x => x.UygulamaAyarId);
                });

            migrationBuilder.CreateTable(
                name: "Yerleskes",
                columns: table => new
                {
                    YerleskeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    YerleskeIsim = table.Column<string>(type: "text", nullable: true),
                    YerleskeSeriNo = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yerleskes", x => x.YerleskeId);
                });

            migrationBuilder.CreateTable(
                name: "Amirliks",
                columns: table => new
                {
                    AmirlikID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AmirlikIsım = table.Column<string>(type: "text", nullable: true),
                    AmirlikSeriNo = table.Column<string>(type: "text", nullable: true),
                    AmirlikMudurlukMudurlukId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amirliks", x => x.AmirlikID);
                    table.ForeignKey(
                        name: "FK_Amirliks_Mudurluks_AmirlikMudurlukMudurlukId",
                        column: x => x.AmirlikMudurlukMudurlukId,
                        principalTable: "Mudurluks",
                        principalColumn: "MudurlukId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TakvimDetaylari",
                columns: table => new
                {
                    TakvimDetaylariId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TakvimDetayBilgisi = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TakvimTakvimDetaylariTakvimId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TakvimDetaylari", x => x.TakvimDetaylariId);
                    table.ForeignKey(
                        name: "FK_TakvimDetaylari_Takvims_TakvimTakvimDetaylariTakvimId",
                        column: x => x.TakvimTakvimDetaylariTakvimId,
                        principalTable: "Takvims",
                        principalColumn: "TakvimId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MudurlukYerleskecs",
                columns: table => new
                {
                    MudurlukId = table.Column<int>(type: "integer", nullable: false),
                    YerleskeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MudurlukYerleskecs", x => new { x.YerleskeId, x.MudurlukId });
                    table.ForeignKey(
                        name: "FK_MudurlukYerleskecs_Mudurluks_MudurlukId",
                        column: x => x.MudurlukId,
                        principalTable: "Mudurluks",
                        principalColumn: "MudurlukId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MudurlukYerleskecs_Yerleskes_YerleskeId",
                        column: x => x.YerleskeId,
                        principalTable: "Yerleskes",
                        principalColumn: "YerleskeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AmirlikYerleskecs",
                columns: table => new
                {
                    AmirlikID = table.Column<int>(type: "integer", nullable: false),
                    YerleskeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmirlikYerleskecs", x => new { x.YerleskeId, x.AmirlikID });
                    table.ForeignKey(
                        name: "FK_AmirlikYerleskecs_Amirliks_AmirlikID",
                        column: x => x.AmirlikID,
                        principalTable: "Amirliks",
                        principalColumn: "AmirlikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AmirlikYerleskecs_Yerleskes_YerleskeId",
                        column: x => x.YerleskeId,
                        principalTable: "Yerleskes",
                        principalColumn: "YerleskeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Odas",
                columns: table => new
                {
                    OdaId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OdaIsim = table.Column<string>(type: "text", nullable: true),
                    OdaSeriNo = table.Column<string>(type: "text", nullable: true),
                    OdaMudurlukMudurlukId = table.Column<int>(type: "integer", nullable: true),
                    OdaAmirlikAmirlikID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odas", x => x.OdaId);
                    table.ForeignKey(
                        name: "FK_Odas_Amirliks_OdaAmirlikAmirlikID",
                        column: x => x.OdaAmirlikAmirlikID,
                        principalTable: "Amirliks",
                        principalColumn: "AmirlikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Odas_Mudurluks_OdaMudurlukMudurlukId",
                        column: x => x.OdaMudurlukMudurlukId,
                        principalTable: "Mudurluks",
                        principalColumn: "MudurlukId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OdaYerleskecs",
                columns: table => new
                {
                    OdaId = table.Column<int>(type: "integer", nullable: false),
                    YerleskeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OdaYerleskecs", x => new { x.YerleskeId, x.OdaId });
                    table.ForeignKey(
                        name: "FK_OdaYerleskecs_Odas_OdaId",
                        column: x => x.OdaId,
                        principalTable: "Odas",
                        principalColumn: "OdaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OdaYerleskecs_Yerleskes_YerleskeId",
                        column: x => x.YerleskeId,
                        principalTable: "Yerleskes",
                        principalColumn: "YerleskeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "yerleskebakimonarims",
                columns: table => new
                {
                    YerleskeBakimOnarimId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BoyamaTarih = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ElektrikBakimTarih = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    SihhiTesisatBakimTarih = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    BakımOnarimAciklama = table.Column<string>(type: "text", nullable: true),
                    YerleskeBakimOnarimYerleskeYerleskeId = table.Column<int>(type: "integer", nullable: true),
                    YerleskeBakimOnarimMudurlukMudurlukId = table.Column<int>(type: "integer", nullable: true),
                    YerleskeBakimOnarimAmirlikAmirlikID = table.Column<int>(type: "integer", nullable: true),
                    YerleskeBakimOnarimOdaOdaId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yerleskebakimonarims", x => x.YerleskeBakimOnarimId);
                    table.ForeignKey(
                        name: "FK_yerleskebakimonarims_Amirliks_YerleskeBakimOnarimAmirlikAmi~",
                        column: x => x.YerleskeBakimOnarimAmirlikAmirlikID,
                        principalTable: "Amirliks",
                        principalColumn: "AmirlikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_yerleskebakimonarims_Mudurluks_YerleskeBakimOnarimMudurlukM~",
                        column: x => x.YerleskeBakimOnarimMudurlukMudurlukId,
                        principalTable: "Mudurluks",
                        principalColumn: "MudurlukId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_yerleskebakimonarims_Odas_YerleskeBakimOnarimOdaOdaId",
                        column: x => x.YerleskeBakimOnarimOdaOdaId,
                        principalTable: "Odas",
                        principalColumn: "OdaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_yerleskebakimonarims_Yerleskes_YerleskeBakimOnarimYerleskeY~",
                        column: x => x.YerleskeBakimOnarimYerleskeYerleskeId,
                        principalTable: "Yerleskes",
                        principalColumn: "YerleskeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "yerleskeiklimlendirmes",
                columns: table => new
                {
                    YerleskeIklimlendirmeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KayıtTarihi = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsitmaSistemi = table.Column<string>(type: "text", nullable: true),
                    SogutmaSistemi = table.Column<string>(type: "text", nullable: true),
                    IklimlendirmeAciklama = table.Column<string>(type: "text", nullable: true),
                    YerleskeIklimlendirmeYerleskeYerleskeId = table.Column<int>(type: "integer", nullable: true),
                    YerleskeIklimlendirmeMudurlukMudurlukId = table.Column<int>(type: "integer", nullable: true),
                    YerleskeIklimlendirmeAmirlikAmirlikID = table.Column<int>(type: "integer", nullable: true),
                    YerleskeIklimlendirmeOdaOdaId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yerleskeiklimlendirmes", x => x.YerleskeIklimlendirmeId);
                    table.ForeignKey(
                        name: "FK_yerleskeiklimlendirmes_Amirliks_YerleskeIklimlendirmeAmirli~",
                        column: x => x.YerleskeIklimlendirmeAmirlikAmirlikID,
                        principalTable: "Amirliks",
                        principalColumn: "AmirlikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_yerleskeiklimlendirmes_Mudurluks_YerleskeIklimlendirmeMudur~",
                        column: x => x.YerleskeIklimlendirmeMudurlukMudurlukId,
                        principalTable: "Mudurluks",
                        principalColumn: "MudurlukId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_yerleskeiklimlendirmes_Odas_YerleskeIklimlendirmeOdaOdaId",
                        column: x => x.YerleskeIklimlendirmeOdaOdaId,
                        principalTable: "Odas",
                        principalColumn: "OdaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_yerleskeiklimlendirmes_Yerleskes_YerleskeIklimlendirmeYerle~",
                        column: x => x.YerleskeIklimlendirmeYerleskeYerleskeId,
                        principalTable: "Yerleskes",
                        principalColumn: "YerleskeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "yerleskeTeknikBilgiler",
                columns: table => new
                {
                    YerleskeTeknikBilgilerId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KayıtTarihi = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    InsaatTipi = table.Column<string>(type: "text", nullable: true),
                    AlanBilgisi = table.Column<string>(type: "text", nullable: true),
                    Uzunluk = table.Column<int>(type: "integer", nullable: false),
                    Genislik = table.Column<int>(type: "integer", nullable: false),
                    ZeminBilgisi = table.Column<string>(type: "text", nullable: true),
                    KatBilgisi = table.Column<string>(type: "text", nullable: true),
                    Aydinlatma = table.Column<string>(type: "text", nullable: true),
                    CatiTipi = table.Column<string>(type: "text", nullable: true),
                    TeknikBilgilerAciklama = table.Column<string>(type: "text", nullable: true),
                    EngelliErisimi = table.Column<bool>(type: "boolean", maxLength: 5, nullable: false),
                    Asansör = table.Column<bool>(type: "boolean", maxLength: 5, nullable: false),
                    AcilCikis = table.Column<bool>(type: "boolean", maxLength: 5, nullable: false),
                    MerkeziYanginSondurme = table.Column<bool>(type: "boolean", maxLength: 5, nullable: false),
                    Diger = table.Column<string>(type: "text", nullable: true),
                    YerleskeTeknikBilgilerYerleskeYerleskeId = table.Column<int>(type: "integer", nullable: true),
                    YerleskeTeknikBilgilerMudurlukMudurlukId = table.Column<int>(type: "integer", nullable: true),
                    YerleskeTeknikBilgilerAmirlikAmirlikID = table.Column<int>(type: "integer", nullable: true),
                    YerleskeTeknikBilgilerOdaOdaId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yerleskeTeknikBilgiler", x => x.YerleskeTeknikBilgilerId);
                    table.ForeignKey(
                        name: "FK_yerleskeTeknikBilgiler_Amirliks_YerleskeTeknikBilgilerAmirl~",
                        column: x => x.YerleskeTeknikBilgilerAmirlikAmirlikID,
                        principalTable: "Amirliks",
                        principalColumn: "AmirlikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_yerleskeTeknikBilgiler_Mudurluks_YerleskeTeknikBilgilerMudu~",
                        column: x => x.YerleskeTeknikBilgilerMudurlukMudurlukId,
                        principalTable: "Mudurluks",
                        principalColumn: "MudurlukId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_yerleskeTeknikBilgiler_Odas_YerleskeTeknikBilgilerOdaOdaId",
                        column: x => x.YerleskeTeknikBilgilerOdaOdaId,
                        principalTable: "Odas",
                        principalColumn: "OdaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_yerleskeTeknikBilgiler_Yerleskes_YerleskeTeknikBilgilerYerl~",
                        column: x => x.YerleskeTeknikBilgilerYerleskeYerleskeId,
                        principalTable: "Yerleskes",
                        principalColumn: "YerleskeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Demirbases",
                columns: table => new
                {
                    DemirbasId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DemirbasIsim = table.Column<string>(type: "text", nullable: true),
                    DemirbasYerleskeYerleskeId = table.Column<int>(type: "integer", nullable: true),
                    DemirbasMudurlukMudurlukId = table.Column<int>(type: "integer", nullable: true),
                    DemirbasAmirlikAmirlikID = table.Column<int>(type: "integer", nullable: true),
                    DemirbasOdaOdaId = table.Column<int>(type: "integer", nullable: true),
                    DemirbasPersonelPersonelId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demirbases", x => x.DemirbasId);
                    table.ForeignKey(
                        name: "FK_Demirbases_Amirliks_DemirbasAmirlikAmirlikID",
                        column: x => x.DemirbasAmirlikAmirlikID,
                        principalTable: "Amirliks",
                        principalColumn: "AmirlikID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Demirbases_Mudurluks_DemirbasMudurlukMudurlukId",
                        column: x => x.DemirbasMudurlukMudurlukId,
                        principalTable: "Mudurluks",
                        principalColumn: "MudurlukId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Demirbases_Odas_DemirbasOdaOdaId",
                        column: x => x.DemirbasOdaOdaId,
                        principalTable: "Odas",
                        principalColumn: "OdaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Demirbases_Yerleskes_DemirbasYerleskeYerleskeId",
                        column: x => x.DemirbasYerleskeYerleskeId,
                        principalTable: "Yerleskes",
                        principalColumn: "YerleskeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fotolar",
                columns: table => new
                {
                    FotoId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FotoAdi = table.Column<string>(type: "text", nullable: true),
                    FotoAciklama = table.Column<string>(type: "text", nullable: true),
                    FotoData = table.Column<byte[]>(type: "bytea", nullable: true),
                    FotoEklenmeTarihi = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    YapilanIsAdi = table.Column<string>(type: "text", nullable: true),
                    YapilanIs = table.Column<string>(type: "text", nullable: true),
                    FotoMudurlukMudurlukId = table.Column<int>(type: "integer", nullable: true),
                    FotoAmirlikAmirlikID = table.Column<int>(type: "integer", nullable: true),
                    FotoOdaOdaId = table.Column<int>(type: "integer", nullable: true),
                    FotoPersonelPersonelId = table.Column<int>(type: "integer", nullable: true),
                    FotoYerleskeYerleskeId = table.Column<int>(type: "integer", nullable: true),
                    FotoDemirbasDemirbasId = table.Column<int>(type: "integer", nullable: true),
                    FotoSarfSarfId = table.Column<int>(type: "integer", nullable: true),
                    FotoYerleskeIklimlendirmeYerleskeIklimlendirmeId = table.Column<int>(type: "integer", nullable: true),
                    FotoYerleskeBakimOnarimYerleskeBakimOnarimId = table.Column<int>(type: "integer", nullable: true),
                    FotoYerleskeTeknikBilgilerYerleskeTeknikBilgilerId = table.Column<int>(type: "integer", nullable: true),
                    FotoTalepTalepId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotolar", x => x.FotoId);
                    table.ForeignKey(
                        name: "FK_Fotolar_Amirliks_FotoAmirlikAmirlikID",
                        column: x => x.FotoAmirlikAmirlikID,
                        principalTable: "Amirliks",
                        principalColumn: "AmirlikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fotolar_Demirbases_FotoDemirbasDemirbasId",
                        column: x => x.FotoDemirbasDemirbasId,
                        principalTable: "Demirbases",
                        principalColumn: "DemirbasId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fotolar_Mudurluks_FotoMudurlukMudurlukId",
                        column: x => x.FotoMudurlukMudurlukId,
                        principalTable: "Mudurluks",
                        principalColumn: "MudurlukId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fotolar_Odas_FotoOdaOdaId",
                        column: x => x.FotoOdaOdaId,
                        principalTable: "Odas",
                        principalColumn: "OdaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fotolar_yerleskebakimonarims_FotoYerleskeBakimOnarimYerlesk~",
                        column: x => x.FotoYerleskeBakimOnarimYerleskeBakimOnarimId,
                        principalTable: "yerleskebakimonarims",
                        principalColumn: "YerleskeBakimOnarimId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fotolar_yerleskeiklimlendirmes_FotoYerleskeIklimlendirmeYer~",
                        column: x => x.FotoYerleskeIklimlendirmeYerleskeIklimlendirmeId,
                        principalTable: "yerleskeiklimlendirmes",
                        principalColumn: "YerleskeIklimlendirmeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fotolar_Yerleskes_FotoYerleskeYerleskeId",
                        column: x => x.FotoYerleskeYerleskeId,
                        principalTable: "Yerleskes",
                        principalColumn: "YerleskeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fotolar_yerleskeTeknikBilgiler_FotoYerleskeTeknikBilgilerYe~",
                        column: x => x.FotoYerleskeTeknikBilgilerYerleskeTeknikBilgilerId,
                        principalTable: "yerleskeTeknikBilgiler",
                        principalColumn: "YerleskeTeknikBilgilerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personel",
                columns: table => new
                {
                    PersonelId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KullaniciAdi = table.Column<string>(type: "text", nullable: true),
                    PersonelIsim = table.Column<string>(type: "text", nullable: true),
                    PersonelSoyisim = table.Column<string>(type: "text", nullable: true),
                    PersonelSicil = table.Column<string>(type: "text", nullable: true),
                    PersonelTelefon = table.Column<string>(type: "text", nullable: true),
                    PersonelDahili = table.Column<string>(type: "text", nullable: true),
                    YetkiLevel = table.Column<string>(type: "text", nullable: true),
                    PersonelYetkiYetkiId = table.Column<int>(type: "integer", nullable: true),
                    PersonelYerleskeYerleskeId = table.Column<int>(type: "integer", nullable: true),
                    PersonelMudurlukMudurlukId = table.Column<int>(type: "integer", nullable: true),
                    PersonelAmirlikAmirlikID = table.Column<int>(type: "integer", nullable: true),
                    PersonelOdaOdaId = table.Column<int>(type: "integer", nullable: true),
                    YerleskeBakimOnarimId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personel", x => x.PersonelId);
                    table.ForeignKey(
                        name: "FK_Personel_Amirliks_PersonelAmirlikAmirlikID",
                        column: x => x.PersonelAmirlikAmirlikID,
                        principalTable: "Amirliks",
                        principalColumn: "AmirlikID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personel_Mudurluks_PersonelMudurlukMudurlukId",
                        column: x => x.PersonelMudurlukMudurlukId,
                        principalTable: "Mudurluks",
                        principalColumn: "MudurlukId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personel_Odas_PersonelOdaOdaId",
                        column: x => x.PersonelOdaOdaId,
                        principalTable: "Odas",
                        principalColumn: "OdaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personel_yerleskebakimonarims_YerleskeBakimOnarimId",
                        column: x => x.YerleskeBakimOnarimId,
                        principalTable: "yerleskebakimonarims",
                        principalColumn: "YerleskeBakimOnarimId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personel_Yerleskes_PersonelYerleskeYerleskeId",
                        column: x => x.PersonelYerleskeYerleskeId,
                        principalTable: "Yerleskes",
                        principalColumn: "YerleskeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ModulPersonelc",
                columns: table => new
                {
                    ModulId = table.Column<int>(type: "integer", nullable: false),
                    PersonelId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModulPersonelc", x => new { x.ModulId, x.PersonelId });
                    table.ForeignKey(
                        name: "FK_ModulPersonelc_Moduls_ModulId",
                        column: x => x.ModulId,
                        principalTable: "Moduls",
                        principalColumn: "ModulId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModulPersonelc_Personel_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personel",
                        principalColumn: "PersonelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sarfs",
                columns: table => new
                {
                    SarfId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SarfIsım = table.Column<string>(type: "text", nullable: true),
                    SarfYerleskeYerleskeId = table.Column<int>(type: "integer", nullable: true),
                    SarfMudurlukMudurlukId = table.Column<int>(type: "integer", nullable: true),
                    SarfAmirlikAmirlikID = table.Column<int>(type: "integer", nullable: true),
                    SarfOdaOdaId = table.Column<int>(type: "integer", nullable: true),
                    SarfPersonelPersonelId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sarfs", x => x.SarfId);
                    table.ForeignKey(
                        name: "FK_Sarfs_Amirliks_SarfAmirlikAmirlikID",
                        column: x => x.SarfAmirlikAmirlikID,
                        principalTable: "Amirliks",
                        principalColumn: "AmirlikID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sarfs_Mudurluks_SarfMudurlukMudurlukId",
                        column: x => x.SarfMudurlukMudurlukId,
                        principalTable: "Mudurluks",
                        principalColumn: "MudurlukId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sarfs_Odas_SarfOdaOdaId",
                        column: x => x.SarfOdaOdaId,
                        principalTable: "Odas",
                        principalColumn: "OdaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sarfs_Personel_SarfPersonelPersonelId",
                        column: x => x.SarfPersonelPersonelId,
                        principalTable: "Personel",
                        principalColumn: "PersonelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sarfs_Yerleskes_SarfYerleskeYerleskeId",
                        column: x => x.SarfYerleskeYerleskeId,
                        principalTable: "Yerleskes",
                        principalColumn: "YerleskeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Talep",
                columns: table => new
                {
                    TalepId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TalepTipi = table.Column<int>(type: "integer", nullable: false),
                    TalepBaslik = table.Column<string>(type: "text", nullable: true),
                    TalepKonu = table.Column<string>(type: "text", nullable: true),
                    TalepAciklama = table.Column<string>(type: "text", nullable: true),
                    YerleskeAciklamasi = table.Column<string>(type: "text", nullable: true),
                    AmirlikId = table.Column<string>(type: "text", nullable: true),
                    TalepAmirlikAmirlikID = table.Column<int>(type: "integer", nullable: true),
                    TalepIstipleriIstipiID = table.Column<int>(type: "integer", nullable: true),
                    TalebiIsteyenPersonelPersonelId = table.Column<int>(type: "integer", nullable: true),
                    TalebiKarsilayanPersonelPersonelId = table.Column<int>(type: "integer", nullable: true),
                    TalebinYapilmaTarihi = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TalebinKarsilanmaTarihi = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talep", x => x.TalepId);
                    table.ForeignKey(
                        name: "FK_Talep_Amirliks_TalepAmirlikAmirlikID",
                        column: x => x.TalepAmirlikAmirlikID,
                        principalTable: "Amirliks",
                        principalColumn: "AmirlikID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Talep_IsTipleris_TalepIstipleriIstipiID",
                        column: x => x.TalepIstipleriIstipiID,
                        principalTable: "IsTipleris",
                        principalColumn: "IstipiID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Talep_Personel_TalebiIsteyenPersonelPersonelId",
                        column: x => x.TalebiIsteyenPersonelPersonelId,
                        principalTable: "Personel",
                        principalColumn: "PersonelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Talep_Personel_TalebiKarsilayanPersonelPersonelId",
                        column: x => x.TalebiKarsilayanPersonelPersonelId,
                        principalTable: "Personel",
                        principalColumn: "PersonelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Yetki",
                columns: table => new
                {
                    YetkiId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Okuma = table.Column<bool>(type: "boolean", nullable: false),
                    Yazma = table.Column<bool>(type: "boolean", nullable: false),
                    Silme = table.Column<bool>(type: "boolean", nullable: false),
                    Guncelleme = table.Column<bool>(type: "boolean", nullable: false),
                    Yetkilendirme = table.Column<bool>(type: "boolean", nullable: false),
                    PersonelYetkisi = table.Column<bool>(type: "boolean", nullable: false),
                    ModulYoneticisiYetkisi = table.Column<bool>(type: "boolean", nullable: false),
                    AdminYetkisi = table.Column<bool>(type: "boolean", nullable: false),
                    YoneticiYetkisi = table.Column<bool>(type: "boolean", nullable: false),
                    YetkiTipi = table.Column<int>(type: "integer", nullable: false),
                    PersonelId = table.Column<int>(type: "integer", nullable: true),
                    ModulId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yetki", x => x.YetkiId);
                    table.ForeignKey(
                        name: "FK_Yetki_Moduls_ModulId",
                        column: x => x.ModulId,
                        principalTable: "Moduls",
                        principalColumn: "ModulId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Yetki_Personel_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personel",
                        principalColumn: "PersonelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IsAltTipleris",
                columns: table => new
                {
                    IsAltTipiId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsAltTipi = table.Column<string>(type: "text", nullable: true),
                    IsTipiEslesmeId = table.Column<string>(type: "text", nullable: true),
                    IsAltTipiAciklama = table.Column<string>(type: "text", nullable: true),
                    IstipiTalepTalepId = table.Column<int>(type: "integer", nullable: true),
                    TalepSonucuId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsAltTipleris", x => x.IsAltTipiId);
                    table.ForeignKey(
                        name: "FK_IsAltTipleris_Talep_IstipiTalepTalepId",
                        column: x => x.IstipiTalepTalepId,
                        principalTable: "Talep",
                        principalColumn: "TalepId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IsAltTipleris_TalepSonucus_TalepSonucuId",
                        column: x => x.TalepSonucuId,
                        principalTable: "TalepSonucus",
                        principalColumn: "TalepSonucuId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Amirliks_AmirlikMudurlukMudurlukId",
                table: "Amirliks",
                column: "AmirlikMudurlukMudurlukId");

            migrationBuilder.CreateIndex(
                name: "IX_Amirliks_AmirlikSeriNo",
                table: "Amirliks",
                column: "AmirlikSeriNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AmirlikYerleskecs_AmirlikID",
                table: "AmirlikYerleskecs",
                column: "AmirlikID");

            migrationBuilder.CreateIndex(
                name: "IX_Demirbases_DemirbasAmirlikAmirlikID",
                table: "Demirbases",
                column: "DemirbasAmirlikAmirlikID");

            migrationBuilder.CreateIndex(
                name: "IX_Demirbases_DemirbasMudurlukMudurlukId",
                table: "Demirbases",
                column: "DemirbasMudurlukMudurlukId");

            migrationBuilder.CreateIndex(
                name: "IX_Demirbases_DemirbasOdaOdaId",
                table: "Demirbases",
                column: "DemirbasOdaOdaId");

            migrationBuilder.CreateIndex(
                name: "IX_Demirbases_DemirbasPersonelPersonelId",
                table: "Demirbases",
                column: "DemirbasPersonelPersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_Demirbases_DemirbasYerleskeYerleskeId",
                table: "Demirbases",
                column: "DemirbasYerleskeYerleskeId");

            migrationBuilder.CreateIndex(
                name: "IX_Fotolar_FotoAmirlikAmirlikID",
                table: "Fotolar",
                column: "FotoAmirlikAmirlikID");

            migrationBuilder.CreateIndex(
                name: "IX_Fotolar_FotoDemirbasDemirbasId",
                table: "Fotolar",
                column: "FotoDemirbasDemirbasId");

            migrationBuilder.CreateIndex(
                name: "IX_Fotolar_FotoMudurlukMudurlukId",
                table: "Fotolar",
                column: "FotoMudurlukMudurlukId");

            migrationBuilder.CreateIndex(
                name: "IX_Fotolar_FotoOdaOdaId",
                table: "Fotolar",
                column: "FotoOdaOdaId");

            migrationBuilder.CreateIndex(
                name: "IX_Fotolar_FotoPersonelPersonelId",
                table: "Fotolar",
                column: "FotoPersonelPersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_Fotolar_FotoSarfSarfId",
                table: "Fotolar",
                column: "FotoSarfSarfId");

            migrationBuilder.CreateIndex(
                name: "IX_Fotolar_FotoTalepTalepId",
                table: "Fotolar",
                column: "FotoTalepTalepId");

            migrationBuilder.CreateIndex(
                name: "IX_Fotolar_FotoYerleskeBakimOnarimYerleskeBakimOnarimId",
                table: "Fotolar",
                column: "FotoYerleskeBakimOnarimYerleskeBakimOnarimId");

            migrationBuilder.CreateIndex(
                name: "IX_Fotolar_FotoYerleskeIklimlendirmeYerleskeIklimlendirmeId",
                table: "Fotolar",
                column: "FotoYerleskeIklimlendirmeYerleskeIklimlendirmeId");

            migrationBuilder.CreateIndex(
                name: "IX_Fotolar_FotoYerleskeTeknikBilgilerYerleskeTeknikBilgilerId",
                table: "Fotolar",
                column: "FotoYerleskeTeknikBilgilerYerleskeTeknikBilgilerId");

            migrationBuilder.CreateIndex(
                name: "IX_Fotolar_FotoYerleskeYerleskeId",
                table: "Fotolar",
                column: "FotoYerleskeYerleskeId");

            migrationBuilder.CreateIndex(
                name: "IX_IsAltTipleris_IstipiTalepTalepId",
                table: "IsAltTipleris",
                column: "IstipiTalepTalepId");

            migrationBuilder.CreateIndex(
                name: "IX_IsAltTipleris_TalepSonucuId",
                table: "IsAltTipleris",
                column: "TalepSonucuId");

            migrationBuilder.CreateIndex(
                name: "IX_ModulPersonelc_PersonelId",
                table: "ModulPersonelc",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_Mudurluks_MudurlukSeriNo",
                table: "Mudurluks",
                column: "MudurlukSeriNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MudurlukYerleskecs_MudurlukId",
                table: "MudurlukYerleskecs",
                column: "MudurlukId");

            migrationBuilder.CreateIndex(
                name: "IX_Odas_OdaAmirlikAmirlikID",
                table: "Odas",
                column: "OdaAmirlikAmirlikID");

            migrationBuilder.CreateIndex(
                name: "IX_Odas_OdaMudurlukMudurlukId",
                table: "Odas",
                column: "OdaMudurlukMudurlukId");

            migrationBuilder.CreateIndex(
                name: "IX_Odas_OdaSeriNo",
                table: "Odas",
                column: "OdaSeriNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OdaYerleskecs_OdaId",
                table: "OdaYerleskecs",
                column: "OdaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personel_PersonelAmirlikAmirlikID",
                table: "Personel",
                column: "PersonelAmirlikAmirlikID");

            migrationBuilder.CreateIndex(
                name: "IX_Personel_PersonelId",
                table: "Personel",
                column: "PersonelId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personel_PersonelMudurlukMudurlukId",
                table: "Personel",
                column: "PersonelMudurlukMudurlukId");

            migrationBuilder.CreateIndex(
                name: "IX_Personel_PersonelOdaOdaId",
                table: "Personel",
                column: "PersonelOdaOdaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personel_PersonelYerleskeYerleskeId",
                table: "Personel",
                column: "PersonelYerleskeYerleskeId");

            migrationBuilder.CreateIndex(
                name: "IX_Personel_PersonelYetkiYetkiId",
                table: "Personel",
                column: "PersonelYetkiYetkiId");

            migrationBuilder.CreateIndex(
                name: "IX_Personel_YerleskeBakimOnarimId",
                table: "Personel",
                column: "YerleskeBakimOnarimId");

            migrationBuilder.CreateIndex(
                name: "IX_Sarfs_SarfAmirlikAmirlikID",
                table: "Sarfs",
                column: "SarfAmirlikAmirlikID");

            migrationBuilder.CreateIndex(
                name: "IX_Sarfs_SarfMudurlukMudurlukId",
                table: "Sarfs",
                column: "SarfMudurlukMudurlukId");

            migrationBuilder.CreateIndex(
                name: "IX_Sarfs_SarfOdaOdaId",
                table: "Sarfs",
                column: "SarfOdaOdaId");

            migrationBuilder.CreateIndex(
                name: "IX_Sarfs_SarfPersonelPersonelId",
                table: "Sarfs",
                column: "SarfPersonelPersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_Sarfs_SarfYerleskeYerleskeId",
                table: "Sarfs",
                column: "SarfYerleskeYerleskeId");

            migrationBuilder.CreateIndex(
                name: "IX_TakvimDetaylari_TakvimTakvimDetaylariTakvimId",
                table: "TakvimDetaylari",
                column: "TakvimTakvimDetaylariTakvimId");

            migrationBuilder.CreateIndex(
                name: "IX_Talep_TalebiIsteyenPersonelPersonelId",
                table: "Talep",
                column: "TalebiIsteyenPersonelPersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_Talep_TalebiKarsilayanPersonelPersonelId",
                table: "Talep",
                column: "TalebiKarsilayanPersonelPersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_Talep_TalepAmirlikAmirlikID",
                table: "Talep",
                column: "TalepAmirlikAmirlikID");

            migrationBuilder.CreateIndex(
                name: "IX_Talep_TalepIstipleriIstipiID",
                table: "Talep",
                column: "TalepIstipleriIstipiID");

            migrationBuilder.CreateIndex(
                name: "IX_yerleskebakimonarims_YerleskeBakimOnarimAmirlikAmirlikID",
                table: "yerleskebakimonarims",
                column: "YerleskeBakimOnarimAmirlikAmirlikID");

            migrationBuilder.CreateIndex(
                name: "IX_yerleskebakimonarims_YerleskeBakimOnarimMudurlukMudurlukId",
                table: "yerleskebakimonarims",
                column: "YerleskeBakimOnarimMudurlukMudurlukId");

            migrationBuilder.CreateIndex(
                name: "IX_yerleskebakimonarims_YerleskeBakimOnarimOdaOdaId",
                table: "yerleskebakimonarims",
                column: "YerleskeBakimOnarimOdaOdaId");

            migrationBuilder.CreateIndex(
                name: "IX_yerleskebakimonarims_YerleskeBakimOnarimYerleskeYerleskeId",
                table: "yerleskebakimonarims",
                column: "YerleskeBakimOnarimYerleskeYerleskeId");

            migrationBuilder.CreateIndex(
                name: "IX_yerleskeiklimlendirmes_YerleskeIklimlendirmeAmirlikAmirlikID",
                table: "yerleskeiklimlendirmes",
                column: "YerleskeIklimlendirmeAmirlikAmirlikID");

            migrationBuilder.CreateIndex(
                name: "IX_yerleskeiklimlendirmes_YerleskeIklimlendirmeMudurlukMudurlu~",
                table: "yerleskeiklimlendirmes",
                column: "YerleskeIklimlendirmeMudurlukMudurlukId");

            migrationBuilder.CreateIndex(
                name: "IX_yerleskeiklimlendirmes_YerleskeIklimlendirmeOdaOdaId",
                table: "yerleskeiklimlendirmes",
                column: "YerleskeIklimlendirmeOdaOdaId");

            migrationBuilder.CreateIndex(
                name: "IX_yerleskeiklimlendirmes_YerleskeIklimlendirmeYerleskeYerlesk~",
                table: "yerleskeiklimlendirmes",
                column: "YerleskeIklimlendirmeYerleskeYerleskeId");

            migrationBuilder.CreateIndex(
                name: "IX_Yerleskes_YerleskeSeriNo",
                table: "Yerleskes",
                column: "YerleskeSeriNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_yerleskeTeknikBilgiler_YerleskeTeknikBilgilerAmirlikAmirlik~",
                table: "yerleskeTeknikBilgiler",
                column: "YerleskeTeknikBilgilerAmirlikAmirlikID");

            migrationBuilder.CreateIndex(
                name: "IX_yerleskeTeknikBilgiler_YerleskeTeknikBilgilerMudurlukMudurl~",
                table: "yerleskeTeknikBilgiler",
                column: "YerleskeTeknikBilgilerMudurlukMudurlukId");

            migrationBuilder.CreateIndex(
                name: "IX_yerleskeTeknikBilgiler_YerleskeTeknikBilgilerOdaOdaId",
                table: "yerleskeTeknikBilgiler",
                column: "YerleskeTeknikBilgilerOdaOdaId");

            migrationBuilder.CreateIndex(
                name: "IX_yerleskeTeknikBilgiler_YerleskeTeknikBilgilerYerleskeYerles~",
                table: "yerleskeTeknikBilgiler",
                column: "YerleskeTeknikBilgilerYerleskeYerleskeId");

            migrationBuilder.CreateIndex(
                name: "IX_Yetki_ModulId",
                table: "Yetki",
                column: "ModulId");

            migrationBuilder.CreateIndex(
                name: "IX_Yetki_PersonelId",
                table: "Yetki",
                column: "PersonelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Demirbases_Personel_DemirbasPersonelPersonelId",
                table: "Demirbases",
                column: "DemirbasPersonelPersonelId",
                principalTable: "Personel",
                principalColumn: "PersonelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fotolar_Personel_FotoPersonelPersonelId",
                table: "Fotolar",
                column: "FotoPersonelPersonelId",
                principalTable: "Personel",
                principalColumn: "PersonelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fotolar_Sarfs_FotoSarfSarfId",
                table: "Fotolar",
                column: "FotoSarfSarfId",
                principalTable: "Sarfs",
                principalColumn: "SarfId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fotolar_Talep_FotoTalepTalepId",
                table: "Fotolar",
                column: "FotoTalepTalepId",
                principalTable: "Talep",
                principalColumn: "TalepId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personel_Yetki_PersonelYetkiYetkiId",
                table: "Personel",
                column: "PersonelYetkiYetkiId",
                principalTable: "Yetki",
                principalColumn: "YetkiId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Amirliks_Mudurluks_AmirlikMudurlukMudurlukId",
                table: "Amirliks");

            migrationBuilder.DropForeignKey(
                name: "FK_Odas_Mudurluks_OdaMudurlukMudurlukId",
                table: "Odas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personel_Mudurluks_PersonelMudurlukMudurlukId",
                table: "Personel");

            migrationBuilder.DropForeignKey(
                name: "FK_yerleskebakimonarims_Mudurluks_YerleskeBakimOnarimMudurlukM~",
                table: "yerleskebakimonarims");

            migrationBuilder.DropForeignKey(
                name: "FK_Odas_Amirliks_OdaAmirlikAmirlikID",
                table: "Odas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personel_Amirliks_PersonelAmirlikAmirlikID",
                table: "Personel");

            migrationBuilder.DropForeignKey(
                name: "FK_yerleskebakimonarims_Amirliks_YerleskeBakimOnarimAmirlikAmi~",
                table: "yerleskebakimonarims");

            migrationBuilder.DropForeignKey(
                name: "FK_Personel_Yerleskes_PersonelYerleskeYerleskeId",
                table: "Personel");

            migrationBuilder.DropForeignKey(
                name: "FK_yerleskebakimonarims_Yerleskes_YerleskeBakimOnarimYerleskeY~",
                table: "yerleskebakimonarims");

            migrationBuilder.DropForeignKey(
                name: "FK_Personel_Odas_PersonelOdaOdaId",
                table: "Personel");

            migrationBuilder.DropForeignKey(
                name: "FK_yerleskebakimonarims_Odas_YerleskeBakimOnarimOdaOdaId",
                table: "yerleskebakimonarims");

            migrationBuilder.DropForeignKey(
                name: "FK_Yetki_Personel_PersonelId",
                table: "Yetki");

            migrationBuilder.DropTable(
                name: "AmirlikYerleskecs");

            migrationBuilder.DropTable(
                name: "Fotolar");

            migrationBuilder.DropTable(
                name: "IsAltTipleris");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "ModulPersonelc");

            migrationBuilder.DropTable(
                name: "MudurlukYerleskecs");

            migrationBuilder.DropTable(
                name: "OdaYerleskecs");

            migrationBuilder.DropTable(
                name: "SeriNo");

            migrationBuilder.DropTable(
                name: "TakvimDetaylari");

            migrationBuilder.DropTable(
                name: "TalepAltSonucus");

            migrationBuilder.DropTable(
                name: "Tanimlamalars");

            migrationBuilder.DropTable(
                name: "UygulamaAyarlaris");

            migrationBuilder.DropTable(
                name: "Demirbases");

            migrationBuilder.DropTable(
                name: "Sarfs");

            migrationBuilder.DropTable(
                name: "yerleskeiklimlendirmes");

            migrationBuilder.DropTable(
                name: "yerleskeTeknikBilgiler");

            migrationBuilder.DropTable(
                name: "Talep");

            migrationBuilder.DropTable(
                name: "TalepSonucus");

            migrationBuilder.DropTable(
                name: "Takvims");

            migrationBuilder.DropTable(
                name: "IsTipleris");

            migrationBuilder.DropTable(
                name: "Mudurluks");

            migrationBuilder.DropTable(
                name: "Amirliks");

            migrationBuilder.DropTable(
                name: "Yerleskes");

            migrationBuilder.DropTable(
                name: "Odas");

            migrationBuilder.DropTable(
                name: "Personel");

            migrationBuilder.DropTable(
                name: "yerleskebakimonarims");

            migrationBuilder.DropTable(
                name: "Yetki");

            migrationBuilder.DropTable(
                name: "Moduls");
        }
    }
}
