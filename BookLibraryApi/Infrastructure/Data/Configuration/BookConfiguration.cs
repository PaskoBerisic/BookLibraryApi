using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(x => x.Title).HasMaxLength(255);
            builder.Property(x => x.Description).HasMaxLength(2000);
            builder.Property(x => x.RentalPrice).HasPrecision(18,2);
            builder.Property(x => x.ListPrice).HasPrecision(18, 2);
            builder.Property(x => x.CreatedBy).HasMaxLength(15);
            builder.Property(x => x.Created).HasMaxLength(25);
            builder.Property(x => x.UpdatedBy).HasMaxLength(15);
            builder.Property(x => x.Updated).HasMaxLength(25);
        }
    }
}
