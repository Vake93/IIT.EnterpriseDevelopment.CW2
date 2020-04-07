using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;

namespace PFMS.Persistence.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void ApplyConfigurations(
                            this ModelBuilder modelBuilder,
                            Assembly assembly,
                            Type configurationType)
        {
            var modelBuilderPublicMethods = typeof(ModelBuilder).GetMethods(BindingFlags.Public | BindingFlags.Instance);
            var applyConfigurationMethod = (MethodInfo)null;

            foreach (var method in modelBuilderPublicMethods)
            {
                if (method.Name == "ApplyConfiguration")
                {
                    var parameters = method.GetParameters();
                    if (parameters.Length == 1 &&
                        parameters[0].ParameterType.IsGenericType &&
                        parameters[0].ParameterType.GetGenericTypeDefinition() == configurationType)
                    {
                        applyConfigurationMethod = method;
                        break;
                    }
                }
            }

            if (applyConfigurationMethod is null)
            {
                return;
            }

            var configurationTypes = assembly.GetTypes()
                .Where(t => t.GetInterfaces().Any(i => i.IsConstructedGenericType && i.GetGenericTypeDefinition() == configurationType));

            foreach (var type in configurationTypes)
            {
                var genericInterface = Array.Find(
                    type.GetInterfaces(),
                    i => i.GetGenericTypeDefinition() == configurationType);

                if (genericInterface != null)
                {
                    var applyConfigurationGenericMethod = applyConfigurationMethod.MakeGenericMethod(genericInterface.GenericTypeArguments[0]);

                    applyConfigurationGenericMethod.Invoke(
                            modelBuilder,
                            new object[] { Activator.CreateInstance(type) });
                }
            }
        }
    }
}
