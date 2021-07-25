using Microsoft.EntityFrameworkCore.Migrations;

namespace Zabita.DataAccessLayer.Migrations
{
    public partial class talepaltsonucu7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TalepIsTipi",
                table: "TalepAltSonucu",
                newName: "TalepIsTipiAmirlik");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TalepIsTipiAmirlik",
                table: "TalepAltSonucu",
                newName: "TalepIsTipi");
        }
    }
}
