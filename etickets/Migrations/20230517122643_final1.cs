using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace etickets.Migrations
{
    public partial class final1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
