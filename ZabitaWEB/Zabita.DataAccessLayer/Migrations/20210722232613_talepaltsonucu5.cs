using Microsoft.EntityFrameworkCore.Migrations;

namespace Zabita.DataAccessLayer.Migrations
{
    public partial class talepaltsonucu5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TalepId",
                table: "TalepAltSonucus",
                newName: "TalepIdString");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TalepIdString",
                table: "TalepAltSonucus",
                newName: "TalepId");
        }
    }
}
