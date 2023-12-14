using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExecPetTransportBlazorAPI517.Migrations
{
    public partial class initialdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    CatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Breed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.CatId);
                });

            migrationBuilder.CreateTable(
                name: "Dogs",
                columns: table => new
                {
                    DogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Breed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogs", x => x.DogId);
                });

            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    QuoteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.QuoteId);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    OwnerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CellNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instructions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    catId = table.Column<int>(type: "int", nullable: false),
                    dogId = table.Column<int>(type: "int", nullable: false),
                    quoteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.OwnerId);
                    table.ForeignKey(
                        name: "FK_Owners_Cats_catId",
                        column: x => x.catId,
                        principalTable: "Cats",
                        principalColumn: "CatId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Owners_Dogs_dogId",
                        column: x => x.dogId,
                        principalTable: "Dogs",
                        principalColumn: "DogId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Owners_Quotes_quoteId",
                        column: x => x.quoteId,
                        principalTable: "Quotes",
                        principalColumn: "QuoteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    TripId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TravelType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    traveldate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    returndate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    pickupaddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pickupaddress2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pickupcity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pickupstate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pickupzip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    destinationaddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    destinationaddress2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    destinationcity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    destinationstate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    destinationzip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    otherinfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quoteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.TripId);
                    table.ForeignKey(
                        name: "FK_Trips_Quotes_quoteId",
                        column: x => x.quoteId,
                        principalTable: "Quotes",
                        principalColumn: "QuoteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Owners_catId",
                table: "Owners",
                column: "catId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Owners_dogId",
                table: "Owners",
                column: "dogId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Owners_quoteId",
                table: "Owners",
                column: "quoteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trips_quoteId",
                table: "Trips",
                column: "quoteId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropTable(
                name: "Trips");

            migrationBuilder.DropTable(
                name: "Cats");

            migrationBuilder.DropTable(
                name: "Dogs");

            migrationBuilder.DropTable(
                name: "Quotes");
        }
    }
}
