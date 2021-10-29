using Microsoft.EntityFrameworkCore.Migrations;

namespace Refactor_Project_Series.Migrations
{
    public partial class AttGenero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "GeneroId",
                table: "Series",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "GeneroId",
                table: "Series",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
