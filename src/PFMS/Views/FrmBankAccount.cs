using MetroFramework.Forms;
using Microsoft.Extensions.Options;
using PFMS.Configurations;
using PFMS.Domain.Models.BankAccounts;
using PFMS.Domain.Models.Currencies;
using PFMS.Domain.Queries.Currencies;
using PFMS.Domain.Repositories.BankAccounts;
using PFMS.Services.Authentication;
using PFMS.Views.Common;
using System.Collections.Generic;

namespace PFMS.Views
{
    public partial class FrmBankAccount : MetroForm
    {
        private static readonly IDictionary<BankAccountType, string> _bankAccountTypes;

        private readonly IBankAccountRepository _bankAccountRepository;
        private readonly IAuthenticationService _authenticationService;
        private readonly StyleConfiguration _styleConfiguration;
        private readonly ICurrencyQuery _currencyQuery;

        private Currency[] _currencies;

        static FrmBankAccount()
        {
            _bankAccountTypes = new Dictionary<BankAccountType, string>
            {
                { BankAccountType.CurrentAccount, "Current Account" },
                { BankAccountType.FixedDeposit, "Fixed Deposit" },
                { BankAccountType.SavingsAccount, "Savings Account" }
            };
        }

        public FrmBankAccount(
            ICurrencyQuery currencyQuery,
            IAuthenticationService authenticationService,
            IBankAccountRepository bankAccountRepository,
            IOptions<StyleConfiguration> styleConfigurationOptions)
        {
            _currencyQuery = currencyQuery;
            _authenticationService = authenticationService;
            _bankAccountRepository = bankAccountRepository;
            _styleConfiguration = styleConfigurationOptions.Value;

            InitializeComponent();

            StyleManager = _styleConfiguration.Build(this);

            Spinner.Top = Height / 2 - Spinner.Height / 2;
            Spinner.Left = Width / 2 - Spinner.Width / 2;
        }

        private void SetSpinnerSpinning(bool spinning)
        {
            Spinner.Spinning = spinning;
            Spinner.Visible = spinning;
            Spinner.BringToFront();
        }

        private async void FrmBankAccount_Shown(object sender, System.EventArgs e)
        {
            SetSpinnerSpinning(true);

            if (_currencies is null)
            {
                _currencies = await _currencyQuery.FindAsync(t => !t.Deleted);
            }

            var bankAccounts = await _bankAccountRepository.FindAsync(
                t => t.UserId == _authenticationService.LoggedInUser.Id && !t.Deleted);

            foreach (var bankAccount in bankAccounts)
            {
                var ctrlBankAccount = new CtrlBankAccountItem(
                    StyleManager,
                    _bankAccountTypes,
                    _currencies,
                    bankAccount);

                ctrlBankAccount.Saved += CtrlBankAccount_Saved;
                ctrlBankAccount.Deleted += CtrlBankAccount_Deleted;

                FlowLayoutPanel.Controls.Add(ctrlBankAccount);
            }

            SetSpinnerSpinning(false);
        }

        private void NewBankAccount_Click(object sender, System.EventArgs e)
        {
            var ctrlBankAccount = new CtrlBankAccountItem(
                StyleManager,
                _bankAccountTypes,
                _currencies,
                new BankAccount(_authenticationService.LoggedInUser.Id, string.Empty, string.Empty)
                {
                    BankAccountType = BankAccountType.SavingsAccount,
                    ISOCurrencyCode = _authenticationService.LoggedInUser.DefaultISOCurrencyCode
                })
            {
                EditMode = true
            };

            ctrlBankAccount.Saved += CtrlBankAccount_Saved;
            ctrlBankAccount.Deleted += CtrlBankAccount_Deleted;

            FlowLayoutPanel.Controls.Add(ctrlBankAccount);
        }

        private async void CtrlBankAccount_Deleted(CtrlBankAccountItem ctrlBankAccountItem)
        {
            SetSpinnerSpinning(true);
            ctrlBankAccountItem.Saved -= CtrlBankAccount_Saved;
            ctrlBankAccountItem.Deleted -= CtrlBankAccount_Deleted;

            FlowLayoutPanel.Controls.Remove(ctrlBankAccountItem);

            var delete = await _bankAccountRepository.AnyAsync(
                b => b.Id == ctrlBankAccountItem.BankAccount.Id);

            if (delete)
            {
                ctrlBankAccountItem.BankAccount.Delete();
                _bankAccountRepository.Update(ctrlBankAccountItem.BankAccount);
                await _bankAccountRepository.SaveChangesAsync();
            }

            SetSpinnerSpinning(false);
        }

        private async void CtrlBankAccount_Saved(CtrlBankAccountItem ctrlBankAccountItem)
        {
            SetSpinnerSpinning(true);

            var update = await _bankAccountRepository.AnyAsync(
                b => b.Id == ctrlBankAccountItem.BankAccount.Id);

            if (update)
            {
                _bankAccountRepository.Update(ctrlBankAccountItem.BankAccount);
            }
            else
            {
                _bankAccountRepository.Add(ctrlBankAccountItem.BankAccount);
            }

            await _bankAccountRepository.SaveChangesAsync();

            SetSpinnerSpinning(false);
        }
    }
}
