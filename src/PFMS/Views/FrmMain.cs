using MetroFramework.Forms;
using Microsoft.Extensions.Options;
using PFMS.Configurations;
using PFMS.Services.Authentication;
using System.Windows.Forms;

namespace PFMS.Views
{
    public partial class FrmMain : MetroForm
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly StyleConfiguration _styleConfiguration;
        private readonly FrmLogin _frmLogin;
        private readonly FrmRegister _frmRegister;
        public FrmMain(
            FrmLogin frmLogin,
            FrmRegister frmRegister,
            IAuthenticationService authenticationService,
            IOptions<StyleConfiguration> styleConfigurationOption)
        {
            _frmLogin = frmLogin;
            _frmRegister = frmRegister;
            _authenticationService = authenticationService;
            _styleConfiguration = styleConfigurationOption.Value;

            InitializeComponent();

            StyleManager = _styleConfiguration.Build(this);
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        private void FrmMain_Shown(object sender, System.EventArgs e)
        {
            if (_authenticationService.LoggedInUser is null)
            {
                var result = _frmLogin.ShowDialog(this);

                if (result == DialogResult.Abort)
                {
                    result = _frmRegister.ShowDialog(this);
                }

                if (result != DialogResult.OK)
                {
                    Close();
                }
            }
        }
    }
}
