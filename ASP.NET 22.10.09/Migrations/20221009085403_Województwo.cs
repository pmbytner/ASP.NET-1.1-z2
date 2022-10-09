using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.NET_22._10._09.Migrations
{
    public partial class Województwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Województwo",
                table: "Miasto",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Województwo",
                table: "Miasto");
        }
    }
}
