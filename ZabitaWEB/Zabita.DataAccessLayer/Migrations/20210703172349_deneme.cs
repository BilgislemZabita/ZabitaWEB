using Microsoft.EntityFrameworkCore.Migrations;

namespace Zabita.DataAccessLayer.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TalepId1",
                table: "TalepAltSonucus",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TalepAltSonucus_TalepId1",
                table: "TalepAltSonucus",
                column: "TalepId1");

            migrationBuilder.AddForeignKey(
                name: "FK_TalepAltSonucus_Talep_TalepId1",
                table: "TalepAltSonucus",
                column: "TalepId1",
                principalTable: "Talep",
                principalColumn: "TalepId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TalepAltSonucus_Talep_TalepId1",
                table: "TalepAltSonucus");

            migrationBuilder.DropIndex(
                name: "IX_TalepAltSonucus_TalepId1",
                table: "TalepAltSonucus");

            migrationBuilder.DropColumn(
                name: "TalepId1",
                table: "TalepAltSonucus");
        }
    }
}
