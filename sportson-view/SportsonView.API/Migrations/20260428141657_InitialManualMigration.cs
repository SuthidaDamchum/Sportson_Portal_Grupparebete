using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsonView.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialManualMigration : Migration
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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manuals", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Manuals",
                columns: new[] { "Id", "Description", "Title", "Type", "Url" },
                values: new object[,]
                {
                    { 1, "Steg-för-steg guide till att byta slang på din cykel.", "Hur man lagar en punktering", "youtube", "https://www.youtube.com/watch?v=mROCpl99wgU" },
                    { 2, "Video om hur du ställer in och justerar V-bromsar korrekt.", "Bromsjustering – V-bromsar", "youtube", "https://www.youtube.com/watch?v=I3wcX8t7lZw" },
                    { 3, "Guide till regelbunden kedjesmörjning för längre livslängd.", "Kedjesmörjning och skötsel", "youtube", "https://www.youtube.com/watch?v=X1Vze17bhgk" },
                    { 4, null, "Monteringsmanual – Shimano växlar", "pdf", "https://dinblob.blob.core.windows.net/manuals/shimano.pdf" },
                    { 5, null, "Förmånscykel – handbok för arbetsgivare", "pdf", "https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf" }
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
