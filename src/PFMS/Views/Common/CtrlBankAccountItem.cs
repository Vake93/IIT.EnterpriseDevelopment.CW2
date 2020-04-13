using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Interfaces;
using PFMS.Domain.Models.BankAccounts;
using PFMS.Domain.Models.Currencies;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PFMS.Views.Common
{
    public partial class CtrlBankAccountItem : MetroUserControl
    {
        private readonly IDictionary<BankAccountType, string> _bankAccountTypes;
        private readonly Currency[] _currencies;
        private bool _editMode;

        public CtrlBankAccountItem(
            MetroStyleManager styleManager,
            IDictionary<BankAccountType, string> bankAccountTypes,
            Currency[] currencies,
            BankAccount bankAccount)
        {
            _bankAccountTypes = bankAccountTypes;
            _currencies = currencies;

            InitializeComponent();

            StyleManager = styleManager;

            foreach (var control in Controls)
            {
                if (control is IMetroControl metroControl)
                {
                    metroControl.StyleManager = styleManager;
                }
            }

            CmbCurrency.DataSource = new BindingSource(_currencies, null);
            CmbCurrency.DisplayMember = nameof(Domain.Models.Currencies.Currency.ISOCurrencyCode);
            CmbCurrency.ValueMember = nameof(Domain.Models.Currencies.Currency.ISOCurrencyCode);

            CmbAccountType.DataSource = new BindingSource(_bankAccountTypes, null);
            CmbAccountType.DisplayMember = "Value";
            CmbAccountType.ValueMember = "Key";

            BankAccount = bankAccount;

            if (BankAccount is BankAccount)
            {
                UpdateViewData();
            }

            ErrorText.Text = string.Empty;
            EditMode = false;
        }

        public delegate void BankAccountItemEvent(CtrlBankAccountItem ctrlBankAccountItem);

        public event BankAccountItemEvent Saved;

        public event BankAccountItemEvent Deleted;

        public BankAccount BankAccount { get; }

        public bool EditMode
        {
            get => _editMode;

            set
            {
                BankNameText.ReadOnly = !value;
                AccountNameText.ReadOnly = !value;
                BalanceText.ReadOnly = !value;
                InterestRateText.ReadOnly = !value;
                CmbCurrency.Enabled = value;
                CmbAccountType.Enabled = value;
                _editMode = value;

                if (_editMode)
                {
                    BtnEditSave.Text = "Save";
                    BtnDeleteCancel.Text = "Cancel";
                }
                else
                {
                    BtnEditSave.Text = "Edit";
                    BtnDeleteCancel.Text = "Delete";
                }
            }
        }

        private void BtnEditSave_Click(object sender, System.EventArgs e)
        {
            if (EditMode)
            {
                if (string.IsNullOrEmpty(BankNameText.Text))
                {
                    ErrorText.Text = "Bank Name is required";
                    return;
                }

                if (string.IsNullOrEmpty(AccountNameText.Text))
                {
                    ErrorText.Text = "Account Name is required";
                    return;
                }

                if (string.IsNullOrEmpty(BalanceText.Text))
                {
                    ErrorText.Text = "Balance is required";
                    return;
                }

                if (!decimal.TryParse(BalanceText.Text, out var balance))
                {
                    ErrorText.Text = "Balance is invalid";
                    return;
                }

                if (string.IsNullOrEmpty(InterestRateText.Text))
                {
                    ErrorText.Text = "Interest Rate is required";
                    return;
                }

                if (!decimal.TryParse(InterestRateText.Text, out var interestRate))
                {
                    ErrorText.Text = "Interest Rate is invalid";
                    return;
                }

                if (!(CmbCurrency.SelectedItem is Currency currency))
                {
                    ErrorText.Text = "Currency is required";
                    return;
                }

                if (!(CmbAccountType.SelectedItem is KeyValuePair<BankAccountType,string> bankAccountType))
                {
                    ErrorText.Text = "Account Type is required";
                    return;
                }

                ErrorText.Text = string.Empty;

                BankAccount.BankName = BankNameText.Text;
                BankAccount.AccountName = AccountNameText.Text;
                BankAccount.Balance = balance;
                BankAccount.InterestRate = interestRate / 100m;
                BankAccount.ISOCurrencyCode = currency.ISOCurrencyCode;
                BankAccount.BankAccountType = bankAccountType.Key;

                Saved?.Invoke(this);
                EditMode = false;
            }
            else
            {
                UpdateViewData();

                ErrorText.Text = string.Empty;
                EditMode = true;
            }
        }

        private void BtnDeleteCancel_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(BankAccount.AccountName))
            {
                Deleted?.Invoke(this);
                return;
            }

            if (EditMode)
            {
                UpdateViewData();

                EditMode = false;
            }
            else
            {
                var result = MetroMessageBox.Show(
                    this,
                    $"Are you sure you want to delete {BankAccount.AccountName} ?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    Deleted?.Invoke(this);
                }
            }
        }

        private void UpdateViewData()
        {
            BankNameText.Text = BankAccount.BankName;
            AccountNameText.Text = BankAccount.AccountName;
            BalanceText.Text = BankAccount.Balance.ToString();
            InterestRateText.Text = (BankAccount.InterestRate * 100m).ToString();
            CmbCurrency.SelectedItem = _currencies.FirstOrDefault(c => c.ISOCurrencyCode == BankAccount.ISOCurrencyCode);
            CmbAccountType.SelectedItem = _bankAccountTypes.FirstOrDefault(c => c.Key == BankAccount.BankAccountType);
        }
    }
}
