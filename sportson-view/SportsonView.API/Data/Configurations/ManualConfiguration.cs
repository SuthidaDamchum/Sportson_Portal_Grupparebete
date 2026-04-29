using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsonView.API.Data.Entities;

public class ManualConfiguration : IEntityTypeConfiguration<Manual>
{
    public void Configure(EntityTypeBuilder<Manual> builder)
    {
        builder.HasData(


new Manual
{
    Id = 1,
    Title = "Grundläggande kedjeunderhåll",
    Type = "YouTube",
    URL = "https://www.youtube.com/watch?v=example1",
    Description = "Video som visar hur du rengör och smörjer kedjan för längre hållbarhet."
},
new Manual
{
    Id = 2,
    Title = "Användarmanual: CityBike 500",
    Type = "PDF",
    URL = "/downloads/manuals/citybike-500-se.pdf",
    Description = "Fullständig teknisk specifikation och säkerhetsinstruktioner i PDF-format."
},
new Manual
{
    Id = 3,
    Title = "Så här byter du slang på racercykel",
    Type = "YouTube",
    URL = "https://www.youtube.com/watch?v=example2",
    Description = "En snabbguide som visar de bästa knepen för att byta slang vid en punktering."
},
new Manual
{
    Id = 4,
    Title = "Monteringsanvisning: Barnsits Deluxe",
    Type = "PDF",
    URL = "/downloads/manuals/child-seat-mount.pdf",
    Description = "Viktig information om montering och maxvikt för barnsitsen."
},
new Manual
{
    Id = 5,
    Title = "Justering av hydrauliska skivbromsar",
    Type = "YouTube",
    URL = "https://www.youtube.com/watch?v=example3",
    Description = "Genomgång av hur du centrerar bromsoken för att slippa skrapande ljud."
},
new Manual
{
    Id = 6,
    Title = "Vinterförvaring av batterier (E-bike)",
    Type = "PDF",
    URL = "/downloads/manuals/ebike-battery-care.pdf",
    Description = "Guide för hur du bäst sköter ditt elcykelbatteri under kalla månader."
}
        );
    }
}
