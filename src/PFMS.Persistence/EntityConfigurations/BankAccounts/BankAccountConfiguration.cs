using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PFMS.Domain.Models.BankAccounts;
using System;

namespace PFMS.Persistence.EntityConfigurations.BankAccounts
{
    public class BankAccountConfiguration : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            builder.ToTable("BankAccounts");

            builder.HasKey(i => i.Id);

            builder
                .Property(i => i.BankAccountType)
                .HasConversion(
                    i => Enum.GetName(typeof(BankAccountType), i),
                    i => (BankAccountType)Enum.Parse(typeof(BankAccountType), i));

            builder
                .HasOne(i => i.Currency)
                .WithMany()
                .HasForeignKey(i => i.ISOCurrencyCode)
                .HasPrincipalKey(i => i.ISOCurrencyCode);

            builder
                .HasOne(i => i.User)
                .WithMany(i => i.BankAccounts)
                .HasForeignKey(i => i.UserId);
        }
    }
}
