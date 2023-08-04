using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace etickets.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1,
                columns: new[] { "Bio", "ProfilePictureURL" },
                values: new object[] { "This is the Bio of the first actor", "http://dotnethow.net/images/actors/actor-1.jpeg" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2,
                columns: new[] { "Bio", "ProfilePictureURL" },
                values: new object[] { "This is the Bio of the second actor", "http://dotnethow.net/images/actors/actor-2.jpeg" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3,
                columns: new[] { "Bio", "ProfilePictureURL" },
                values: new object[] { "This is the Bio of the third actor", "http://dotnethow.net/images/actors/actor-3.jpeg" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 4,
                columns: new[] { "Bio", "ProfilePictureURL" },
                values: new object[] { "This is the Bio of the fourth actor", "http://dotnethow.net/images/actors/actor-4.jpeg" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 5,
                columns: new[] { "Bio", "ProfilePictureURL" },
                values: new object[] { "This is the Bio of the fifth actor", "http://dotnethow.net/images/actors/actor-5.jpeg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 27, 17, 56, 32, 413, DateTimeKind.Local).AddTicks(6415), new DateTime(2023, 5, 7, 17, 56, 32, 412, DateTimeKind.Local).AddTicks(7553) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 20, 17, 56, 32, 413, DateTimeKind.Local).AddTicks(7070), new DateTime(2023, 5, 17, 17, 56, 32, 413, DateTimeKind.Local).AddTicks(7067) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 24, 17, 56, 32, 413, DateTimeKind.Local).AddTicks(7073), new DateTime(2023, 5, 17, 17, 56, 32, 413, DateTimeKind.Local).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 56, 32, 413, DateTimeKind.Local).AddTicks(7076), new DateTime(2023, 5, 7, 17, 56, 32, 413, DateTimeKind.Local).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 15, 17, 56, 32, 413, DateTimeKind.Local).AddTicks(7078), new DateTime(2023, 5, 7, 17, 56, 32, 413, DateTimeKind.Local).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 6, 17, 56, 32, 413, DateTimeKind.Local).AddTicks(7081), new DateTime(2023, 5, 20, 17, 56, 32, 413, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 5,
                column: "Bio",
                value: "http://dotnethow.net/images/producers/producer-5.jpeg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1,
                columns: new[] { "Bio", "ProfilePictureURL" },
                values: new object[] { "http://dotnethow.net/images/actors/actor-1.jpeg", "This is the description of first actor" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2,
                columns: new[] { "Bio", "ProfilePictureURL" },
                values: new object[] { "http://dotnethow.net/images/actors/actor-2.jpeg", "This is the description of second actor" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3,
                columns: new[] { "Bio", "ProfilePictureURL" },
                values: new object[] { "http://dotnethow.net/images/actors/actor-3.jpeg", "This is the description of third actor" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 4,
                columns: new[] { "Bio", "ProfilePictureURL" },
                values: new object[] { "http://dotnethow.net/images/actors/actor-4.jpeg", "This is the description of fourth actor" });

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 5,
                columns: new[] { "Bio", "ProfilePictureURL" },
                values: new object[] { "http://dotnethow.net/images/actors/actor-5.jpeg", "This is the description of fifth actor" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 27, 12, 48, 9, 326, DateTimeKind.Local).AddTicks(2005), new DateTime(2023, 5, 7, 12, 48, 9, 325, DateTimeKind.Local).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 20, 12, 48, 9, 326, DateTimeKind.Local).AddTicks(2762), new DateTime(2023, 5, 17, 12, 48, 9, 326, DateTimeKind.Local).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 48, 9, 326, DateTimeKind.Local).AddTicks(2766), new DateTime(2023, 5, 17, 12, 48, 9, 326, DateTimeKind.Local).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 12, 12, 48, 9, 326, DateTimeKind.Local).AddTicks(2769), new DateTime(2023, 5, 7, 12, 48, 9, 326, DateTimeKind.Local).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 15, 12, 48, 9, 326, DateTimeKind.Local).AddTicks(2772), new DateTime(2023, 5, 7, 12, 48, 9, 326, DateTimeKind.Local).AddTicks(2771) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 6, 12, 48, 9, 326, DateTimeKind.Local).AddTicks(2775), new DateTime(2023, 5, 20, 12, 48, 9, 326, DateTimeKind.Local).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 5,
                column: "Bio",
                value: "http://dotnethow.net/images/producers/producer-4.jpeg");
        }
    }
}
