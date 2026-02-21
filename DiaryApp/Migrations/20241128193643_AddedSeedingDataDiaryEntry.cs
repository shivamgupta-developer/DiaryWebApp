using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "id", "Content", "CreatedOn", "Title" },
                values: new object[,]
                {
                    { 1, "Working on .Net Project", new DateTime(2024, 11, 29, 1, 4, 52, 537, DateTimeKind.Unspecified), ".Net Project" },
                    { 2, "Working on Lakshya SAP Project", new DateTime(2024, 11, 29, 1, 4, 52, 537, DateTimeKind.Unspecified), "Kellton SAP Project" },
                    { 3, "Working on Lakshya S4 Project", new DateTime(2024, 11, 29, 1, 4, 52, 537, DateTimeKind.Unspecified), "Kellton S4 Project" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
