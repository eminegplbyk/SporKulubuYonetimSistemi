using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SporKulubuYS_Service.Migrations
{
    /// <inheritdoc />
    public partial class Deneme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Antrenorler",
                columns: table => new
                {
                    AntrenorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AntrenorAd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AntrenorSoyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Uzmanlık = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AntrenorDogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ulke = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Antrenorler", x => x.AntrenorId);
                });

            migrationBuilder.CreateTable(
                name: "Branslar",
                columns: table => new
                {
                    BransId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BransAd = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branslar", x => x.BransId);
                });

            migrationBuilder.CreateTable(
                name: "Sporcular",
                columns: table => new
                {
                    SporcuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SporcuAd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SporcuSoyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SporcuDogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cinsiyet = table.Column<bool>(type: "bit", nullable: false),
                    Eposta = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sporcular", x => x.SporcuId);
                });

            migrationBuilder.CreateTable(
                name: "BransAntrenorler",
                columns: table => new
                {
                    BransAntrenorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AntrenorId = table.Column<int>(type: "int", nullable: false),
                    BransId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BransAntrenorler", x => x.BransAntrenorId);
                    table.ForeignKey(
                        name: "FK_BransAntrenorler_Antrenorler_AntrenorId",
                        column: x => x.AntrenorId,
                        principalTable: "Antrenorler",
                        principalColumn: "AntrenorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BransAntrenorler_Branslar_BransId",
                        column: x => x.BransId,
                        principalTable: "Branslar",
                        principalColumn: "BransId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Etkinlikler",
                columns: table => new
                {
                    EtkinlikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BransId = table.Column<int>(type: "int", nullable: false),
                    EtkinlikAd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EtkinlikYer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EtkinlikTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EtkinlikAciklama = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etkinlikler", x => x.EtkinlikId);
                    table.ForeignKey(
                        name: "FK_Etkinlikler_Branslar_BransId",
                        column: x => x.BransId,
                        principalTable: "Branslar",
                        principalColumn: "BransId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Salonlar",
                columns: table => new
                {
                    SalonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BransId = table.Column<int>(type: "int", nullable: false),
                    SalonAd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Kapasite = table.Column<int>(type: "int", nullable: false),
                    SalonYer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salonlar", x => x.SalonId);
                    table.ForeignKey(
                        name: "FK_Salonlar_Branslar_BransId",
                        column: x => x.BransId,
                        principalTable: "Branslar",
                        principalColumn: "BransId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SporcuBranslar",
                columns: table => new
                {
                    SporcuBransId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SporcuId = table.Column<int>(type: "int", nullable: false),
                    BransId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SporcuBranslar", x => x.SporcuBransId);
                    table.ForeignKey(
                        name: "FK_SporcuBranslar_Branslar_BransId",
                        column: x => x.BransId,
                        principalTable: "Branslar",
                        principalColumn: "BransId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SporcuBranslar_Sporcular_SporcuId",
                        column: x => x.SporcuId,
                        principalTable: "Sporcular",
                        principalColumn: "SporcuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BransAntrenorler_AntrenorId",
                table: "BransAntrenorler",
                column: "AntrenorId");

            migrationBuilder.CreateIndex(
                name: "IX_BransAntrenorler_BransId",
                table: "BransAntrenorler",
                column: "BransId");

            migrationBuilder.CreateIndex(
                name: "IX_Etkinlikler_BransId",
                table: "Etkinlikler",
                column: "BransId");

            migrationBuilder.CreateIndex(
                name: "IX_Salonlar_BransId",
                table: "Salonlar",
                column: "BransId");

            migrationBuilder.CreateIndex(
                name: "IX_SporcuBranslar_BransId",
                table: "SporcuBranslar",
                column: "BransId");

            migrationBuilder.CreateIndex(
                name: "IX_SporcuBranslar_SporcuId",
                table: "SporcuBranslar",
                column: "SporcuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BransAntrenorler");

            migrationBuilder.DropTable(
                name: "Etkinlikler");

            migrationBuilder.DropTable(
                name: "Salonlar");

            migrationBuilder.DropTable(
                name: "SporcuBranslar");

            migrationBuilder.DropTable(
                name: "Antrenorler");

            migrationBuilder.DropTable(
                name: "Branslar");

            migrationBuilder.DropTable(
                name: "Sporcular");
        }
    }
}
