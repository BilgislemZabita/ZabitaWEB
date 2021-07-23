using Microsoft.EntityFrameworkCore.Migrations;

namespace Zabita.DataAccessLayer.Migrations
{
    public partial class talepaltsonucu6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TalepAltSonucus_Talep_TaleptalepaltsonucuTalepId",
                table: "TalepAltSonucus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TalepAltSonucus",
                table: "TalepAltSonucus");

            migrationBuilder.RenameTable(
                name: "TalepAltSonucus",
                newName: "TalepAltSonucu");

            migrationBuilder.RenameIndex(
                name: "IX_TalepAltSonucus_TaleptalepaltsonucuTalepId",
                table: "TalepAltSonucu",
                newName: "IX_TalepAltSonucu_TaleptalepaltsonucuTalepId");

            migrationBuilder.AddColumn<int>(
                name: "AmirlikID",
                table: "TalepAltSonucu",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonelId",
                table: "TalepAltSonucu",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TalepAltSonucu",
                table: "TalepAltSonucu",
                column: "TalepAltSonucuId");

            migrationBuilder.CreateIndex(
                name: "IX_TalepAltSonucu_AmirlikID",
                table: "TalepAltSonucu",
                column: "AmirlikID");

            migrationBuilder.CreateIndex(
                name: "IX_TalepAltSonucu_PersonelId",
                table: "TalepAltSonucu",
                column: "PersonelId");

            migrationBuilder.AddForeignKey(
                name: "FK_TalepAltSonucu_Amirliks_AmirlikID",
                table: "TalepAltSonucu",
                column: "AmirlikID",
                principalTable: "Amirliks",
                principalColumn: "AmirlikID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TalepAltSonucu_Personel_PersonelId",
                table: "TalepAltSonucu",
                column: "PersonelId",
                principalTable: "Personel",
                principalColumn: "PersonelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TalepAltSonucu_Talep_TaleptalepaltsonucuTalepId",
                table: "TalepAltSonucu",
                column: "TaleptalepaltsonucuTalepId",
                principalTable: "Talep",
                principalColumn: "TalepId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TalepAltSonucu_Amirliks_AmirlikID",
                table: "TalepAltSonucu");

            migrationBuilder.DropForeignKey(
                name: "FK_TalepAltSonucu_Personel_PersonelId",
                table: "TalepAltSonucu");

            migrationBuilder.DropForeignKey(
                name: "FK_TalepAltSonucu_Talep_TaleptalepaltsonucuTalepId",
                table: "TalepAltSonucu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TalepAltSonucu",
                table: "TalepAltSonucu");

            migrationBuilder.DropIndex(
                name: "IX_TalepAltSonucu_AmirlikID",
                table: "TalepAltSonucu");

            migrationBuilder.DropIndex(
                name: "IX_TalepAltSonucu_PersonelId",
                table: "TalepAltSonucu");

            migrationBuilder.DropColumn(
                name: "AmirlikID",
                table: "TalepAltSonucu");

            migrationBuilder.DropColumn(
                name: "PersonelId",
                table: "TalepAltSonucu");

            migrationBuilder.RenameTable(
                name: "TalepAltSonucu",
                newName: "TalepAltSonucus");

            migrationBuilder.RenameIndex(
                name: "IX_TalepAltSonucu_TaleptalepaltsonucuTalepId",
                table: "TalepAltSonucus",
                newName: "IX_TalepAltSonucus_TaleptalepaltsonucuTalepId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TalepAltSonucus",
                table: "TalepAltSonucus",
                column: "TalepAltSonucuId");

            migrationBuilder.AddForeignKey(
                name: "FK_TalepAltSonucus_Talep_TaleptalepaltsonucuTalepId",
                table: "TalepAltSonucus",
                column: "TaleptalepaltsonucuTalepId",
                principalTable: "Talep",
                principalColumn: "TalepId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
