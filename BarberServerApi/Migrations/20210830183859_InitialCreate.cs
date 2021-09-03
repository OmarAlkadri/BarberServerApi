using Microsoft.EntityFrameworkCore.Migrations;

namespace BarberServerApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReservationTime",
                table: "ReservationBarber",
                newName: "Min");

            migrationBuilder.AddColumn<string>(
                name: "Day",
                table: "ReservationBarber",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hour",
                table: "ReservationBarber",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Day",
                table: "ReservationBarber");

            migrationBuilder.DropColumn(
                name: "Hour",
                table: "ReservationBarber");

            migrationBuilder.RenameColumn(
                name: "Min",
                table: "ReservationBarber",
                newName: "ReservationTime");
        }
    }
}
