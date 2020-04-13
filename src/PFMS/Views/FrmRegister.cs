using MetroFramework.Forms;
using Microsoft.Extensions.Options;
using PFMS.Configurations;
using PFMS.Domain.Models.Users;
using PFMS.Domain.Queries.Currencies;
using PFMS.Domain.Repositories.Users;
using PFMS.Services.Authentication;
using System.Linq;
using System.Windows.Forms;

namespace PFMS.Views
{
    public partial class FrmRegister : MetroForm
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly StyleConfiguration _styleConfiguration;
        private readonly IUserRepository _userRepository;
        private readonly ICurrencyQuery _currencyQuery;

        public FrmRegister(
            ICurrencyQuery currencyQuery,
            IUserRepository userRepository,
            IAuthenticationService authenticationService,
            IOptions<StyleConfiguration> styleConfigurationOption)
        {
            _currencyQuery = currencyQuery;
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

                var user = new User(FirstNameText.Text, LastNameText.Text, UserNameText.Text)
                {
                    DefaultISOCurrencyCode = CmbCurrency.SelectedItem as string
                };

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

            if (CmbCurrency.SelectedItem is null)
            {
                ErrorText.Text = "Currency is required.";
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

        private async void FrmRegister_Shown(object sender, System.EventArgs e)
        {
            var currencies = await _currencyQuery.FindAsync(c => true);

            CmbCurrency.Items.Clear();
            CmbCurrency.Items.AddRange(currencies.Select(c => c.ISOCurrencyCode).ToArray());
        }
    }
}
