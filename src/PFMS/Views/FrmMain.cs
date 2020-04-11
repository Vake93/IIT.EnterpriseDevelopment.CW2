using MetroFramework.Forms;
using PFMS.Services.Authentication;
using System.Windows.Forms;

namespace PFMS.Views
{
    public partial class FrmMain : MetroForm
    {
        private readonly IAuthenticationService _authenticationService;

        public FrmMain(IAuthenticationService authenticationService)
        {
            InitializeComponent();

            _authenticationService = authenticationService;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }
    }
}
