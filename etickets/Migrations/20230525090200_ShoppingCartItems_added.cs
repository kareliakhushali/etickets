using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace etickets.Migrations
{
    public partial class ShoppingCartItems_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 4, 14, 32, 0, 371, DateTimeKind.Local).AddTicks(3712), new DateTime(2023, 5, 15, 14, 32, 0, 370, DateTimeKind.Local).AddTicks(3579) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 28, 14, 32, 0, 371, DateTimeKind.Local).AddTicks(4488), new DateTime(2023, 5, 25, 14, 32, 0, 371, DateTimeKind.Local).AddTicks(4484) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 1, 14, 32, 0, 371, DateTimeKind.Local).AddTicks(4492), new DateTime(2023, 5, 25, 14, 32, 0, 371, DateTimeKind.Local).AddTicks(4491) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 20, 14, 32, 0, 371, DateTimeKind.Local).AddTicks(4496), new DateTime(2023, 5, 15, 14, 32, 0, 371, DateTimeKind.Local).AddTicks(4495) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 23, 14, 32, 0, 371, DateTimeKind.Local).AddTicks(4499), new DateTime(2023, 5, 15, 14, 32, 0, 371, DateTimeKind.Local).AddTicks(4498) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 14, 14, 32, 0, 371, DateTimeKind.Local).AddTicks(4502), new DateTime(2023, 5, 28, 14, 32, 0, 371, DateTimeKind.Local).AddTicks(4501) });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_MovieId",
                table: "ShoppingCartItems",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 4, 14, 20, 2, 113, DateTimeKind.Local).AddTicks(8890), new DateTime(2023, 5, 15, 14, 20, 2, 112, DateTimeKind.Local).AddTicks(9675) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 28, 14, 20, 2, 113, DateTimeKind.Local).AddTicks(9592), new DateTime(2023, 5, 25, 14, 20, 2, 113, DateTimeKind.Local).AddTicks(9589) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 1, 14, 20, 2, 113, DateTimeKind.Local).AddTicks(9595), new DateTime(2023, 5, 25, 14, 20, 2, 113, DateTimeKind.Local).AddTicks(9594) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 20, 14, 20, 2, 113, DateTimeKind.Local).AddTicks(9599), new DateTime(2023, 5, 15, 14, 20, 2, 113, DateTimeKind.Local).AddTicks(9597) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 23, 14, 20, 2, 113, DateTimeKind.Local).AddTicks(9601), new DateTime(2023, 5, 15, 14, 20, 2, 113, DateTimeKind.Local).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 14, 14, 20, 2, 113, DateTimeKind.Local).AddTicks(9604), new DateTime(2023, 5, 28, 14, 20, 2, 113, DateTimeKind.Local).AddTicks(9603) });
        }
    }
}
