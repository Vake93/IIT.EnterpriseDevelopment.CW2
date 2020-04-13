using MetroFramework.Forms;
using Microsoft.Extensions.Options;
using PFMS.Configurations;
using PFMS.Domain.Models.ExpenseSources;
using PFMS.Domain.Models.IncomeSources;
using PFMS.Domain.Repositories.ExpenseSources;
using PFMS.Domain.Repositories.IncomeSources;
using PFMS.Services.Authentication;
using PFMS.Views.Common;
using System;

namespace PFMS.Views
{
    public partial class FrmSources : MetroForm
    {
        private readonly IExpenseSourceRepository _expenseSourceRepository;
        private readonly IIncomeSourceRepository _incomeSourceRepository;
        private readonly IAuthenticationService _authenticationService;
        private readonly StyleConfiguration _styleConfiguration;

        public FrmSources(
            IExpenseSourceRepository expenseSourceRepository,
            IAuthenticationService authenticationService,
            IIncomeSourceRepository incomeSourceRepository,
            IOptions<StyleConfiguration> styleConfigurationOptions)
        {
            _expenseSourceRepository = expenseSourceRepository;
            _authenticationService = authenticationService;
            _incomeSourceRepository = incomeSourceRepository;
            _styleConfiguration = styleConfigurationOptions.Value;

            InitializeComponent();

            StyleManager = _styleConfiguration.Build(this);

            Spinner.Top = Height / 2 - Spinner.Height / 2;
            Spinner.Left = Width / 2 - Spinner.Width / 2;

            Tabs.SelectedIndex = 0;
        }

        private async void FrmManageIncomeExpenseSources_Shown(object sender, EventArgs e)
        {
            SetSpinnerSpinning(true);

            var incomeSources = await _incomeSourceRepository.FindAsync(
                i => i.UserId == _authenticationService.LoggedInUser.Id && !i.Deleted);

            var expenseSources = await _expenseSourceRepository.FindAsync(
                i => i.UserId == _authenticationService.LoggedInUser.Id && !i.Deleted);

            foreach (var incomeSource in incomeSources)
            {
                var ctrlSourceItem = new CtrlSourceItem(StyleManager, incomeSource);

                IncomeLayoutPanel.Controls.Add(ctrlSourceItem);
                ctrlSourceItem.Deleted += CtrlSourceItem_Deleted;
                ctrlSourceItem.Saved += CtrlSourceItem_Saved;
            }

            foreach (var expenseSource in expenseSources)
            {
                var ctrlSourceItem = new CtrlSourceItem(StyleManager, expenseSource);

                ExpenseLayoutPanel.Controls.Add(ctrlSourceItem);
                ctrlSourceItem.Deleted += CtrlSourceItem_Deleted;
                ctrlSourceItem.Saved += CtrlSourceItem_Saved;
            }

            SetSpinnerSpinning(false);
        }

        private void SetSpinnerSpinning(bool spinning)
        {
            Tabs.Enabled = !spinning;
            Spinner.Spinning = spinning;
            Spinner.Visible = spinning;
            Spinner.BringToFront();
        }

        private void BtnNewItem_Click(object sender, EventArgs e)
        {
            if (Tabs.SelectedIndex == 0)
            {
                var ctrlSourceItem = new CtrlSourceItem(
                    StyleManager,
                    new IncomeSource(_authenticationService.LoggedInUser.Id, string.Empty))
                    {
                        EditMode = true
                    };

                IncomeLayoutPanel.Controls.Add(ctrlSourceItem);
                ctrlSourceItem.Deleted += CtrlSourceItem_Deleted;
                ctrlSourceItem.Saved += CtrlSourceItem_Saved;
            }

            if (Tabs.SelectedIndex == 1)
            {
                var ctrlSourceItem = new CtrlSourceItem(
                    StyleManager,
                    new ExpenseSource(_authenticationService.LoggedInUser.Id, string.Empty))
                {
                    EditMode = true
                };

                ExpenseLayoutPanel.Controls.Add(ctrlSourceItem);
                ctrlSourceItem.Deleted += CtrlSourceItem_Deleted;
                ctrlSourceItem.Saved += CtrlSourceItem_Saved;
            }
        }

        private async void CtrlSourceItem_Saved(CtrlSourceItem ctrlSourceItem)
        {
            SetSpinnerSpinning(true);

            if (ctrlSourceItem.Source is IncomeSource incomeSource)
            {
                var update = await _incomeSourceRepository.AnyAsync(i => i.Id == incomeSource.Id);

                if (update)
                {
                    _incomeSourceRepository.Update(incomeSource);
                }
                else
                {
                    _incomeSourceRepository.Add(incomeSource);
                }

                await _incomeSourceRepository.SaveChangesAsync();
            }

            if (ctrlSourceItem.Source is ExpenseSource expenseSource)
            {
                var update = await _expenseSourceRepository.AnyAsync(i => i.Id == expenseSource.Id);

                if (update)
                {
                    _expenseSourceRepository.Update(expenseSource);
                }
                else
                {
                    _expenseSourceRepository.Add(expenseSource);
                }

                await _expenseSourceRepository.SaveChangesAsync();
            }

            SetSpinnerSpinning(false);
        }

        private async void CtrlSourceItem_Deleted(CtrlSourceItem ctrlSourceItem)
        {
            SetSpinnerSpinning(true);

            ctrlSourceItem.Saved -= CtrlSourceItem_Saved;
            ctrlSourceItem.Deleted -= CtrlSourceItem_Deleted;

            if (ctrlSourceItem.Source is IncomeSource incomeSource)
            {
                IncomeLayoutPanel.Controls.Remove(ctrlSourceItem);

                var delete = await _incomeSourceRepository.AnyAsync(i => i.Id == incomeSource.Id);

                if (delete)
                {
                    incomeSource.Delete();
                    _incomeSourceRepository.Update(incomeSource);
                    await _incomeSourceRepository.SaveChangesAsync();
                }
            }

            if (ctrlSourceItem.Source is ExpenseSource expenseSource)
            {
                ExpenseLayoutPanel.Controls.Remove(ctrlSourceItem);

                var delete = await _expenseSourceRepository.AnyAsync(i => i.Id == expenseSource.Id);

                if (delete)
                {
                    expenseSource.Delete();
                    _expenseSourceRepository.Update(expenseSource);
                    await _expenseSourceRepository.SaveChangesAsync();
                }
            }

            SetSpinnerSpinning(false);
        }
    }
}
