using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PFMS.Domain.Models.IncomeSources;

namespace PFMS.Persistence.EntityConfigurations.IncomeSources
{
    public class IncomeSourceConfiguration : IEntityTypeConfiguration<IncomeSource>
    {
        public void Configure(EntityTypeBuilder<IncomeSource> builder)
        {
            builder.ToTable("IncomeSources");

            builder.HasKey(i => i.Id);

            builder
                .HasOne(i => i.User)
                .WithMany(i => i.IncomeSources)
                .HasForeignKey(i => i.UserId);
        }
    }
}
