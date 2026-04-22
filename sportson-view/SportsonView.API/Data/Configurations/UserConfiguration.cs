using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsonView.API.Data.Entities;

namespace SportsonView.API.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Ingen HasData här längre för Users.
            // User-seed körs i Program.cs i stället.
        }
    }
}