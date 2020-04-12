using MetroFramework.Forms;
using Microsoft.Extensions.Options;
using PFMS.Configurations;
using PFMS.Domain.Models.Users;
using PFMS.Domain.Repositories.Users;
using PFMS.Services.Authentication;
using System.Windows.Forms;

namespace PFMS.Views
{
    public partial class FrmRegister : MetroForm
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly StyleConfiguration _styleConfiguration;
        private readonly IUserRepository _userRepository;

        public FrmRegister(
            IUserRepository userRepository,
            IAuthenticationService authenticationService,
            IOptions<StyleConfiguration> styleConfigurationOption)
        {
            _userRepository = userRepository;
            _authenticationService = authenticationService;
            _styleConfiguration = styleConfigurationOption.Value;

            InitializeComponent();

            Spinner.Left = Width / 2 - Spinner.Width / 2;

            StyleManager = _styleConfiguration.Build(this);
            ErrorText.Text = string.Empty;
        }

        private async void BtnCreateAccount_Click(object sender, System.EventArgs e)
        {
            if (ValidateFrom())
            {
                ErrorText.Text = string.Empty;
                Spinner.Spinning = true;
                Spinner.Visible = true;
                BtnCreateAccount.Enabled = false;

                var user = new User(FirstNameText.Text, LastNameText.Text, UserNameText.Text);

                _userRepository.Add(user);

                await _userRepository.SaveChangesAsync();
                await _authenticationService.SetPasswordAsync(UserNameText.Text, PasswordText.Text);
                await _authenticationService.LoginUserAsync(UserNameText.Text, PasswordText.Text);

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidateFrom()
        {
            if (string.IsNullOrEmpty(FirstNameText.Text))
            {
                ErrorText.Text = "First name is required.";
                return false;
            }

            if (string.IsNullOrEmpty(LastNameText.Text))
            {
                ErrorText.Text = "Last name is required.";
                return false;
            }

            if (string.IsNullOrEmpty(UserNameText.Text))
            {
                ErrorText.Text = "User name is required.";
                return false;
            }

            if (string.IsNullOrEmpty(PasswordText.Text))
            {
                ErrorText.Text = "Password is required.";
                return false;
            }

            if (PasswordText.Text != ConfirmPasswordText.Text)
            {
                ErrorText.Text = "Please enter correct confrim password.";
                return false;
            }

            return true;
        }
    }
}
