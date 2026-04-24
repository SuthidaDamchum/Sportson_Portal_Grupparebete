using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsonView.API.Migrations
{
    /// <inheritdoc />
    public partial class NewsDBUpdateDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedDate",
                value: new DateOnly(2026, 4, 24));

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishedDate",
                value: new DateOnly(2026, 4, 24));

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishedDate",
                value: new DateOnly(2026, 4, 24));

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishedDate",
                value: new DateOnly(2026, 4, 24));

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishedDate",
                value: new DateOnly(2026, 4, 24));

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishedDate",
                value: new DateOnly(2026, 4, 24));

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublishedDate",
                value: new DateOnly(2026, 4, 24));

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 8,
                column: "PublishedDate",
                value: new DateOnly(2026, 4, 24));

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 9,
                column: "PublishedDate",
                value: new DateOnly(2026, 4, 24));

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 10,
                column: "PublishedDate",
                value: new DateOnly(2026, 4, 24));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedDate",
                value: new DateOnly(2026, 4, 1));

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishedDate",
                value: new DateOnly(2026, 4, 2));

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishedDate",
                value: new DateOnly(2026, 4, 3));

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishedDate",
                value: new DateOnly(2026, 4, 4));

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishedDate",
                value: new DateOnly(2026, 4, 12));

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishedDate",
                value: new DateOnly(2026, 4, 5));

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublishedDate",
                value: new DateOnly(2026, 4, 8));

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 8,
                column: "PublishedDate",
                value: new DateOnly(2026, 4, 9));

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 9,
                column: "PublishedDate",
                value: new DateOnly(2026, 4, 10));

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 10,
                column: "PublishedDate",
                value: new DateOnly(2026, 4, 11));
        }
    }
}
