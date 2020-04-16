using MetroFramework.Forms;
using Microsoft.Extensions.Options;
using PFMS.Configurations;
using PFMS.Domain.Models.Users;
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

        public FrmMain(
            IReportService reportService,
            IViewActivatorService viewActivatorService,
            IAuthenticationService authenticationService,
            IOptions<StyleConfiguration> styleConfigurationOption)
        {
            _reportService = reportService;
            _viewActivatorService = viewActivatorService;
            _authenticationService = authenticationService;
            _styleConfiguration = styleConfigurationOption.Value;

            InitializeComponent();

            StyleManager = _styleConfiguration.Build(this);
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
            if (!AuthenticateUser())
            {
                Close();
            }

            StatusPanel.Visible = false;
            StatusSpinner.Visible = true;
            StatusSpinner.Spinning = true;

            var date = DateTime.Now;
            var summery = await _reportService.GetMonthlySummeryReportAsync(
                date.Year,
                date.Month);

            TotalIncomeText.Text = $"{summery.ISOCurrencyCode} {summery.TotalIncome}";
            TotalExpenseText.Text = $"{summery.ISOCurrencyCode} {summery.TotalExpense}";
            TotalSavingsText.Text = $"{summery.ISOCurrencyCode} {summery.TotalIncome}";

            StatusPanel.Visible = true;
            StatusSpinner.Visible = false;
            StatusSpinner.Spinning = false;
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
    }
}
