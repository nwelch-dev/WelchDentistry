using Microsoft.EntityFrameworkCore.Migrations;

namespace WelchDentistry.Data.Migrations
{
    public partial class TableUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Appointment",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Appointment");
        }
    }
}
