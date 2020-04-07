using Autofac;
using System;

namespace PFMS.Views
{
    public class ViewModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(ViewModule).Assembly)
                .Where(t => t.Namespace.StartsWith("PFMS.Views", StringComparison.Ordinal))
                .AsSelf()
                .InstancePerLifetimeScope();
        }
    }
}
