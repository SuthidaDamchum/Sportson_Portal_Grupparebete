using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsonView.API.Migrations
{
    /// <inheritdoc />
    public partial class AddManualsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Manuals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manuals", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Manuals",
                columns: new[] { "Id", "Description", "Title", "Type", "URL" },
                values: new object[,]
                {
                    { 1, "Video som visar hur du rengör och smörjer kedjan för längre hållbarhet.", "Grundläggande kedjeunderhåll", "YouTube", "https://www.youtube.com/watch?v=example1" },
                    { 2, "Fullständig teknisk specifikation och säkerhetsinstruktioner i PDF-format.", "Användarmanual: CityBike 500", "PDF", "/downloads/manuals/citybike-500-se.pdf" },
                    { 3, "En snabbguide som visar de bästa knepen för att byta slang vid en punktering.", "Så här byter du slang på racercykel", "YouTube", "https://www.youtube.com/watch?v=example2" },
                    { 4, "Viktig information om montering och maxvikt för barnsitsen.", "Monteringsanvisning: Barnsits Deluxe", "PDF", "/downloads/manuals/child-seat-mount.pdf" },
                    { 5, "Genomgång av hur du centrerar bromsoken för att slippa skrapande ljud.", "Justering av hydrauliska skivbromsar", "YouTube", "https://www.youtube.com/watch?v=example3" },
                    { 6, "Guide för hur du bäst sköter ditt elcykelbatteri under kalla månader.", "Vinterförvaring av batterier (E-bike)", "PDF", "/downloads/manuals/ebike-battery-care.pdf" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Manuals");
        }
    }
}
