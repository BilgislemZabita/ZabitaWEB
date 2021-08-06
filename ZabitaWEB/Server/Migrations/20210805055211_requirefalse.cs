using Microsoft.EntityFrameworkCore.Migrations;

namespace Zabita.DataAccessLayer.Migrations
{
    public partial class requirefalse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_yerleskeTeknikBilgiler_Talep_YerleskeTeknikBilgiTalepId",
                table: "yerleskeTeknikBilgiler");

            migrationBuilder.AddForeignKey(
                name: "FK_yerleskeTeknikBilgiler_Talep_YerleskeTeknikBilgiTalepId",
                table: "yerleskeTeknikBilgiler",
                column: "YerleskeTeknikBilgiTalepId",
                principalTable: "Talep",
                principalColumn: "TalepId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_yerleskeTeknikBilgiler_Talep_YerleskeTeknikBilgiTalepId",
                table: "yerleskeTeknikBilgiler");

            migrationBuilder.AddForeignKey(
                name: "FK_yerleskeTeknikBilgiler_Talep_YerleskeTeknikBilgiTalepId",
                table: "yerleskeTeknikBilgiler",
                column: "YerleskeTeknikBilgiTalepId",
                principalTable: "Talep",
                principalColumn: "TalepId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
