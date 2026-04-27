using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsonView.API.Migrations
{
    /// <inheritdoc />
    public partial class UserDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://sportsonnews.blob.core.windows.net/sportsonnews/It1.png");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://sportsonnews.blob.core.windows.net/sportsonnews/Inkop2.webp");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://sportsonnews.blob.core.windows.net/sportsonnews/Marknad3.png");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://sportsonnews.blob.core.windows.net/sportsonnews/Verkstad4.png");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://sportsonnews.blob.core.windows.net/sportsonnews/Kampanj5.png");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://sportsonnews.blob.core.windows.net/sportsonnews/Ekonomi6.jpeg");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://sportsonnews.blob.core.windows.net/sportsonnews/Ekonomi7.png");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://sportsonnews.blob.core.windows.net/sportsonnews/Minbutik8.jpg");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://sportsonnews.blob.core.windows.net/sportsonnews/Minbutik9.jpg");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://sportsonnews.blob.core.windows.net/sportsonnews/Campaign10.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://sportsonsbilder.blob.core.windows.net/news-images/IT.png");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://sportsonsbilder.blob.core.windows.net/news-images/Inköp.webp");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://sportsonsbilder.blob.core.windows.net/news-images/Marknad.png");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://sportsonsbilder.blob.core.windows.net/news-images/Verkstad.png");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://sportsonsbilder.blob.core.windows.net/news-images/Campaign.png");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://sportsonsbilder.blob.core.windows.net/news-images/Ekonomi6.jpeg");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://sportsonsbilder.blob.core.windows.net/news-images/Ekonomi7.png");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://sportsonsbilder.blob.core.windows.net/news-images/Minbutik8.jpg");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://sportsonsbilder.blob.core.windows.net/news-images/Minbutik9.jpg");

            migrationBuilder.UpdateData(
                table: "NewsArticles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://sportsonsbilder.blob.core.windows.net/news-images/Campaign10.png");
        }
    }
}
