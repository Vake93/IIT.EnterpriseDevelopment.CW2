using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Interfaces;
using PFMS.Domain.Models.Income;
using PFMS.Domain.Models.IncomeSources;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PFMS.Views.Common
{
    public partial class CtrlIncomeItem : MetroUserControl
    {
        private readonly IncomeSource[] _incomeSources;
        private bool _editMode;

        public CtrlIncomeItem(
            MetroStyleManager styleManager,
            IncomeSource[] incomeSources,
            DateTime minDate,
            DateTime maxDate,
            Income income)
        {
            _incomeSources = incomeSources;

            InitializeComponent();

            ErrorText.Text = string.Empty;

            StyleManager = styleManager;
            Income = income;

            IncomeDate.MinDate = minDate;
            IncomeDate.MaxDate = maxDate;

            foreach (var control in Controls)
            {
                if (control is IMetroControl metroControl)
                {
                    metroControl.StyleManager = styleManager;
                }
            }

            CmbIncomeSource.DataSource = new BindingSource(_incomeSources, null);
            CmbIncomeSource.DisplayMember = nameof(Domain.Models.IncomeSources.IncomeSource.Title);
            CmbIncomeSource.ValueMember = nameof(Domain.Models.IncomeSources.IncomeSource.Id);

            if (Income is Income)
            {
                TitleText.Text = Income.Title;
                IncomeAmountText.Text = Income.Amount.ToString();
                CmbIncomeSource.SelectedItem = _incomeSources.FirstOrDefault(i => i.Id == Income.IncomeSourceId);
                IncomeDate.Value = Income.Date;

                Amount.Text = $"Amount ({Income.ISOCurrencyCode}):";
            }

            EditMode = false;
        }

        public delegate void IncomeItemEvent(CtrlIncomeItem ctrlIncomeItem);

        public event IncomeItemEvent Saved;

        public event IncomeItemEvent Deleted;

        public Income Income { get; }

        public bool EditMode
        {
            get => _editMode;

            set
            {
                TitleText.ReadOnly = !value;
                IncomeAmountText.ReadOnly = !value;
                IncomeDate.Enabled = value;
                CmbIncomeSource.Enabled = value;
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

                if (string.IsNullOrEmpty(IncomeAmountText.Text))
                {
                    ErrorText.Text = "Amount is required";
                    return;
                }

                if (!decimal.TryParse(IncomeAmountText.Text, out var amount))
                {
                    ErrorText.Text = "Amount is invalid";
                    return;
                }

                if (!(CmbIncomeSource.SelectedItem is IncomeSource incomeSource))
                {
                    ErrorText.Text = "Income Source is required";
                    return;
                }

                ErrorText.Text = string.Empty;

                Income.Title = TitleText.Text;
                Income.Amount = amount;
                Income.IncomeSourceId = incomeSource.Id;
                Income.Date = IncomeDate.Value.Date;

                Saved?.Invoke(this);
                EditMode = false;
            }
            else
            {
                TitleText.Text = Income.Title;
                IncomeAmountText.Text = Income.Amount.ToString();
                CmbIncomeSource.SelectedItem = _incomeSources.FirstOrDefault(i => i.Id == Income.IncomeSourceId);
                IncomeDate.Value = Income.Date;

                ErrorText.Text = string.Empty;
                EditMode = true;
            }
        }

        private void BtnDeleteCancel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Income.Title))
            {
                Deleted?.Invoke(this);
                return;
            }

            if (EditMode)
            {
                TitleText.Text = Income.Title;
                IncomeAmountText.Text = Income.Amount.ToString();
                CmbIncomeSource.SelectedItem = Income.IncomeSourceId;
                IncomeDate.Value = Income.Date;

                EditMode = false;
            }
            else
            {
                var result = MetroMessageBox.Show(
                    this,
                    $"Are you sure you want to delete {Income.Title} ?",
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
