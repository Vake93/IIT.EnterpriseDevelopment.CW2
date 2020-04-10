using PFMS.Domain.Models.Expenses;
using PFMS.Domain.Models.Users;
using System;
using System.Collections.Generic;

namespace PFMS.Domain.Models.ExpenseSources
{
    public class ExpenseSource : Entity
    {
        private readonly List<Expense> _expenses;

        public ExpenseSource(Guid userId, string title)
            : this()
        {
            UserId = userId;
            Title = title;
        }

        private ExpenseSource()
        {
            Title = string.Empty;

            _expenses = new List<Expense>();
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }

        public IReadOnlyList<Expense> Expenses => _expenses;
    }
}
