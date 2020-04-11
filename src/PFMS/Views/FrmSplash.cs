using MetroFramework.Forms;
using PFMS.Persistence;
using PFMS.Seeders;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFMS.Views
{
    public partial class FrmSplash : MetroForm
    {
        private readonly DatabaseContext _context;
        private readonly FrmMain _frmMain;

        public FrmSplash(DatabaseContext context, FrmMain frmMain)
        {
            InitializeComponent();

            Spinner.Top = Height / 2 - Spinner.Height / 2;
            Spinner.Left = Width / 2 - Spinner.Width / 2;

            _context = context;
            _frmMain = frmMain;
        }

        private async void FrmSplash_Shown(object sender, EventArgs e)
        {
            Status.Text = "Migrating database...";
            await _context.MigrateDbAsync();

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
