using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(20);
            builder.Property(x => x.ShortName).HasMaxLength(3);
            builder.Property(x => x.CreatedBy).HasMaxLength(15);
            builder.Property(x => x.Created).HasMaxLength(25);
            builder.Property(x => x.UpdatedBy).HasMaxLength(15);
            builder.Property(x => x.Updated).HasMaxLength(25);
        }
    }
}
