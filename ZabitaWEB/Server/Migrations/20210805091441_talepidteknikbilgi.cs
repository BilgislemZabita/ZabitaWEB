using Microsoft.EntityFrameworkCore.Migrations;

namespace Zabita.DataAccessLayer.Migrations
{
    public partial class talepidteknikbilgi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_yerleskeTeknikBilgiler_Talep_YerleskeTeknikBilgiTalepId",
                table: "yerleskeTeknikBilgiler");

            migrationBuilder.DropIndex(
                name: "IX_yerleskeTeknikBilgiler_YerleskeTeknikBilgiTalepId",
                table: "yerleskeTeknikBilgiler");

            migrationBuilder.DropColumn(
                name: "YerleskeTeknikBilgiTalepId",
                table: "yerleskeTeknikBilgiler");

            migrationBuilder.AddColumn<int>(
                name: "YerleskeTeknikBilgiTalepTalepId",
                table: "yerleskeTeknikBilgiler",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_yerleskeTeknikBilgiler_YerleskeTeknikBilgiTalepTalepId",
                table: "yerleskeTeknikBilgiler",
                column: "YerleskeTeknikBilgiTalepTalepId");

            migrationBuilder.AddForeignKey(
                name: "FK_yerleskeTeknikBilgiler_Talep_YerleskeTeknikBilgiTalepTalepId",
                table: "yerleskeTeknikBilgiler",
                column: "YerleskeTeknikBilgiTalepTalepId",
                principalTable: "Talep",
                principalColumn: "TalepId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_yerleskeTeknikBilgiler_Talep_YerleskeTeknikBilgiTalepTalepId",
                table: "yerleskeTeknikBilgiler");

            migrationBuilder.DropIndex(
                name: "IX_yerleskeTeknikBilgiler_YerleskeTeknikBilgiTalepTalepId",
                table: "yerleskeTeknikBilgiler");

            migrationBuilder.DropColumn(
                name: "YerleskeTeknikBilgiTalepTalepId",
                table: "yerleskeTeknikBilgiler");

            migrationBuilder.AddColumn<int>(
                name: "YerleskeTeknikBilgiTalepId",
                table: "yerleskeTeknikBilgiler",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_yerleskeTeknikBilgiler_YerleskeTeknikBilgiTalepId",
                table: "yerleskeTeknikBilgiler",
                column: "YerleskeTeknikBilgiTalepId");

            migrationBuilder.AddForeignKey(
                name: "FK_yerleskeTeknikBilgiler_Talep_YerleskeTeknikBilgiTalepId",
                table: "yerleskeTeknikBilgiler",
                column: "YerleskeTeknikBilgiTalepId",
                principalTable: "Talep",
                principalColumn: "TalepId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
