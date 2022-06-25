using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class BookRentalConfiguration : IEntityTypeConfiguration<BookRental>
    {
        public void Configure(EntityTypeBuilder<BookRental> builder)
        {
            builder.Property(x => x.RentedFromDate).HasMaxLength(25);
            builder.Property(x => x.RentedToDate).HasMaxLength(25);
            builder.Property(x => x.ReturnedDate).HasMaxLength(25);
            builder.Property(x => x.Status).HasMaxLength(20);
            builder.Property(x => x.Updated).HasMaxLength(25);
            builder.Property(x => x.CreatedBy).HasMaxLength(15);
            builder.Property(x => x.Created).HasMaxLength(25);
            builder.Property(x => x.UpdatedBy).HasMaxLength(15);
            builder.Property(x => x.Updated).HasMaxLength(25);

        }
    }
}
