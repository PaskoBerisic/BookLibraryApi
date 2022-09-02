using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.Property(x => x.FirstName).HasMaxLength(50);
            builder.Property(x => x.LastName).HasMaxLength(50);
            builder.Property(x => x.Bibliography).HasMaxLength(5000);
            builder.Property(x => x.CreatedBy).HasMaxLength(15);
            builder.Property(x => x.Created).HasMaxLength(25);
            builder.Property(x => x.UpdatedBy).HasMaxLength(15);
            builder.Property(x => x.Updated).HasMaxLength(25);
        }
    }
}
