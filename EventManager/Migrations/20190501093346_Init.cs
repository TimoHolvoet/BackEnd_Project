using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EventManager.API.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    Latitude = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 300, nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Genre = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Capacity = table.Column<int>(nullable: false),
                    SoldTickets = table.Column<int>(nullable: false),
                    LocationId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Latitude", "Longitude" },
                values: new object[] { new Guid("9b6069c4-bc37-4354-9e59-d9dd01641709"), 50.819476999999999, 3.2577259999999999 });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Capacity", "Date", "Description", "Genre", "ImageUrl", "LocationId", "Name", "SoldTickets" },
                values: new object[] { new Guid("2dd18d55-6beb-4c48-bbd8-d671a29fdbbd"), 1000, new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), "EventDescription1", "EventGenre1", "Fakelink1.png", new Guid("9b6069c4-bc37-4354-9e59-d9dd01641709"), "EventName1", 400 });

            migrationBuilder.CreateIndex(
                name: "IX_Events_LocationId",
                table: "Events",
                column: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
