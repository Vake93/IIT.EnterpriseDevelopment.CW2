﻿using Autofac;
using PFMS.Persistence;
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
                .SingleInstance();

            builder.RegisterAssemblyTypes(typeof(DatabaseContext).Assembly)
                .Where(t => t.Namespace.StartsWith("PFMS.Persistence.Queries", StringComparison.Ordinal))
                .AsImplementedInterfaces()
                .SingleInstance();

            builder.RegisterAssemblyTypes(typeof(DatabaseContext).Assembly)
                .Where(t => t.Namespace.StartsWith("PFMS.Persistence.Repositories", StringComparison.Ordinal))
                .AsImplementedInterfaces()
                .SingleInstance();
        }
    }
}
