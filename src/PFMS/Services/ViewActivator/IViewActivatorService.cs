using MetroFramework.Forms;
using System.Windows.Forms;

namespace PFMS.Services.ViewActivator
{
    public interface IViewActivatorService
    {
        void Show<T>() where T : MetroForm;
        DialogResult ShowDialog<T>(MetroForm owner) where T : MetroForm;
    }
}