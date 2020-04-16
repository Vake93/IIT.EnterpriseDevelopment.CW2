using MetroFramework.Forms;
using Microsoft.Extensions.Options;
using PFMS.Configurations;
using PFMS.Domain.Models.ExpenseSources;
using PFMS.Domain.Queries.ExpenseSources;
using PFMS.Domain.Repositories.Expenses;
using PFMS.Services.Authentication;
using PFMS.Views.Common;
using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFMS.Views
{
    public partial class FrmExpense : MetroForm
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly StyleConfiguration _styleConfiguration;
        private readonly IExpenseSourceQuery _expenseSourceQuery;
        private readonly IExpenseRepository _expenseRepository;

        private ExpenseSource[] expenseSources;
        private bool initialLoaded = false;

        public FrmExpense(
            IExpenseRepository expenseRepository,
            IExpenseSourceQuery expenseSourceQuery,
            IAuthenticationService authenticationService,
            IOptions<StyleConfiguration> styleConfigurationOptions)
        {
            _expenseRepository = expenseRepository;
            _expenseSourceQuery = expenseSourceQuery;
            _authenticationService = authenticationService;
            _styleConfiguration = styleConfigurationOptions.Value;

            InitializeComponent();

            StyleManager = _styleConfiguration.Build(this);

            Spinner.Top = Height / 2 - Spinner.Height / 2;
            Spinner.Left = Width / 2 - Spinner.Width / 2;

            BindYears();
            BindMonths();
        }

        private void SetSpinnerSpinning(bool spinning)
        {
            Spinner.Spinning = spinning;
            Spinner.Visible = spinning;
            Spinner.BringToFront();
        }

        private void BindMonths()
        {
            var currentMonth = DateTime.Now.Month - 1;

            CmbMonth.DataSource = new BindingSource(
                DateTimeFormatInfo.CurrentInfo.MonthNames
                    .Where(m => m != string.Empty)
                    .Select((m, i) => new { Name = m, Index = i })
                    .ToDictionary(x => x.Index, x => x.Name), null);

            CmbMonth.DisplayMember = "Value";
            CmbMonth.ValueMember = "Key";

            CmbMonth.SelectedIndex = currentMonth;
        }

        private void BindYears()
        {
            var currentYear = DateTime.Now.Year;

            CmbYear.DataSource = new BindingSource(
                Enumerable.Range(currentYear - 20, currentYear + 20)
                    .ToDictionary(x => x, x => x), null);

            CmbYear.DisplayMember = "Value";
            CmbYear.ValueMember = "Key";

            CmbYear.SelectedIndex = 20;
        }

        private async Task LoadData()
        {
            SetSpinnerSpinning(true);

            if (expenseSources is null)
            {
                expenseSources = await _expenseSourceQuery.FindAsync(
                    i => i.UserId == _authenticationService.LoggedInUser.Id && !i.Deleted);
            }

            var year = (int)CmbYear.SelectedValue;
            var month = CmbMonth.SelectedIndex + 1;
            var endDay = DateTime.DaysInMonth(year, month);

            var startDate = new DateTime(year, month, 1);
            var endDate = new DateTime(year, month, endDay);

            var incomeItems = await _expenseRepository.FindAsync(
                i => i.Date >= startDate &&
                     i.Date <= endDate &&
                     i.ExpenseSource.UserId == _authenticationService.LoggedInUser.Id &&
                    !i.Deleted);

            ExpnseLayoutPanel.Controls.Clear();

            foreach (var income in incomeItems)
            {
                var ctrlExpenseItem = new CtrlExpenseItem(
                    StyleManager,
                    expenseSources,
                    startDate,
                    endDate,
                    income);

                ctrlExpenseItem.Saved += CtrlExpenseItem_Saved;
                ctrlExpenseItem.Deleted += CtrlExpenseItem_Deleted;
                ExpnseLayoutPanel.Controls.Add(ctrlExpenseItem);
            }

            SetSpinnerSpinning(false);
        }

        private void NewExpense_Click(object sender, EventArgs e)
        {
            var currencyCode = _authenticationService.LoggedInUser.DefaultISOCurrencyCode;
            var year = (int)CmbYear.SelectedValue;
            var month = CmbMonth.SelectedIndex + 1;
            var endDay = DateTime.DaysInMonth(year, month);

            var startDate = new DateTime(year, month, 1);
            var endDate = new DateTime(year, month, endDay);

            var expenseDate = (DateTime.Now >= startDate && DateTime.Now <= endDate) ? DateTime.Now.Date : startDate;

            var ctrlExpenseItem = new CtrlExpenseItem(
                StyleManager,
                expenseSources,
                startDate,
                endDate,
                new Domain.Models.Expenses.Expense(Guid.Empty, currencyCode, expenseDate, string.Empty))
            {
                EditMode = true
            };

            ctrlExpenseItem.Saved += CtrlExpenseItem_Saved;
            ctrlExpenseItem.Deleted += CtrlExpenseItem_Deleted;
            ExpnseLayoutPanel.Controls.Add(ctrlExpenseItem);
        }

        private async void FrmExpense_Shown(object sender, EventArgs e)
        {
            await LoadData();
            initialLoaded = true;
        }

        private async void CtrlExpenseItem_Deleted(CtrlExpenseItem ctrlExpenseItem)
        {
            SetSpinnerSpinning(true);

            ctrlExpenseItem.Saved -= CtrlExpenseItem_Saved;
            ctrlExpenseItem.Deleted -= CtrlExpenseItem_Deleted;

            ExpnseLayoutPanel.Controls.Remove(ctrlExpenseItem);

            var delete = await _expenseRepository.AnyAsync(i => i.Id == ctrlExpenseItem.Expense.Id);

            if (delete)
            {
                ctrlExpenseItem.Expense.Delete();
                _expenseRepository.Update(ctrlExpenseItem.Expense);
                await _expenseRepository.SaveChangesAsync();
            }

            SetSpinnerSpinning(false);
        }

        private async void CtrlExpenseItem_Saved(CtrlExpenseItem ctrlExpenseItem)
        {
            SetSpinnerSpinning(true);

            var update = await _expenseRepository.AnyAsync(i => i.Id == ctrlExpenseItem.Expense.Id);

            if (update)
            {
                _expenseRepository.Update(ctrlExpenseItem.Expense);
            }
            else
            {
                _expenseRepository.Add(ctrlExpenseItem.Expense);
            }

            await _expenseRepository.SaveChangesAsync();

            SetSpinnerSpinning(false);
        }

        private async void CmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (initialLoaded)
                await LoadData();
        }

        private async void CmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (initialLoaded)
                await LoadData();
        }
    }
}
