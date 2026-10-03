using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace big_isaac_project.Migrations
{
    /// <inheritdoc />
    public partial class SeedCharacters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Damage", "Health", "Name", "Speed" },
                values: new object[,]
                {
                    { 1, 2.0, 3.0, "Isaac", 2.0 },
                    { 2, 2.0, 4.0, "Magdalene", 1.0 },
                    { 3, 3.0, 2.0, "Cain", 3.0 },
                    { 4, 4.0, 1.0, "Judas", 2.0 },
                    { 5, 2.0, -1.0, "???", 2.0 },
                    { 6, 1.0, 2.0, "Eve", 3.0 },
                    { 7, 2.0, 3.0, "Samson", 2.0 },
                    { 8, 4.0, -1.0, "Azazel", 3.0 },
                    { 9, 2.0, 3.0, "Lazarus", 2.0 },
                    { 10, 0.0, 0.0, "Eden", 0.0 },
                    { 11, 2.0, 0.0, "The Lost", 2.0 },
                    { 12, 2.0, 1.0, "Lilith", 2.0 },
                    { 13, 2.0, 2.0, "Apollyon", 2.0 },
                    { 14, 4.0, -1.0, "The Forgotten", 2.0 },
                    { 15, 2.0, 3.0, "Bethany", 2.0 },
                    { 16, 3.0, 3.0, "Jacob & Esau", 2.0 },
                    { 17, 2.0, 3.0, "Tainted Isaac", 2.0 },
                    { 18, 1.0, 4.0, "Tainted Magdalene", 2.0 },
                    { 19, 2.0, 2.0, "Tainted Cain", 3.0 },
                    { 20, 2.0, -1.0, "Tainted Judas", 3.0 },
                    { 21, 1.0, -1.0, "Tainted ???", 1.0 },
                    { 22, 1.0, 2.0, "Tainted Eve", 3.0 },
                    { 23, 1.0, 3.0, "Tainted Samson", 2.0 },
                    { 24, 4.0, -1.0, "Tainted Azazel", 2.0 },
                    { 25, 2.0, 3.0, "Tainted Lazarus", 2.0 },
                    { 26, 0.0, 0.0, "Tainted Eden", 0.0 },
                    { 27, 3.0, 0.0, "Tainted Lost", 2.0 },
                    { 28, 2.0, 1.0, "Tainted Lilith", 2.0 },
                    { 29, 1.0, 2.0, "Tainted Apollyon", 2.0 },
                    { 30, 4.0, -1.0, "Tainted The Forgotten", -1.0 },
                    { 31, 2.0, -1.0, "Tainted Bethany", 2.0 },
                    { 32, 3.0, 3.0, "Tainted Jacob", 2.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 32);
        }
    }
}
