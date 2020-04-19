using MetroFramework;
using MetroFramework.Forms;
using Microsoft.Extensions.Options;
using PFMS.Configurations;
using PFMS.Services.Reports;
using System;
using System.Drawing;
using System.Threading.Tasks;

namespace PFMS.Views
{
    public partial class FrmReport : MetroForm
    {
        private readonly StyleConfiguration _styleConfiguration;
        private readonly IReportService _reportService;

        public FrmReport(
            IReportService reportService,
            IOptions<StyleConfiguration> styleConfigurationOptions)
        {
            _styleConfiguration = styleConfigurationOptions.Value;
            _reportService = reportService;

            InitializeComponent();

            StyleManager = _styleConfiguration.Build(this);

            ReportPanel.Top = Height / 2 - ReportPanel.Height / 2;
            ReportPanel.Left = Width / 2 - ReportPanel.Width / 2;

            CmbReportDate.Value = DateTime.Now.AddMonths(1);

            var foreColor = (Color)typeof(MetroColors).GetProperty(StyleManager.Style.ToString()).GetValue(null);
            Prediction.ForeColor = foreColor;
        }

        private void SetSpinnerSpinning(bool spinning)
        {
            Spinner.Spinning = spinning;
            Spinner.Visible = spinning;
            CmbReportDate.Enabled = !spinning;
        }

        private async void CmbReportDate_ValueChanged(object sender, EventArgs e)
        {
            SetSpinnerSpinning(true);

            var result = await _reportService.GenerateFinancialForecast(CmbReportDate.Value);

            Prediction.Text = $"Prediction from {DateTime.Now.ToLongDateString()} to {CmbReportDate.Value.ToLongDateString()}";

            AvarageIncomeText.Text = $"{result.ISOCurrencyCode} {result.AvarageIncome}";
            AvarageExpenseText.Text = $"{result.ISOCurrencyCode} {result.AvarageExpense}";
            SavingsText.Text = $"{result.ISOCurrencyCode} {result.Savings}";
            PredictedIncomeText.Text = $"{result.ISOCurrencyCode} {result.PredictedIncome}";
            PredictedExpenseText.Text = $"{result.ISOCurrencyCode} {result.PredictedExpense}";

            SetSpinnerSpinning(false);
        }
    }
}
