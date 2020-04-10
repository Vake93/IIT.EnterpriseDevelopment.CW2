using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IncomeModel = PFMS.Domain.Models.Income.Income;

namespace PFMS.Persistence.EntityConfigurations.Income
{
    public class IncomeConfiguration : IEntityTypeConfiguration<IncomeModel>
    {
        public void Configure(EntityTypeBuilder<IncomeModel> builder)
        {
            builder.ToTable("IncomeModel");

            builder.HasKey(i => i.Id);

            builder
                .HasOne(i => i.Currency)
                .WithMany()
                .HasForeignKey(i => i.ISOCurrencyCode)
                .HasPrincipalKey(i => i.ISOCurrencyCode);

            builder
                .HasOne(i => i.IncomeSource)
                .WithMany(i => i.Income)
                .HasForeignKey(i => i.IncomeSourceId);
        }
    }
}
