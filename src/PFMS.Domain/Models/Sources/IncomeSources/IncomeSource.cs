using PFMS.Domain.Models.Sources;
using PFMS.Domain.Models.Users;
using System;
using System.Collections.Generic;
using IncomeModel = PFMS.Domain.Models.Income.Income;

namespace PFMS.Domain.Models.IncomeSources
{
    public class IncomeSource : Entity, ISource
    {
        private readonly List<IncomeModel> _income;

        public IncomeSource(Guid userId, string title)
            : this()
        {
            UserId = userId;
            Title = title;
        }

        private IncomeSource()
        {
            Title = string.Empty;
            _income = new List<IncomeModel>();
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }

        public IReadOnlyList<IncomeModel> Income => _income;
    }
}
