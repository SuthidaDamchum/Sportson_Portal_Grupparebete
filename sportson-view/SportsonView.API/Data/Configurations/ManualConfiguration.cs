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
new Manual { Id = 1, Type = "Youtube", Title = "Hur man lagar en punktering", Description = "Steg-for-steg guide till att byta slang på din cykel.", category = "Verkstad", Url = "https://www.youtube.com/watch?v=fg2gLapBFow" },
        new Manual { Id = 2, Type = "Youtube", Title = "Bromsjustering - V-bromsar", Description = "Video om hur du ställer in och justerar V-bromsar korrekt.", category = "Kassa", Url = "https://www.youtube.com/watch?v=fg2gLapBFow" },
        new Manual { Id = 3, Type = "Youtube", Title = "Kedjesmörjning och skötsel", Description = "Guide till regelbunden kedjesmörjning for längre livslängd.", category = "Säljhjälp", Url = "https://www.youtube.com/watch?v=fg2gLapBFow" },
        new Manual { Id = 4, Type = "PDF", Title = "Monteringsmanual - Shimano växlar", Description = "Officiell manual for montering av Shimano 7-växlat nav.", category = "Kassa", Url = "https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf" },
        new Manual { Id = 5, Type = "PDF", Title = "Formanscykel - handbok för arbetsgivare", Description = "Allt du behover veta om att erbjuda formanscyklar.", category = "Frakt", Url = "https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf" },
        new Manual { Id = 6, Type = "Youtube", Title = "Snabbguide: däcktryck och ventiler", Description = "Så väljer du rätt däcktryck for pendling och träning.", category = "Verkstad", Url = "https://www.youtube.com/watch?v=fg2gLapBFow" },
        new Manual { Id = 8, Type = "PDF", Title = "Servicechecklista infor säsong", Description = "Checklistan for genomgång av cyklar inför vår- och sommarsäsong.", category = "Handböcker", Url = "https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf" },
        new Manual { Id = 9, Type = "PDF", Title = "Servicechecklista infor säsong", Description = "Checklistan for genomgång av cyklar infor vår- och sommarsäsong.", category = "Kassa", Url = "https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf" },
        new Manual { Id = 10, Type = "PDF", Title = "Servicechecklista inför säsong", Description = "Checklistan for genomgång av cyklar infor vår- och sommarsäsong.", category = "Frakt", Url = "https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf" },
        new Manual { Id = 11, Type = "PDF", Title = "Servicechecklista infor säsong", Description = "Checklistan för genomgång av cyklar infor vår- och sommarsäsong.", category = "Kommunikation", Url = "https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf" },
        new Manual { Id = 12, Type = "PDF", Title = "Servicechecklista infor säsong", Description = "Checklistan för genomgång av cyklar info vår- och sommarsäsong.", category = "Handböcker", Url = "https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf" },
        new Manual { Id = 13, Type = "PDF", Title = "Servicechecklista infor säsong", Description = "Checklistan för genomgang av cyklar infor vår- och sommarsäsong.", category = "Frakt", Url = "https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf" },
        new Manual { Id = 14, Type = "PDF", Title = "Servicechecklista infor säsong", Description = "Checklistan för genomgång av cyklar info vår- och sommarsäsong.", category = "Handböcker", Url = "https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf" },
        new Manual { Id = 15, Type = "Youtube", Title = "Servsgfddfg", Description = "Checklistan för genomgång av cyklar info vår- och sommarsäsong.", category = "Kassa", Url = "https://www.youtube.com/watch?v=fg2gLapBFow" },
        new Manual { Id = 16, Type = "PDF", Title = "Servidsfggfdadfgr säsong", Description = "Checklistadsgadsfgav cyklar infor vår- och sommarsäsong.", category = "Kassa", Url = "https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf" },
        new Manual { Id = 17, Type = "PDF", Title = "Serviasdggdsa infor säsong", Description = "Checklistan for genomgång av cyklar infor vår- och sommarsäsong.", category = "Kommunikation", Url = "https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf" },
        new Manual { Id = 18, Type = "Youtube", Title = "Servicasdgsdagista infor säsong", Description = "Checklistan for genomgång av cyklar info vår- och sommarsäsong.", category = "Kommunikation", Url = "https://www.youtube.com/watch?v=fg2gLapBFow" },
        new Manual { Id = 19, Type = "Youtube", Title = "Servicasdgsgdng", Description = "Checklistan för genomgång av cyklar info vår- och sommarsäsong.", category = "Handböcker", Url = "https://www.youtube.com/watch?v=fg2gLapBFow" },
        new Manual { Id = 20, Type = "Youtube", Title = "Servaasgdgdsdsgsasong", Description = "Checklistan foasdgsgdsginfor vår- och sommarsäsong.", category = "Kassa", Url = "https://www.youtube.com/watch?v=fg2gLapBFow" }
        );
        }
    }
}