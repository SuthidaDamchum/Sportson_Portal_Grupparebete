using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsonView.API.Data.Entities;

namespace SportsonView.API.Data.Configurations
{
    public class ImportantDateConfiguration : IEntityTypeConfiguration<ImportantDate>
    {
        public void Configure(EntityTypeBuilder<ImportantDate> builder)
        {
            builder.HasData(
                new ImportantDate
                {
                    Id = 1,
                    Title = "Frukostmöte: Nytt förmånspaket",
                    StartDate = new DateTime(2026, 05, 04, 08, 00, 00),
                    TimeLabel = "08.00 - 09.00",
                    IsReminderActive = true
                },
                new ImportantDate
                {
                    Id = 2,
                    Title = "Kampanjstart: Sommarcyklar 2026",
                    StartDate = new DateTime(2026, 05, 11, 00, 00, 00),
                    TimeLabel = "Hela dagen",
                    IsReminderActive = false
                },
                new ImportantDate
                {
                    Id = 3,
                    Title = "Personalmöte - Volvo tjänstebilar",
                    StartDate = new DateTime(2026, 05, 15, 13, 00, 00),
                    TimeLabel = "13.00 - 15.00",
                    IsReminderActive = true
                },
                new ImportantDate
                {
                    Id = 4,
                    Title = "Utbildning: Service av elmotorer",
                    StartDate = new DateTime(2026, 05, 26, 09, 00, 00),
                    EndDate = new DateTime(2026, 05, 29, 17, 00, 00), 
                    TimeLabel = "09.00 - 17.00",
                    IsReminderActive = true
                },
                new ImportantDate
                {
                    Id = 5,
                    Title = "Deadline: Beställning Volvo-kläder",
                    StartDate = new DateTime(2026, 06, 02, 00, 00, 00),
                    TimeLabel = "Senast kl 16.00",
                    IsReminderActive = true
                },
                new ImportantDate
                {
                    Id = 6,
                    Title = "Sommarfest med teamet",
                    StartDate = new DateTime(2026, 06, 19, 17, 00, 00),
                    TimeLabel = "17.00 - Sent",
                    IsReminderActive = false
                },
                new ImportantDate
                {
                    Id = 7,
                    Title = "Inventering av butikslager",
                    StartDate = new DateTime(2026, 06, 25, 07, 00, 00),
                    TimeLabel = "07.00 - 12.00",
                    IsReminderActive = true
                }
                            );
                        }
                    }
                }
