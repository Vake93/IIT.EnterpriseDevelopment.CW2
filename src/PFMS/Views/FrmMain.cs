using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using Microsoft.Extensions.Options;
using PFMS.Configurations;
using PFMS.Domain.Models.Users;
using PFMS.Domain.Queries.Events;
using PFMS.Services.Authentication;
using PFMS.Services.ExchangeRates;
using PFMS.Services.Reports;
using PFMS.Services.ViewActivator;
using PFMS.Views.Common;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFMS.Views
{
    public partial class FrmMain : MetroForm
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly StyleConfiguration _styleConfiguration;
        private readonly IViewActivatorService _viewActivatorService;
        private readonly IReportService _reportService;
        private readonly IEventQuery _eventQuery;
        private readonly IExchangeRateService _exchangeRateService;

        public FrmMain(
            IEventQuery eventQuery,
            IReportService reportService,
            IExchangeRateService exchangeRateService,
            IViewActivatorService viewActivatorService,
            IAuthenticationService authenticationService,
            IOptions<StyleConfiguration> styleConfigurationOption)
        {
            _eventQuery = eventQuery;
            _reportService = reportService;
            _exchangeRateService = exchangeRateService;
            _viewActivatorService = viewActivatorService;
            _authenticationService = authenticationService;
            _styleConfiguration = styleConfigurationOption.Value;

            InitializeComponent();

            Spinner.Top = Height / 2 - Spinner.Height / 2;
            Spinner.Left = Width / 2 - Spinner.Width / 2;

            StyleManager = _styleConfiguration.Build(this);

            var foreColor = (Color)typeof(MetroColors).GetProperty(StyleManager.Style.ToString()).GetValue(null);
            CurrencyConverter.ForeColor = foreColor;
            MonthlySummary.ForeColor = foreColor;
            UpcomingEvents.ForeColor = foreColor;

        }

        private void SetSpinnerSpinning(bool spinning)
        {
            Spinner.Spinning = spinning;
            Spinner.Visible = spinning;
            Tiles.Visible = !spinning;

            CurrencyConverterPanel.Visible = !spinning;
            StatusPanel.Visible = !spinning;
            EventsPanel.Visible = !spinning;

            Spinner.BringToFront();
        }

        private bool AuthenticateUser()
        {
            if (_authenticationService.LoggedInUser is null)
            {
                var result = _viewActivatorService.ShowDialog<FrmLogin>(this);

                if (result == DialogResult.Abort)
                {
                    _viewActivatorService.ShowDialog<FrmRegister>(this);
                }
            }

            return _authenticationService.LoggedInUser is User;
        }

        private void ConvertCurrency()
        {
            var isDecimal = decimal.TryParse(TxtFromAmount.Text, out var amount);
            var from = CmbFromAmount.SelectedItem as string;
            var to = CmbToAmount.SelectedItem as string;

            TxtToAmount.Text = string.Empty;

            if (isDecimal && !string.IsNullOrEmpty(from) && !string.IsNullOrEmpty(to))
            {
                TxtToAmount.Text = _exchangeRateService.ConvertCurrency(
                    from,
                    to,
                    DateTime.Now,
                    amount).ToString();
            }
        }

        private async Task UpdateSummery()
        {
            var date = DateTime.Now;
            var summery = await _reportService.GetMonthlySummeryReportAsync(
                date.Year,
                date.Month);

            TotalIncomeText.Text = $"{summery.ISOCurrencyCode} {summery.TotalIncome}";
            TotalExpenseText.Text = $"{summery.ISOCurrencyCode} {summery.TotalExpense}";
            TotalSavingsText.Text = $"{summery.ISOCurrencyCode} {summery.TotalIncome}";
        }

        private async Task UpdateUpcomingEvents()
        {
            EventsLayoutPanel.Controls.Clear();

            var date = DateTime.Now;
            var events = await _eventQuery.FindAsync(
                i => i.UserId == _authenticationService.LoggedInUser.Id &&
                     i.DateTime.Date >= date.Date &&
                     !i.Deleted,
                i => i,
                skip: 0,
                limit: 10,
                orderBy: "DateTime",
                orderDirection: "asc");

            foreach (var @event in events)
            {
                EventsLayoutPanel.Controls.Add(new CtrlUpcomingEventItem(
                    StyleManager,
                    @event));
            }
        }

        private async Task SetupCurrencyConverter()
        {
            if (_exchangeRateService.ExchangeRates is null)
            {
                await _exchangeRateService.LoadExchangeRatesAsync();
            }

            CmbFromAmount.Items.AddRange(_exchangeRateService.GetCurrencyCodes());
            CmbToAmount.Items.AddRange(_exchangeRateService.GetCurrencyCodes());

            TxtFromAmount.Text = "100.00";
            CmbFromAmount.SelectedItem = "EUR";
            CmbToAmount.SelectedItem = "USD";
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        private async void FrmMain_Shown(object sender, EventArgs e)
        {
            SetSpinnerSpinning(true);

            if (!AuthenticateUser())
            {
                Close();
            }

            var loadExchangeRatesTask = SetupCurrencyConverter();
            await UpdateSummery();
            await UpdateUpcomingEvents();
            await loadExchangeRatesTask;

            SetSpinnerSpinning(false);
        }

        private void ManageSources_Click(object sender, EventArgs e)
        {
            _viewActivatorService.ShowDialog<FrmSources>(this);
        }

        private async void NewIncome_Click(object sender, EventArgs e)
        {
            _viewActivatorService.ShowDialog<FrmIncome>(this);

            SetSpinnerSpinning(true);
            await UpdateSummery();
            SetSpinnerSpinning(false);
        }

        private async void NewExpense_Click(object sender, EventArgs e)
        {
            _viewActivatorService.ShowDialog<FrmExpense>(this);

            SetSpinnerSpinning(true);
            await UpdateSummery();
            SetSpinnerSpinning(false);
        }

        private void BankAccount_Click(object sender, EventArgs e)
        {
            _viewActivatorService.ShowDialog<FrmBankAccount>(this);
        }

        private void Reports_Click(object sender, EventArgs e)
        {
            _viewActivatorService.ShowDialog<FrmReport>(this);
        }

        private async void Calendar_Click(object sender, EventArgs e)
        {
            _viewActivatorService.ShowDialog<FrmCalendar>(this);

            SetSpinnerSpinning(true);
            await UpdateUpcomingEvents();
            SetSpinnerSpinning(false);
        }

        private void TxtFromAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) ||
                (char.IsSymbol(e.KeyChar) && e.KeyChar != '.'))
            {
                e.Handled = true;
                return;
            }
        }

        private void CmbFromAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void CmbToAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void TxtFromAmount_TextChanged(object sender, EventArgs e)
        {
            ConvertCurrency();
        }
    }
}
