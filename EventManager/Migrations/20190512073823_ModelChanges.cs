using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EventManager.API.Migrations
{
    public partial class ModelChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("03b9408d-6d68-443c-9061-35636d9e2ead"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("31086ff7-f452-4028-b8f7-5b9251ef1684"));

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Events",
                newName: "StartDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "City", "Latitude", "Longitude", "Venue" },
                values: new object[] { new Guid("c7647299-eed8-4667-94c8-fc3c9d5f7f62"), "EventAddress1", "EventCity1", 50.819476999999999, 3.2577259999999999, "EventLocation1" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Capacity", "Description", "EndDate", "Genre", "ImageUrl", "LocationId", "Name", "SoldTickets", "StartDate" },
                values: new object[] { new Guid("e921bd21-959d-46b4-8857-fb269a395d26"), 1000, "EventDescription1", new DateTime(2019, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), "EventGenre1", "Fakelink1.png", new Guid("c7647299-eed8-4667-94c8-fc3c9d5f7f62"), "EventName1", 400, new DateTime(2019, 5, 12, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("e921bd21-959d-46b4-8857-fb269a395d26"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("c7647299-eed8-4667-94c8-fc3c9d5f7f62"));

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Events",
                newName: "Date");

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "City", "Latitude", "Longitude", "Venue" },
                values: new object[] { new Guid("31086ff7-f452-4028-b8f7-5b9251ef1684"), "EventAddress1", "EventCity1", 50.819476999999999, 3.2577259999999999, "EventLocation1" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Capacity", "Date", "Description", "Genre", "ImageUrl", "LocationId", "Name", "SoldTickets" },
                values: new object[] { new Guid("03b9408d-6d68-443c-9061-35636d9e2ead"), 1000, new DateTime(2019, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), "EventDescription1", "EventGenre1", "Fakelink1.png", new Guid("31086ff7-f452-4028-b8f7-5b9251ef1684"), "EventName1", 400 });
        }
    }
}
