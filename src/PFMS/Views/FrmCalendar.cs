using MetroFramework.Forms;
using Microsoft.Extensions.Options;
using PFMS.Configurations;
using PFMS.Services.Authentication;
using PFMS.Views.Common;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace PFMS.Views
{
    public partial class FrmCalendar : MetroForm
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly StyleConfiguration _styleConfiguration;

        public FrmCalendar(
            IAuthenticationService authenticationService,
            IOptions<StyleConfiguration> styleConfigurationOptions)
        {
            _authenticationService = authenticationService;
            _styleConfiguration = styleConfigurationOptions.Value;

            InitializeComponent();

            StyleManager = _styleConfiguration.Build(this);

            BindYears();
            BindMonths();
        }

        private void BindMonths()
        {
            var currentMonth = DateTime.Now.Month - 1;

            CmbMonth.DataSource = new BindingSource(
                DateTimeFormatInfo.CurrentInfo.MonthNames
                    .Where(m => m != string.Empty)
                    .Select((m, i) => new { Name = m, Index = i })
                    .ToDictionary(x => x.Index, x => x.Name), null);

            CmbMonth.DisplayMember = "Value";
            CmbMonth.ValueMember = "Key";

            CmbMonth.SelectedIndex = currentMonth;
        }

        private void BindYears()
        {
            var currentYear = DateTime.Now.Year;

            CmbYear.DataSource = new BindingSource(
                Enumerable.Range(currentYear - 20, currentYear + 20)
                    .ToDictionary(x => x, x => x), null);

            CmbYear.DisplayMember = "Value";
            CmbYear.ValueMember = "Key";

            CmbYear.SelectedIndex = 20;
        }

        private void SetSpinnerSpinning(bool spinning)
        {
            Spinner.Spinning = spinning;
            Spinner.Visible = spinning;
            Spinner.BringToFront();
        }

        private void NewEvent_Click(object sender, EventArgs e)
        {
            var ctrlEventItem = new CtrlEventItem(StyleManager);

            EventLayoutPanel.Controls.Add(ctrlEventItem);
        }
    }
}
