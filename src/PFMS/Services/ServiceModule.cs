using Autofac;
using System;

namespace PFMS.Services
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(ServiceModule).Assembly)
                .Where(t => t.Namespace.StartsWith("PFMS.Services", StringComparison.Ordinal))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
