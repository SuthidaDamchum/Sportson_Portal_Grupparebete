using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsonView.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedTwentyManuals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "category",
                table: "Manuals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Manuals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Type", "Url", "category" },
                values: new object[] { "Steg-for-steg guide till att byta slang på din cykel.", "Youtube", "https://www.youtube.com/watch?v=fg2gLapBFow", "Verkstad" });

            migrationBuilder.UpdateData(
                table: "Manuals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Title", "Type", "Url", "category" },
                values: new object[] { "Bromsjustering - V-bromsar", "Youtube", "https://www.youtube.com/watch?v=fg2gLapBFow", "Kassa" });

            migrationBuilder.UpdateData(
                table: "Manuals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Type", "Url", "category" },
                values: new object[] { "Guide till regelbunden kedjesmörjning for längre livslängd.", "Youtube", "https://www.youtube.com/watch?v=fg2gLapBFow", "Säljhjälp" });

            migrationBuilder.UpdateData(
                table: "Manuals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Title", "Type", "Url", "category" },
                values: new object[] { "Officiell manual for montering av Shimano 7-växlat nav.", "Monteringsmanual - Shimano växlar", "PDF", "https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf", "Kassa" });

            migrationBuilder.UpdateData(
                table: "Manuals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Title", "Type", "category" },
                values: new object[] { "Allt du behover veta om att erbjuda formanscyklar.", "Formanscykel - handbok för arbetsgivare", "PDF", "Frakt" });

            migrationBuilder.InsertData(
                table: "Manuals",
                columns: new[] { "Id", "Description", "Title", "Type", "Url", "category" },
                values: new object[,]
                {
                    { 6, "Så väljer du rätt däcktryck for pendling och träning.", "Snabbguide: däcktryck och ventiler", "Youtube", "https://www.youtube.com/watch?v=fg2gLapBFow", "Verkstad" },
                    { 8, "Checklistan for genomgång av cyklar inför vår- och sommarsäsong.", "Servicechecklista infor säsong", "PDF", "https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf", "Handböcker" },
                    { 9, "Checklistan for genomgång av cyklar infor vår- och sommarsäsong.", "Servicechecklista infor säsong", "PDF", "https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf", "Kassa" },
                    { 10, "Checklistan for genomgång av cyklar infor vår- och sommarsäsong.", "Servicechecklista inför säsong", "PDF", "https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf", "Frakt" },
                    { 11, "Checklistan för genomgång av cyklar infor vår- och sommarsäsong.", "Servicechecklista infor säsong", "PDF", "https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf", "Kommunikation" },
                    { 12, "Checklistan för genomgång av cyklar info vår- och sommarsäsong.", "Servicechecklista infor säsong", "PDF", "https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf", "Handböcker" },
                    { 13, "Checklistan för genomgang av cyklar infor vår- och sommarsäsong.", "Servicechecklista infor säsong", "PDF", "https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf", "Frakt" },
                    { 14, "Checklistan för genomgång av cyklar info vår- och sommarsäsong.", "Servicechecklista infor säsong", "PDF", "https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf", "Handböcker" },
                    { 15, "Checklistan för genomgång av cyklar info vår- och sommarsäsong.", "Servsgfddfg", "Youtube", "https://www.youtube.com/watch?v=fg2gLapBFow", "Kassa" },
                    { 16, "Checklistadsgadsfgav cyklar infor vår- och sommarsäsong.", "Servidsfggfdadfgr säsong", "PDF", "https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf", "Kassa" },
                    { 17, "Checklistan for genomgång av cyklar infor vår- och sommarsäsong.", "Serviasdggdsa infor säsong", "PDF", "https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf", "Kommunikation" },
                    { 18, "Checklistan for genomgång av cyklar info vår- och sommarsäsong.", "Servicasdgsdagista infor säsong", "Youtube", "https://www.youtube.com/watch?v=fg2gLapBFow", "Kommunikation" },
                    { 19, "Checklistan för genomgång av cyklar info vår- och sommarsäsong.", "Servicasdgsgdng", "Youtube", "https://www.youtube.com/watch?v=fg2gLapBFow", "Handböcker" },
                    { 20, "Checklistan foasdgsgdsginfor vår- och sommarsäsong.", "Servaasgdgdsdsgsasong", "Youtube", "https://www.youtube.com/watch?v=fg2gLapBFow", "Kassa" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Manuals",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Manuals",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Manuals",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Manuals",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Manuals",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Manuals",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Manuals",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Manuals",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Manuals",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Manuals",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Manuals",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Manuals",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Manuals",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Manuals",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DropColumn(
                name: "category",
                table: "Manuals");

            migrationBuilder.UpdateData(
                table: "Manuals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Type", "Url" },
                values: new object[] { "Steg-för-steg guide till att byta slang på din cykel.", "youtube", "https://www.youtube.com/watch?v=mROCpl99wgU" });

            migrationBuilder.UpdateData(
                table: "Manuals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Title", "Type", "Url" },
                values: new object[] { "Bromsjustering – V-bromsar", "youtube", "https://www.youtube.com/watch?v=I3wcX8t7lZw" });

            migrationBuilder.UpdateData(
                table: "Manuals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Type", "Url" },
                values: new object[] { "Guide till regelbunden kedjesmörjning för längre livslängd.", "youtube", "https://www.youtube.com/watch?v=X1Vze17bhgk" });

            migrationBuilder.UpdateData(
                table: "Manuals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Title", "Type", "Url" },
                values: new object[] { null, "Monteringsmanual – Shimano växlar", "pdf", "https://dinblob.blob.core.windows.net/manuals/shimano.pdf" });

            migrationBuilder.UpdateData(
                table: "Manuals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Title", "Type" },
                values: new object[] { null, "Förmånscykel – handbok för arbetsgivare", "pdf" });
        }
    }
}
