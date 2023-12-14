using Microsoft.EntityFrameworkCore.Migrations;

namespace ExecPetTransportBlazorAPI517.Migrations
{
    public partial class TravelType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TravelType",
                table: "Trips");

            migrationBuilder.AddColumn<int>(
                name: "TravelTypeId",
                table: "Trips",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TravelType",
                columns: table => new
                {
                    TravelTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TripId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelType", x => x.TravelTypeId);
                    table.ForeignKey(
                        name: "FK_TravelType_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "TripId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TravelType_TripId",
                table: "TravelType",
                column: "TripId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TravelType");

            migrationBuilder.DropColumn(
                name: "TravelTypeId",
                table: "Trips");

            migrationBuilder.AddColumn<string>(
                name: "TravelType",
                table: "Trips",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
