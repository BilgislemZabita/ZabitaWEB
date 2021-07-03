using Microsoft.EntityFrameworkCore.Migrations;

namespace Zabita.DataAccessLayer.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "TalepIstipleriID",
                table: "Talep",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TalepIstipleriID",
                table: "Talep");

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
    }
}
