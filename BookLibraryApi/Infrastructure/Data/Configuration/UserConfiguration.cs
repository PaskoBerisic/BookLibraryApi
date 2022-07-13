using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.FirstName).HasMaxLength(50);
            builder.Property(x => x.LastName).HasMaxLength(50);
            builder.Property(x => x.Username).HasMaxLength(20);
            builder.Property(x => x.Password).HasMaxLength(20);
            builder.Property(x => x.DateOfBirth).HasMaxLength(25);
            builder.Property(x => x.Address).HasMaxLength(60);
            builder.Property(x => x.CreatedBy).HasMaxLength(15);
            builder.Property(x => x.Created).HasMaxLength(25);
            builder.Property(x => x.UpdatedBy).HasMaxLength(15);
            builder.Property(x => x.Updated).HasMaxLength(25);
        }
    }
}
