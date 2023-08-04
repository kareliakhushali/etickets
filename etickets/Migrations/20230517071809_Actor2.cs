using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace etickets.Migrations
{
    public partial class Actor2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "Bio", "FullName", "ProfilePictureURL" },
                values: new object[,]
                {
                    { 1, "http://dotnethow.net/images/actors/actor-1.jpeg", "Actor 1", "This is the description of first actor" },
                    { 2, "http://dotnethow.net/images/actors/actor-2.jpeg", "Actor 2", "This is the description of second actor" },
                    { 3, "http://dotnethow.net/images/actors/actor-3.jpeg", "Actor 3", "This is the description of third actor" },
                    { 4, "http://dotnethow.net/images/actors/actor-4.jpeg", "Actor 4", "This is the description of fourth actor" },
                    { 5, "http://dotnethow.net/images/actors/actor-5.jpeg", "Actor 5", "This is the description of fifth actor" }
                });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "Id", "Description", "Logo", "Name" },
                values: new object[,]
                {
                    { 1, "This is the description of first cinema", "http://dotnethow.net/images/cinemas/cinema-1.jpeg", "Cinema 1" },
                    { 2, "This is the description of second cinema", "http://dotnethow.net/images/cinemas/cinema-2.jpeg", "Cinema 2" },
                    { 3, "This is the description of third cinema", "http://dotnethow.net/images/cinemas/cinema-3.jpeg", "Cinema 3" },
                    { 4, "This is the description of fourth cinema", "http://dotnethow.net/images/cinemas/cinema-4.jpeg", "Cinema 4" },
                    { 5, "This is the description of fifth cinema", "http://dotnethow.net/images/cinemas/cinema-5.jpeg", "Cinema 5" }
                });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "Bio", "FullName", "ProfilePictureURL" },
                values: new object[,]
                {
                    { 1, "http://dotnethow.net/images/producers/producer-1.jpeg", "Producer 1", "This is the description of first producer" },
                    { 2, "http://dotnethow.net/images/producers/producer-2.jpeg", "Producer 2", "This is the description of second producer" },
                    { 3, "http://dotnethow.net/images/producers/producer-3.jpeg", "Producer 3", "This is the description of third producer" },
                    { 4, "http://dotnethow.net/images/producers/producer-4.jpeg", "Producer 4", "This is the description of fourth producer" },
                    { 5, "http://dotnethow.net/images/producers/producer-4.jpeg", "Producer 4", "This is the description of fourth producer" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CinemaId", "Description", "EndDate", "ImageURL", "MovieCategory", "Name", "Price", "ProducerId", "StartDate" },
                values: new object[,]
                {
                    { 2, 1, "This is the Shawshank Redemption description", new DateTime(2023, 5, 20, 12, 48, 9, 326, DateTimeKind.Local).AddTicks(2762), "http://dotnethow.net/images/movies/movie-1.jpeg", 1, "The Shawshank Redemption", 29.5, 1, new DateTime(2023, 5, 17, 12, 48, 9, 326, DateTimeKind.Local).AddTicks(2758) },
                    { 4, 1, "This is the Race movie description", new DateTime(2023, 5, 12, 12, 48, 9, 326, DateTimeKind.Local).AddTicks(2769), "http://dotnethow.net/images/movies/movie-6.jpeg", 4, "Race", 39.5, 2, new DateTime(2023, 5, 7, 12, 48, 9, 326, DateTimeKind.Local).AddTicks(2768) },
                    { 1, 3, "This is the Life movie description", new DateTime(2023, 5, 27, 12, 48, 9, 326, DateTimeKind.Local).AddTicks(2005), "http://dotnethow.net/images/movies/movie-3.jpeg", 4, "Life", 39.5, 3, new DateTime(2023, 5, 7, 12, 48, 9, 325, DateTimeKind.Local).AddTicks(1894) },
                    { 5, 1, "This is the Scoob movie description", new DateTime(2023, 5, 15, 12, 48, 9, 326, DateTimeKind.Local).AddTicks(2772), "http://dotnethow.net/images/movies/movie-7.jpeg", 5, "Scoob", 39.5, 3, new DateTime(2023, 5, 7, 12, 48, 9, 326, DateTimeKind.Local).AddTicks(2771) },
                    { 3, 4, "This is the Ghost movie description", new DateTime(2023, 5, 24, 12, 48, 9, 326, DateTimeKind.Local).AddTicks(2766), "http://dotnethow.net/images/movies/movie-4.jpeg", 6, "Ghost", 39.5, 4, new DateTime(2023, 5, 17, 12, 48, 9, 326, DateTimeKind.Local).AddTicks(2765) },
                    { 6, 1, "This is the Cold Soles movie description", new DateTime(2023, 6, 6, 12, 48, 9, 326, DateTimeKind.Local).AddTicks(2775), "http://dotnethow.net/images/movies/movie-8.jpeg", 3, "Cold Soles", 39.5, 5, new DateTime(2023, 5, 20, 12, 48, 9, 326, DateTimeKind.Local).AddTicks(2774) }
                });

            migrationBuilder.InsertData(
                table: "Actors_Movie",
                columns: new[] { "ActorId", "MovieId", "Actor_MovieActorId", "Actor_MovieMovieId" },
                values: new object[,]
                {
                    { 1, 2, null, null },
                    { 3, 6, null, null },
                    { 5, 3, null, null },
                    { 2, 3, null, null },
                    { 1, 3, null, null },
                    { 5, 5, null, null },
                    { 4, 5, null, null },
                    { 4, 6, null, null },
                    { 3, 5, null, null },
                    { 3, 1, null, null },
                    { 1, 1, null, null },
                    { 4, 4, null, null },
                    { 3, 4, null, null },
                    { 2, 4, null, null },
                    { 4, 2, null, null },
                    { 2, 5, null, null },
                    { 5, 6, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors_Movie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Actors_Movie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Actors_Movie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "Actors_Movie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Actors_Movie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "Actors_Movie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "Actors_Movie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Actors_Movie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "Actors_Movie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "Actors_Movie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "Actors_Movie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "Actors_Movie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "Actors_Movie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "Actors_Movie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "Actors_Movie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "Actors_Movie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "Actors_Movie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
