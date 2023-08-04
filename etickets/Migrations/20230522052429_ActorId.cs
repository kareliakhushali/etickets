using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace etickets.Migrations
{
    public partial class ActorId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ActorId",
                table: "Actors",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePictureURL",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Actors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 1, 10, 54, 29, 405, DateTimeKind.Local).AddTicks(6517), new DateTime(2023, 5, 12, 10, 54, 29, 404, DateTimeKind.Local).AddTicks(7826) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 25, 10, 54, 29, 405, DateTimeKind.Local).AddTicks(7179), new DateTime(2023, 5, 22, 10, 54, 29, 405, DateTimeKind.Local).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 29, 10, 54, 29, 405, DateTimeKind.Local).AddTicks(7183), new DateTime(2023, 5, 22, 10, 54, 29, 405, DateTimeKind.Local).AddTicks(7182) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 17, 10, 54, 29, 405, DateTimeKind.Local).AddTicks(7185), new DateTime(2023, 5, 12, 10, 54, 29, 405, DateTimeKind.Local).AddTicks(7184) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 20, 10, 54, 29, 405, DateTimeKind.Local).AddTicks(7187), new DateTime(2023, 5, 12, 10, 54, 29, 405, DateTimeKind.Local).AddTicks(7186) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 11, 10, 54, 29, 405, DateTimeKind.Local).AddTicks(7190), new DateTime(2023, 5, 25, 10, 54, 29, 405, DateTimeKind.Local).AddTicks(7189) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Actors",
                newName: "ActorId");

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePictureURL",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
        }
    }
}
