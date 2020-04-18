using MetroFramework.Forms;
using Microsoft.Extensions.Options;
using PFMS.Configurations;
using PFMS.Domain.Models.Users;
using PFMS.Domain.Queries.Events;
using PFMS.Services.Authentication;
using PFMS.Services.Reports;
using PFMS.Services.ViewActivator;
using System;
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

        public FrmMain(
            IEventQuery eventQuery,
            IReportService reportService,
            IViewActivatorService viewActivatorService,
            IAuthenticationService authenticationService,
            IOptions<StyleConfiguration> styleConfigurationOption)
        {
            _eventQuery = eventQuery;
            _reportService = reportService;
            _viewActivatorService = viewActivatorService;
            _authenticationService = authenticationService;
            _styleConfiguration = styleConfigurationOption.Value;

            InitializeComponent();

            Spinner.Top = Height / 2 - Spinner.Height / 2;
            Spinner.Left = Width / 2 - Spinner.Width / 2;

            StyleManager = _styleConfiguration.Build(this);
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

            var date = DateTime.Now;
            var summery = await _reportService.GetMonthlySummeryReportAsync(
                date.Year,
                date.Month);

            var events = await _eventQuery.FindAsync(
                i => i.UserId == _authenticationService.LoggedInUser.Id &&
                     i.DateTime.Date >= date.Date &&
                     !i.Deleted,
                i => i,
                skip: 0,
                limit: 10,
                orderBy: "DateTime",
                orderDirection: "asc");

            TotalIncomeText.Text = $"{summery.ISOCurrencyCode} {summery.TotalIncome}";
            TotalExpenseText.Text = $"{summery.ISOCurrencyCode} {summery.TotalExpense}";
            TotalSavingsText.Text = $"{summery.ISOCurrencyCode} {summery.TotalIncome}";

            SetSpinnerSpinning(false);
        }

        private void ManageSources_Click(object sender, EventArgs e)
        {
            _viewActivatorService.ShowDialog<FrmSources>(this);
        }

        private void NewIncome_Click(object sender, EventArgs e)
        {
            _viewActivatorService.ShowDialog<FrmIncome>(this);
        }

        private void NewExpense_Click(object sender, EventArgs e)
        {
            _viewActivatorService.ShowDialog<FrmExpense>(this);
        }

        private void BankAccount_Click(object sender, EventArgs e)
        {
            _viewActivatorService.ShowDialog<FrmBankAccount>(this);
        }

        private void Calendar_Click(object sender, EventArgs e)
        {
            _viewActivatorService.ShowDialog<FrmCalendar>(this);
        }
    }
}
