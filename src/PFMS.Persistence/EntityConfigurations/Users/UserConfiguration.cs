using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PFMS.Domain.Models.Users;

namespace PFMS.Persistence.EntityConfigurations.Users
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(i => i.Id);

            builder
                .HasOne(i => i.DefaultCurrency)
                .WithMany()
                .HasForeignKey(i => i.DefaultISOCurrencyCode)
                .HasPrincipalKey(i => i.ISOCurrencyCode);
        }
    }
}
