using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PFMS.Domain.Models.Currencies;

namespace PFMS.Persistence.EntityConfigurations.Currencies
{
    public class CurrencyConfiguration : IEntityTypeConfiguration<Currency>
    {
        public void Configure(EntityTypeBuilder<Currency> builder)
        {
            builder.ToTable("Currencies");

            builder.HasKey(i => i.Id);

            builder
                .Property(i => i.Name)
                .IsRequired();

            builder
                .Property(i => i.ISOCurrencyCode)
                .IsRequired();

            builder
                .Property(i => i.Symbol)
                .IsRequired();

            builder
                .HasIndex(i => i.ISOCurrencyCode)
                .IsUnique();
        }
    }
}
