using MetroFramework;
using MetroFramework.Components;
using System.Windows.Forms;

namespace PFMS.Configurations
{
    public class StyleConfiguration
    {
        public MetroThemeStyle Theme { get; set; }

        public MetroColorStyle Color { get; set; }

        public MetroStyleManager Build(ContainerControl owner)
        {
            return new MetroStyleManager
            {
                Owner = owner,
                Style = Color,
                Theme = Theme
            };
        }
    }
}
