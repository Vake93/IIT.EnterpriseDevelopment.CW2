using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PFMS.Domain.Models.Expenses;

namespace PFMS.Persistence.EntityConfigurations.Expenses
{
    public class ExpenseConfiguration : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.ToTable("Expenses");

            builder.HasKey(i => i.Id);

            builder
                .HasOne(i => i.Currency)
                .WithMany()
                .HasForeignKey(i => i.ISOCurrencyCode)
                .HasPrincipalKey(i => i.ISOCurrencyCode);

            builder
                .HasOne(i => i.ExpenseSource)
                .WithMany(i => i.Expenses)
                .HasForeignKey(i => i.ExpenseSourceId);
        }
    }
}
