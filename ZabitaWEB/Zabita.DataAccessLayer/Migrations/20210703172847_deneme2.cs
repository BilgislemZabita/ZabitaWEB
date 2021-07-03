using Microsoft.EntityFrameworkCore.Migrations;

namespace Zabita.DataAccessLayer.Migrations
{
    public partial class deneme2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TalepAltSonucus_Talep_TalepId1",
                table: "TalepAltSonucus");

            migrationBuilder.RenameColumn(
                name: "TalepId1",
                table: "TalepAltSonucus",
                newName: "TaleptalepaltsonucuTalepId");

            migrationBuilder.RenameIndex(
                name: "IX_TalepAltSonucus_TalepId1",
                table: "TalepAltSonucus",
                newName: "IX_TalepAltSonucus_TaleptalepaltsonucuTalepId");

            migrationBuilder.AddForeignKey(
                name: "FK_TalepAltSonucus_Talep_TaleptalepaltsonucuTalepId",
                table: "TalepAltSonucus",
                column: "TaleptalepaltsonucuTalepId",
                principalTable: "Talep",
                principalColumn: "TalepId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TalepAltSonucus_Talep_TaleptalepaltsonucuTalepId",
                table: "TalepAltSonucus");

            migrationBuilder.RenameColumn(
                name: "TaleptalepaltsonucuTalepId",
                table: "TalepAltSonucus",
                newName: "TalepId1");

            migrationBuilder.RenameIndex(
                name: "IX_TalepAltSonucus_TaleptalepaltsonucuTalepId",
                table: "TalepAltSonucus",
                newName: "IX_TalepAltSonucus_TalepId1");

            migrationBuilder.AddForeignKey(
                name: "FK_TalepAltSonucus_Talep_TalepId1",
                table: "TalepAltSonucus",
                column: "TalepId1",
                principalTable: "Talep",
                principalColumn: "TalepId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
