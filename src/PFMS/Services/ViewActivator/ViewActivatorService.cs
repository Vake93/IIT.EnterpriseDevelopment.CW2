using MetroFramework.Forms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace PFMS.Services.ViewActivator
{
    public class ViewActivatorService : IViewActivatorService
    {
        private readonly IServiceProvider _services;

        public ViewActivatorService(IServiceProvider services)
        {
            _services = services;
        }

        public void Show<T>()
            where T : MetroForm
        {
            using (var scope = _services.CreateScope())
            {
                var scopedView = scope.ServiceProvider.GetRequiredService<T>();
                scopedView.Show();
            }
        }

        public DialogResult ShowDialog<T>(MetroForm owner)
            where T : MetroForm
        {
            using (var scope = _services.CreateScope())
            {
                var scopedView = scope.ServiceProvider.GetRequiredService<T>();
                return scopedView.ShowDialog(owner);
            }
        }
    }
}
