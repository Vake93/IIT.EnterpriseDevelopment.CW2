using MetroFramework.Forms;
using Microsoft.Extensions.Options;
using PFMS.Configurations;
using PFMS.Services.Authentication;
using System;
using System.Windows.Forms;

namespace PFMS.Views
{
    public partial class FrmLogin : MetroForm
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly StyleConfiguration _styleConfiguration;

        public FrmLogin(
            IAuthenticationService authenticationService,
            IOptions<StyleConfiguration> styleConfigurationOption)
        {
            _authenticationService = authenticationService;
            _styleConfiguration = styleConfigurationOption.Value;

            InitializeComponent();

            Spinner.Left = Width / 2 - Spinner.Width / 2;

            StyleManager = _styleConfiguration.Build(this);
            ErrorText.Text = string.Empty;
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            Spinner.Spinning = true;
            Spinner.Visible = true;

            var userName = UserNameText.Text;
            var password = PasswordText.Text;

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                ErrorText.Text = "User Name and Password is required.";
                Spinner.Spinning = false;
                Spinner.Visible = false;
                return;
            }

            if (await _authenticationService.LoginUserAsync(userName, password))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                ErrorText.Text = "Invalid User Name and/or Password.";
                Spinner.Spinning = false;
                Spinner.Visible = false;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }
    }
}
