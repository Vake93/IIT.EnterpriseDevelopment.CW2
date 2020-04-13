using MetroFramework.Forms;
using System.Windows.Forms;

namespace PFMS.Services.ViewActivator
{
    public interface IViewActivatorService
    {
        DialogResult ShowDialog<T>(MetroForm owner) where T : MetroForm;
    }
}