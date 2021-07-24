using Microsoft.EntityFrameworkCore.Migrations;

namespace Zabita.DataAccessLayer.Migrations
{
    public partial class talepdurumu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TalepDurumu",
                table: "Talep",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TalepDurumu",
                table: "Talep");
        }
    }
}
