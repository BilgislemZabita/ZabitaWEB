using Microsoft.EntityFrameworkCore.Migrations;

namespace Zabita.DataAccessLayer.Migrations
{
    public partial class talepupdatejıu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Talep_Personel_TalebiIsteyenPersonelPersonelId",
                table: "Talep");

            migrationBuilder.DropForeignKey(
                name: "FK_Talep_Personel_TalebiKarsilayanPersonelPersonelId",
                table: "Talep");

            migrationBuilder.DropIndex(
                name: "IX_Talep_TalebiIsteyenPersonelPersonelId",
                table: "Talep");

            migrationBuilder.DropColumn(
                name: "TalebiIsteyenPersonelPersonelId",
                table: "Talep");

            migrationBuilder.RenameColumn(
                name: "TalebiKarsilayanPersonelPersonelId",
                table: "Talep",
                newName: "PersonelId");

            migrationBuilder.RenameIndex(
                name: "IX_Talep_TalebiKarsilayanPersonelPersonelId",
                table: "Talep",
                newName: "IX_Talep_PersonelId");

            migrationBuilder.AddColumn<int>(
                name: "TalebiAtayanPersonelId",
                table: "Talep",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TalebiIsteyenPersonelId",
                table: "Talep",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TalebiKarsilayanPersonelId",
                table: "Talep",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Talep_Personel_PersonelId",
                table: "Talep",
                column: "PersonelId",
                principalTable: "Personel",
                principalColumn: "PersonelId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Talep_Personel_PersonelId",
                table: "Talep");

            migrationBuilder.DropColumn(
                name: "TalebiAtayanPersonelId",
                table: "Talep");

            migrationBuilder.DropColumn(
                name: "TalebiIsteyenPersonelId",
                table: "Talep");

            migrationBuilder.DropColumn(
                name: "TalebiKarsilayanPersonelId",
                table: "Talep");

            migrationBuilder.RenameColumn(
                name: "PersonelId",
                table: "Talep",
                newName: "TalebiKarsilayanPersonelPersonelId");

            migrationBuilder.RenameIndex(
                name: "IX_Talep_PersonelId",
                table: "Talep",
                newName: "IX_Talep_TalebiKarsilayanPersonelPersonelId");

            migrationBuilder.AddColumn<int>(
                name: "TalebiIsteyenPersonelPersonelId",
                table: "Talep",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Talep_TalebiIsteyenPersonelPersonelId",
                table: "Talep",
                column: "TalebiIsteyenPersonelPersonelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Talep_Personel_TalebiIsteyenPersonelPersonelId",
                table: "Talep",
                column: "TalebiIsteyenPersonelPersonelId",
                principalTable: "Personel",
                principalColumn: "PersonelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Talep_Personel_TalebiKarsilayanPersonelPersonelId",
                table: "Talep",
                column: "TalebiKarsilayanPersonelPersonelId",
                principalTable: "Personel",
                principalColumn: "PersonelId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
