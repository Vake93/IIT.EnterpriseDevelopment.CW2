using MetroFramework.Forms;
using Microsoft.Extensions.Options;
using PFMS.Configurations;
using PFMS.Domain.Models.Users;
using PFMS.Services.Authentication;
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

        public FrmMain(
            IViewActivatorService viewActivatorService,
            IAuthenticationService authenticationService,
            IOptions<StyleConfiguration> styleConfigurationOption)
        {
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

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            if (!AuthenticateUser())
            {
                Close();
            }
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
