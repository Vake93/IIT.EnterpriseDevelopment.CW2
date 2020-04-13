using MetroFramework.Forms;
using Microsoft.Extensions.Options;
using PFMS.Configurations;
using PFMS.Domain.Models.IncomeSources;
using PFMS.Domain.Queries.IncomeSources;
using PFMS.Domain.Repositories.Income;
using PFMS.Services.Authentication;
using PFMS.Views.Common;
using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFMS.Views
{
    public partial class FrmIncome : MetroForm
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly StyleConfiguration _styleConfiguration;
        private readonly IIncomeSourceQuery _incomeSourceQuery;
        private readonly IIncomeRepository _incomeRepository;

        private IncomeSource[] incomeSources;
        private bool initialLoaded = false;

        public FrmIncome(
            IIncomeRepository incomeRepository,
            IIncomeSourceQuery incomeSourceQuery,
            IAuthenticationService authenticationService,
            IOptions<StyleConfiguration> styleConfigurationOptions)
        {
            _incomeRepository = incomeRepository;
            _incomeSourceQuery = incomeSourceQuery;
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

        private async void FrmIncome_Shown(object sender, EventArgs e)
        {
            await LoadData();
            initialLoaded = true;
        }

        private async Task LoadData()
        {
            SetSpinnerSpinning(true);

            if (incomeSources is null)
            {
                incomeSources = await _incomeSourceQuery.FindAsync(
                    i => i.UserId == _authenticationService.LoggedInUser.Id && !i.Deleted);
            }

            var year = (int)CmbYear.SelectedValue;
            var month = CmbMonth.SelectedIndex + 1;
            var endDay = DateTime.DaysInMonth(year, month);

            var startDate = new DateTime(year, month, 1);
            var endDate = new DateTime(year, month, endDay);

            var incomeItems = await _incomeRepository.FindAsync(
                i => i.Date >= startDate &&
                     i.Date <= endDate &&
                     i.IncomeSource.UserId == _authenticationService.LoggedInUser.Id &&
                    !i.Deleted);

            IncomeLayoutPanel.Controls.Clear();

            foreach (var income in incomeItems)
            {
                var ctrlIncomeItem = new CtrlIncomeItem(
                    StyleManager,
                    incomeSources,
                    startDate,
                    endDate,
                    income);

                ctrlIncomeItem.Saved += CtrlIncomeItem_Saved;
                ctrlIncomeItem.Deleted += CtrlIncomeItem_Deleted;
                IncomeLayoutPanel.Controls.Add(ctrlIncomeItem);
            }

            SetSpinnerSpinning(false);
        }

        private void NewIncome_Click(object sender, EventArgs e)
        {
            var currencyCode = _authenticationService.LoggedInUser.DefaultISOCurrencyCode;
            var year = (int)CmbYear.SelectedValue;
            var month = CmbMonth.SelectedIndex + 1;
            var endDay = DateTime.DaysInMonth(year, month);

            var startDate = new DateTime(year, month, 1);
            var endDate = new DateTime(year, month, endDay);

            var incomeDate = (DateTime.Now >= startDate && DateTime.Now <= endDate) ? DateTime.Now.Date : startDate;

            var ctrlIncomeItem = new CtrlIncomeItem(
                StyleManager,
                incomeSources,
                startDate,
                endDate,
                new Domain.Models.Income.Income(Guid.Empty, currencyCode, incomeDate, string.Empty))
            {
                EditMode = true
            };

            ctrlIncomeItem.Saved += CtrlIncomeItem_Saved;
            ctrlIncomeItem.Deleted += CtrlIncomeItem_Deleted;
            IncomeLayoutPanel.Controls.Add(ctrlIncomeItem);
        }

        private async void CtrlIncomeItem_Deleted(CtrlIncomeItem ctrlIncomeItem)
        {
            SetSpinnerSpinning(true);

            ctrlIncomeItem.Saved -= CtrlIncomeItem_Saved;
            ctrlIncomeItem.Deleted -= CtrlIncomeItem_Deleted;

            IncomeLayoutPanel.Controls.Remove(ctrlIncomeItem);

            var delete = await _incomeRepository.AnyAsync(i => i.Id == ctrlIncomeItem.Income.Id);

            if (delete)
            {
                ctrlIncomeItem.Income.Delete();
                _incomeRepository.Update(ctrlIncomeItem.Income);
                await _incomeRepository.SaveChangesAsync();
            }

            SetSpinnerSpinning(false);
        }

        private async void CtrlIncomeItem_Saved(CtrlIncomeItem ctrlIncomeItem)
        {
            SetSpinnerSpinning(true);

            var update = await _incomeRepository.AnyAsync(i => i.Id == ctrlIncomeItem.Income.Id);

            if (update)
            {
                _incomeRepository.Update(ctrlIncomeItem.Income);
            }
            else
            {
                _incomeRepository.Add(ctrlIncomeItem.Income);
            }

            await _incomeRepository.SaveChangesAsync();

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
