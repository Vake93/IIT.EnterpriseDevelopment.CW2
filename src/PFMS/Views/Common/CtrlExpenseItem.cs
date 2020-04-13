using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Interfaces;
using PFMS.Domain.Models.Expenses;
using PFMS.Domain.Models.ExpenseSources;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PFMS.Views.Common
{
    public partial class CtrlExpenseItem : MetroUserControl
    {
        private readonly ExpenseSource[] _expenseSources;
        private bool _editMode;

        public CtrlExpenseItem(
            MetroStyleManager styleManager,
            ExpenseSource[] expenseSources,
            DateTime minDate,
            DateTime maxDate,
            Expense expense)
        {
            _expenseSources = expenseSources;

            InitializeComponent();

            ErrorText.Text = string.Empty;

            StyleManager = styleManager;
            Expense = expense;

            ExpenseDate.MinDate = minDate;
            ExpenseDate.MaxDate = maxDate;

            foreach (var control in Controls)
            {
                if (control is IMetroControl metroControl)
                {
                    metroControl.StyleManager = styleManager;
                }
            }

            CmbExpenseSource.DataSource = new BindingSource(_expenseSources, null);
            CmbExpenseSource.DisplayMember = nameof(Domain.Models.ExpenseSources.ExpenseSource.Title);
            CmbExpenseSource.ValueMember = nameof(Domain.Models.ExpenseSources.ExpenseSource.Id);

            if (Expense is Expense)
            {
                TitleText.Text = Expense.Title;
                ExpenseAmountText.Text = Expense.Amount.ToString();
                CmbExpenseSource.SelectedItem = _expenseSources.FirstOrDefault(i => i.Id == Expense.ExpenseSourceId);
                ExpenseDate.Value = Expense.Date;

                Amount.Text = $"Amount ({Expense.ISOCurrencyCode}):";
            }

            EditMode = false;
        }

        public delegate void ExpenseItemEvent(CtrlExpenseItem ctrlExpenseItem);

        public event ExpenseItemEvent Saved;

        public event ExpenseItemEvent Deleted;

        public Expense Expense { get; }

        public bool EditMode
        {
            get => _editMode;

            set
            {
                TitleText.ReadOnly = !value;
                ExpenseAmountText.ReadOnly = !value;
                ExpenseDate.Enabled = value;
                CmbExpenseSource.Enabled = value;
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

        private void BtnEditSave_Click(object sender, EventArgs e)
        {
            if (EditMode)
            {
                if (string.IsNullOrEmpty(TitleText.Text))
                {
                    ErrorText.Text = "Title is required";
                    return;
                }

                if (string.IsNullOrEmpty(ExpenseAmountText.Text))
                {
                    ErrorText.Text = "Amount is required";
                    return;
                }

                if (!decimal.TryParse(ExpenseAmountText.Text, out var amount))
                {
                    ErrorText.Text = "Amount is invalid";
                    return;
                }

                if (!(CmbExpenseSource.SelectedItem is ExpenseSource expenseSource))
                {
                    ErrorText.Text = "Expense Source is required";
                    return;
                }

                ErrorText.Text = string.Empty;

                Expense.Title = TitleText.Text;
                Expense.Amount = amount;
                Expense.ExpenseSourceId = expenseSource.Id;
                Expense.Date = ExpenseDate.Value.Date;

                Saved?.Invoke(this);
                EditMode = false;
            }
            else
            {
                TitleText.Text = Expense.Title;
                ExpenseAmountText.Text = Expense.Amount.ToString();
                CmbExpenseSource.SelectedItem = _expenseSources.FirstOrDefault(i => i.Id == Expense.ExpenseSourceId);
                ExpenseDate.Value = Expense.Date;

                ErrorText.Text = string.Empty;
                EditMode = true;
            }
        }

        private void BtnDeleteCancel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Expense.Title))
            {
                Deleted?.Invoke(this);
                return;
            }

            if (EditMode)
            {
                TitleText.Text = Expense.Title;
                ExpenseAmountText.Text = Expense.Amount.ToString();
                CmbExpenseSource.SelectedItem = Expense.ExpenseSourceId;
                ExpenseDate.Value = Expense.Date;

                EditMode = false;
            }
            else
            {
                var result = MetroMessageBox.Show(
                    this,
                    $"Are you sure you want to delete {Expense.Title} ?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    Deleted?.Invoke(this);
                }
            }
        }
    }
}
