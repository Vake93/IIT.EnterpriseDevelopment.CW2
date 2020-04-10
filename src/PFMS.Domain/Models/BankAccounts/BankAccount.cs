using PFMS.Domain.Models.Currencies;
using PFMS.Domain.Models.Users;
using System;

namespace PFMS.Domain.Models.BankAccounts
{
    public enum BankAccountType
    {
        SavingsAccount,
        FixedDisposite,
        CurrentAccount
    }

    public class BankAccount : Entity
    {
        public string BankName { get; set; }

        public string AccountName { get; set; }

        public BankAccountType BankAccountType { get; set; }

        public string ISOCurrencyCode { get; set; }

        public decimal Balance { get; set; }

        public decimal InterestRate { get; set; }

        public Guid UserId { get; set; }

        public Currency Currency { get; set; }

        public User User { get; set; }
    }
}
