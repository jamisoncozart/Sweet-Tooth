using Microsoft.EntityFrameworkCore.Migrations;

namespace SweetTooth.Migrations
{
    public partial class UpdateDBName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserStats",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserStats",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
