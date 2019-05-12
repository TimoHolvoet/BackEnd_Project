using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EventManager.API.Migrations
{
    public partial class ExpandedModelLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("5ba50ed3-85f0-430e-9738-9d1445976a92"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("1e3370f4-ea98-4e26-a9df-1de5a10da8f0"));

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Locations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Locations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Venue",
                table: "Locations",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "City", "Latitude", "Longitude", "Venue" },
                values: new object[] { new Guid("31086ff7-f452-4028-b8f7-5b9251ef1684"), "EventAddress1", "EventCity1", 50.819476999999999, 3.2577259999999999, "EventLocation1" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Capacity", "Date", "Description", "Genre", "ImageUrl", "LocationId", "Name", "SoldTickets" },
                values: new object[] { new Guid("03b9408d-6d68-443c-9061-35636d9e2ead"), 1000, new DateTime(2019, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), "EventDescription1", "EventGenre1", "Fakelink1.png", new Guid("31086ff7-f452-4028-b8f7-5b9251ef1684"), "EventName1", 400 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("03b9408d-6d68-443c-9061-35636d9e2ead"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("31086ff7-f452-4028-b8f7-5b9251ef1684"));

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "Venue",
                table: "Locations");

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Latitude", "Longitude" },
                values: new object[] { new Guid("1e3370f4-ea98-4e26-a9df-1de5a10da8f0"), 50.819476999999999, 3.2577259999999999 });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Capacity", "Date", "Description", "Genre", "ImageUrl", "LocationId", "Name", "SoldTickets" },
                values: new object[] { new Guid("5ba50ed3-85f0-430e-9738-9d1445976a92"), 1000, new DateTime(2019, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), "EventDescription1", "EventGenre1", "Fakelink1.png", new Guid("1e3370f4-ea98-4e26-a9df-1de5a10da8f0"), "EventName1", 400 });
        }
    }
}
