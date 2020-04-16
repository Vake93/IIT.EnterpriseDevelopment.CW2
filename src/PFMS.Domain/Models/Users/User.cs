using PFMS.Domain.Models.BankAccounts;
using PFMS.Domain.Models.Currencies;
using PFMS.Domain.Models.Events;
using PFMS.Domain.Models.ExpenseSources;
using PFMS.Domain.Models.IncomeSources;
using System.Collections.Generic;

namespace PFMS.Domain.Models.Users
{
    public class User : Entity
    {
        private readonly List<BankAccount> _bankAccounts;
        private readonly List<IncomeSource> _incomeSources;
        private readonly List<ExpenseSource> _expenseSources;
        private readonly List<Event> _events;

        public User(string firstName, string lastName, string userName)
            : this()
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
        }

        private User()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            UserName = string.Empty;

            _bankAccounts = new List<BankAccount>();
            _incomeSources = new List<IncomeSource>();
            _expenseSources = new List<ExpenseSource>();
            _events = new List<Event>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public string DefaultISOCurrencyCode { get; set; }

        public string SecurityStamp { get; set; }

        public string UserName { get; set; }

        public string PasswordHash { get; set; }

        public Currency DefaultCurrency { get; set; }

        public IReadOnlyList<BankAccount> BankAccounts => _bankAccounts;

        public IReadOnlyList<IncomeSource> IncomeSources => _incomeSources;

        public IReadOnlyList<ExpenseSource> ExpenseSources => _expenseSources;

        public IReadOnlyList<Event> Events => _events;
    }
}
