﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PFMS.Persistence;

namespace PFMS.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200413063629_Initital")]
    partial class Initital
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PFMS.Domain.Models.BankAccounts.BankAccount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("BankAccountType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("ISOCurrencyCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("InterestRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ISOCurrencyCode");

                    b.HasIndex("UserId");

                    b.ToTable("BankAccounts");
                });

            modelBuilder.Entity("PFMS.Domain.Models.Currencies.Currency", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("ISOCurrencyCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("PFMS.Domain.Models.ExchangeRates.ExchangeRate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EffectiveDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FromISOCurrencyCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ToISOCurrencyCode")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ToISOCurrencyCode");

                    b.HasIndex("FromISOCurrencyCode", "ToISOCurrencyCode", "EffectiveDate")
                        .IsUnique()
                        .HasFilter("[FromISOCurrencyCode] IS NOT NULL AND [ToISOCurrencyCode] IS NOT NULL");

                    b.ToTable("ExchangeRates");
                });

            modelBuilder.Entity("PFMS.Domain.Models.ExpenseSources.ExpenseSource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ExpenseSources");
                });

            modelBuilder.Entity("PFMS.Domain.Models.Expenses.Expense", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("ExpenseSourceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ISOCurrencyCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ExpenseSourceId");

                    b.HasIndex("ISOCurrencyCode");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("PFMS.Domain.Models.Income.Income", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("ISOCurrencyCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("IncomeSourceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ISOCurrencyCode");

                    b.HasIndex("IncomeSourceId");

                    b.ToTable("Income");
                });

            modelBuilder.Entity("PFMS.Domain.Models.IncomeSources.IncomeSource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("IncomeSources");
                });

            modelBuilder.Entity("PFMS.Domain.Models.Users.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("DefaultISOCurrencyCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("DefaultISOCurrencyCode");

                    b.HasIndex("UserName")
                        .IsUnique()
                        .HasFilter("[UserName] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PFMS.Domain.Models.BankAccounts.BankAccount", b =>
                {
                    b.HasOne("PFMS.Domain.Models.Currencies.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("ISOCurrencyCode")
                        .HasPrincipalKey("ISOCurrencyCode");

                    b.HasOne("PFMS.Domain.Models.Users.User", "User")
                        .WithMany("BankAccounts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PFMS.Domain.Models.ExchangeRates.ExchangeRate", b =>
                {
                    b.HasOne("PFMS.Domain.Models.Currencies.Currency", "FromCurrency")
                        .WithMany()
                        .HasForeignKey("FromISOCurrencyCode")
                        .HasPrincipalKey("ISOCurrencyCode");

                    b.HasOne("PFMS.Domain.Models.Currencies.Currency", "ToCurrency")
                        .WithMany()
                        .HasForeignKey("ToISOCurrencyCode")
                        .HasPrincipalKey("ISOCurrencyCode");
                });

            modelBuilder.Entity("PFMS.Domain.Models.ExpenseSources.ExpenseSource", b =>
                {
                    b.HasOne("PFMS.Domain.Models.Users.User", "User")
                        .WithMany("ExpenseSources")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PFMS.Domain.Models.Expenses.Expense", b =>
                {
                    b.HasOne("PFMS.Domain.Models.ExpenseSources.ExpenseSource", "ExpenseSource")
                        .WithMany("Expenses")
                        .HasForeignKey("ExpenseSourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PFMS.Domain.Models.Currencies.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("ISOCurrencyCode")
                        .HasPrincipalKey("ISOCurrencyCode");
                });

            modelBuilder.Entity("PFMS.Domain.Models.Income.Income", b =>
                {
                    b.HasOne("PFMS.Domain.Models.Currencies.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("ISOCurrencyCode")
                        .HasPrincipalKey("ISOCurrencyCode");

                    b.HasOne("PFMS.Domain.Models.IncomeSources.IncomeSource", "IncomeSource")
                        .WithMany("Income")
                        .HasForeignKey("IncomeSourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PFMS.Domain.Models.IncomeSources.IncomeSource", b =>
                {
                    b.HasOne("PFMS.Domain.Models.Users.User", "User")
                        .WithMany("IncomeSources")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PFMS.Domain.Models.Users.User", b =>
                {
                    b.HasOne("PFMS.Domain.Models.Currencies.Currency", "DefaultCurrency")
                        .WithMany()
                        .HasForeignKey("DefaultISOCurrencyCode")
                        .HasPrincipalKey("ISOCurrencyCode");
                });
#pragma warning restore 612, 618
        }
    }
}
