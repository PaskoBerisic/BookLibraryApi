using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(x => x.Date).HasMaxLength(25);
            builder.Property(x => x.TotalRentalPrice).HasPrecision(18, 2);
            builder.Property(x => x.TotalRentalPriceWithVAT).HasPrecision(18, 2);
            builder.Property(x => x.Currency).HasMaxLength(3);

        }
    }
}
