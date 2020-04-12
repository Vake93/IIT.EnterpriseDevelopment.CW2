using MetroFramework;
using MetroFramework.Forms;
using Microsoft.Extensions.Options;
using PFMS.Configurations;
using PFMS.Persistence;
using PFMS.Seeders;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFMS.Views
{
    public partial class FrmSplash : MetroForm
    {
        private readonly StyleConfiguration _styleConfiguration;
        private readonly DatabaseContext _context;
        private readonly FrmMain _frmMain;

        public FrmSplash(
            DatabaseContext context,
            FrmMain frmMain,
            IOptions<StyleConfiguration> styleConfigurationOption)
        {
            _context = context;
            _frmMain = frmMain;
            _styleConfiguration = styleConfigurationOption.Value;

            InitializeComponent();

            Spinner.Top = Height / 2 - Spinner.Height / 2;
            Spinner.Left = Width / 2 - Spinner.Width / 2;

            StyleManager = _styleConfiguration.Build(this);

            Title.ForeColor = (StyleManager.Theme == MetroThemeStyle.Dark) ? Color.White : Color.Black;
        }

        private async void FrmSplash_Shown(object sender, EventArgs e)
        {
            //Status.Text = "Migrating database...";
            //await _context.MigrateDbAsync();

            Status.Text = "Setting-up basic data...";
            await SeedOchestrator.SeedAsync(_context);

            Status.Text = "Done.";
            await Task.Delay(TimeSpan.FromMilliseconds(500));

            _frmMain.Show();
            Close();
        }

        private void FrmSplash_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }
    }
}
