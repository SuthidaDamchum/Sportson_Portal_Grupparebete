using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsonView.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedImportantDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ImportantDates",
                columns: new[] { "Id", "EndDate", "IsReminderActive", "StartDate", "TimeLabel", "Title" },
                values: new object[,]
                {
                    { 1, null, true, new DateTime(2026, 5, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), "08.00 - 09.00", "Frukostmöte: Nytt förmånspaket" },
                    { 2, null, false, new DateTime(2026, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hela dagen", "Kampanjstart: Sommarcyklar 2026" },
                    { 3, null, true, new DateTime(2026, 5, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), "13.00 - 15.00", "Personalmöte - Volvo tjänstebilar" },
                    { 4, new DateTime(2026, 5, 29, 17, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2026, 5, 26, 9, 0, 0, 0, DateTimeKind.Unspecified), "09.00 - 17.00", "Utbildning: Service av elmotorer" },
                    { 5, null, true, new DateTime(2026, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Senast kl 16.00", "Deadline: Beställning Volvo-kläder" },
                    { 6, null, false, new DateTime(2026, 6, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "17.00 - Sent", "Sommarfest med teamet" },
                    { 7, null, true, new DateTime(2026, 6, 25, 7, 0, 0, 0, DateTimeKind.Unspecified), "07.00 - 12.00", "Inventering av butikslager" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ImportantDates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ImportantDates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ImportantDates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ImportantDates",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ImportantDates",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ImportantDates",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ImportantDates",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
