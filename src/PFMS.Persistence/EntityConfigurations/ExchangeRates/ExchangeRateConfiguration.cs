using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PFMS.Domain.Models.ExchangeRates;

namespace PFMS.Persistence.EntityConfigurations.ExchangeRates
{
    public class ExchangeRateConfiguration : IEntityTypeConfiguration<ExchangeRate>
    {
        public void Configure(EntityTypeBuilder<ExchangeRate> builder)
        {
            builder.ToTable("ExchangeRates");

            builder.HasKey(i => i.Id);

            builder
                .HasOne(i => i.ToCurrency)
                .WithMany()
                .HasForeignKey(i => i.ToISOCurrencyCode)
                .HasPrincipalKey(i => i.ISOCurrencyCode);

            builder
                .HasOne(i => i.FromCurrency)
                .WithMany()
                .HasForeignKey(i => i.FromISOCurrencyCode)
                .HasPrincipalKey(i => i.ISOCurrencyCode);

            builder
                .HasIndex(i => new
                 {
                     i.FromISOCurrencyCode,
                     i.ToISOCurrencyCode,
                     i.EffectiveDate
                 })
                .IsUnique();
        }
    }
}
