using MetroFramework.Forms;
using Microsoft.Extensions.Options;
using PFMS.Configurations;

namespace PFMS.Views
{
    public partial class FrmReport : MetroForm
    {
        private readonly StyleConfiguration _styleConfiguration;

        public FrmReport(
            IOptions<StyleConfiguration> styleConfigurationOptions)
        {
            _styleConfiguration = styleConfigurationOptions.Value;

            InitializeComponent();

            StyleManager = _styleConfiguration.Build(this);
        }
    }
}
