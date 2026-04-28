using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsonView.API.Data.Entities;

namespace SportsonView.API.Data.Configurations
{
    public class ManualConfiguration : IEntityTypeConfiguration<Manual>
    {
        public void Configure(EntityTypeBuilder<Manual> builder)
        {
            builder.HasData(

            new Manual
            {
                Id = 1,
                Title = "Hur man lagar en punktering",
                Description = "Steg-för-steg guide till att byta slang på din cykel.",
                Type = "youtube",
                Url = "https://www.youtube.com/watch?v=mROCpl99wgU"
            },
            new Manual
            {
                Id = 2,
                Title = "Bromsjustering – V-bromsar",
                Description = "Video om hur du ställer in och justerar V-bromsar korrekt.",
                Type = "youtube",
                Url = "https://www.youtube.com/watch?v=I3wcX8t7lZw"
            },
            new Manual
            {
                Id = 3,
                Title = "Kedjesmörjning och skötsel",
                Description = "Guide till regelbunden kedjesmörjning för längre livslängd.",
                Type = "youtube",
                Url = "https://www.youtube.com/watch?v=X1Vze17bhgk"
            },
            new Manual
            {
                Id = 4,
                Title = "Monteringsmanual – Shimano växlar",
                Description = null,
                Type = "pdf",
                Url = "https://dinblob.blob.core.windows.net/manuals/shimano.pdf"
            },
            new Manual
            {
                Id = 5,
                Title = "Förmånscykel – handbok för arbetsgivare",
                Description = null,
                Type = "pdf",
                Url = "https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf"

            }
            );

        }
    }
}