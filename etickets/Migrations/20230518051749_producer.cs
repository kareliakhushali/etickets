using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace etickets.Migrations
{
    public partial class producer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 28, 10, 47, 48, 896, DateTimeKind.Local).AddTicks(7628), new DateTime(2023, 5, 8, 10, 47, 48, 895, DateTimeKind.Local).AddTicks(7903) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 21, 10, 47, 48, 896, DateTimeKind.Local).AddTicks(8464), new DateTime(2023, 5, 18, 10, 47, 48, 896, DateTimeKind.Local).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 25, 10, 47, 48, 896, DateTimeKind.Local).AddTicks(8468), new DateTime(2023, 5, 18, 10, 47, 48, 896, DateTimeKind.Local).AddTicks(8467) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 47, 48, 896, DateTimeKind.Local).AddTicks(8471), new DateTime(2023, 5, 8, 10, 47, 48, 896, DateTimeKind.Local).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 47, 48, 896, DateTimeKind.Local).AddTicks(8475), new DateTime(2023, 5, 8, 10, 47, 48, 896, DateTimeKind.Local).AddTicks(8473) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 7, 10, 47, 48, 896, DateTimeKind.Local).AddTicks(8478), new DateTime(2023, 5, 21, 10, 47, 48, 896, DateTimeKind.Local).AddTicks(8477) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "ProfilePictureURL" },
                values: new object[] { "This is the description of first producer", "http://dotnethow.net/images/producers/producer-1.jpeg" });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Bio", "ProfilePictureURL" },
                values: new object[] { "This is the description of second producer", "http://dotnethow.net/images/producers/producer-2.jpeg" });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Bio", "ProfilePictureURL" },
                values: new object[] { "This is the description of third producer", "http://dotnethow.net/images/producers/producer-3.jpeg" });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Bio", "ProfilePictureURL" },
                values: new object[] { "This is the description of fourth producer", "http://dotnethow.net/images/producers/producer-4.jpeg" });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Bio", "ProfilePictureURL" },
                values: new object[] { "This is the description of fourth producer", "http://dotnethow.net/images/producers/producer-5.jpeg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 27, 17, 56, 42, 839, DateTimeKind.Local).AddTicks(8554), new DateTime(2023, 5, 7, 17, 56, 42, 839, DateTimeKind.Local).AddTicks(678) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 20, 17, 56, 42, 839, DateTimeKind.Local).AddTicks(9180), new DateTime(2023, 5, 17, 17, 56, 42, 839, DateTimeKind.Local).AddTicks(9178) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 24, 17, 56, 42, 839, DateTimeKind.Local).AddTicks(9185), new DateTime(2023, 5, 17, 17, 56, 42, 839, DateTimeKind.Local).AddTicks(9184) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 12, 17, 56, 42, 839, DateTimeKind.Local).AddTicks(9187), new DateTime(2023, 5, 7, 17, 56, 42, 839, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 15, 17, 56, 42, 839, DateTimeKind.Local).AddTicks(9189), new DateTime(2023, 5, 7, 17, 56, 42, 839, DateTimeKind.Local).AddTicks(9188) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 6, 17, 56, 42, 839, DateTimeKind.Local).AddTicks(9191), new DateTime(2023, 5, 20, 17, 56, 42, 839, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "ProfilePictureURL" },
                values: new object[] { "http://dotnethow.net/images/producers/producer-1.jpeg", "This is the description of first producer" });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Bio", "ProfilePictureURL" },
                values: new object[] { "http://dotnethow.net/images/producers/producer-2.jpeg", "This is the description of second producer" });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Bio", "ProfilePictureURL" },
                values: new object[] { "http://dotnethow.net/images/producers/producer-3.jpeg", "This is the description of third producer" });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Bio", "ProfilePictureURL" },
                values: new object[] { "http://dotnethow.net/images/producers/producer-4.jpeg", "This is the description of fourth producer" });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Bio", "ProfilePictureURL" },
                values: new object[] { "http://dotnethow.net/images/producers/producer-5.jpeg", "This is the description of fourth producer" });
        }
    }
}
