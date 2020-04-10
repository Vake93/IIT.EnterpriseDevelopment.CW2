using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PFMS.Domain.Models.ExpenseSources;

namespace PFMS.Persistence.EntityConfigurations.ExpenseSources
{
    public class ExpenseSourceConfiguration : IEntityTypeConfiguration<ExpenseSource>
    {
        public void Configure(EntityTypeBuilder<ExpenseSource> builder)
        {
            builder.ToTable("ExpenseSources");

            builder.HasKey(i => i.Id);

            builder
                .HasOne(i => i.User)
                .WithMany(i => i.ExpenseSources)
                .HasForeignKey(i => i.UserId);
        }
    }
}
