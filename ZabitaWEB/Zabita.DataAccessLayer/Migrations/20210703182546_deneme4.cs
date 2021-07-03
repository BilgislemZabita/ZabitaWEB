using Microsoft.EntityFrameworkCore.Migrations;

namespace Zabita.DataAccessLayer.Migrations
{
    public partial class deneme4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TalepIstipleriIDIstipiID",
                table: "Talep",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Talep_TalepIstipleriIDIstipiID",
                table: "Talep",
                column: "TalepIstipleriIDIstipiID");

            migrationBuilder.AddForeignKey(
                name: "FK_Talep_IsTipleris_TalepIstipleriIDIstipiID",
                table: "Talep",
                column: "TalepIstipleriIDIstipiID",
                principalTable: "IsTipleris",
                principalColumn: "IstipiID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Talep_IsTipleris_TalepIstipleriIDIstipiID",
                table: "Talep");

            migrationBuilder.DropIndex(
                name: "IX_Talep_TalepIstipleriIDIstipiID",
                table: "Talep");

            migrationBuilder.DropColumn(
                name: "TalepIstipleriIDIstipiID",
                table: "Talep");
        }
    }
}
