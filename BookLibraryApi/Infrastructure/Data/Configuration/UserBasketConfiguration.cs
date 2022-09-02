using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    internal class UserBasketConfiguration : IEntityTypeConfiguration<UserBasket>
    {
        public void Configure(EntityTypeBuilder<UserBasket> builder)
        {
            builder.Property(x => x.TotalRentalPrice).HasPrecision(18, 2);
            builder.Property(x => x.TotalRentalPriceWithVAT).HasPrecision(18, 2);
            builder.Property(x => x.Currency).HasMaxLength(5);
        }
    }
}
