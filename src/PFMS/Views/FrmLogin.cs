using MetroFramework.Forms;
using Microsoft.Extensions.Options;
using PFMS.Configurations;
using PFMS.Services.Authentication;
using System;
using System.Reflection;
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

        private void FrmLogin_Shown(object sender, EventArgs e)
        {
            using (var credential = new CredentialManagement.Credential())
            {
                credential.Target = Assembly.GetExecutingAssembly().FullName;

                if (credential.Load())
                {
                    UserNameText.Text = credential.Username;
                    PasswordText.Text = credential.Password;
                    RememberMe.Checked = true;
                }
            }
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            ErrorText.Text = string.Empty;
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
                using (var credential = new CredentialManagement.Credential())
                {
                    credential.Target = Assembly.GetExecutingAssembly().FullName;
                    credential.PersistanceType = CredentialManagement.PersistanceType.LocalComputer;
                    credential.Type = CredentialManagement.CredentialType.Generic;
                    credential.Username = userName;
                    credential.Password = password;
                    _ = (RememberMe.Checked) ? credential.Save() : credential.Delete();
                }

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

    }
}
