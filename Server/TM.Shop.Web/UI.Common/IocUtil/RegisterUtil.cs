using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace UI.Common.IocUtil
{
    public static class RegisterUtil
    {
        private static readonly IDictionary<Type, Action<IServiceCollection, Type, Type>> actions = new Dictionary<Type, Action<IServiceCollection, Type, Type>>();

        static RegisterUtil()
        {
            actions.Add(typeof(SingleServiceAttribute), (services, serviceType, implementType) =>
            {
                services.AddSingleton(implementType, serviceType);
            });

            actions.Add(typeof(ScopeAttribute), (services, serviceType, implementType) =>
            {
                services.AddScoped(implementType, serviceType);
            });

            actions.Add(typeof(TransientAttribute), (services, serviceType, implementType) =>
            {
                services.AddTransient(implementType, serviceType);
            });
        }

        public static void RegisterAssembly(this IServiceCollection services, string assemblyName)
        {
            var serviceAsm = Assembly.Load(assemblyName);
            var serviceTypes = serviceAsm.GetTypes().Where(t => !t.GetTypeInfo().IsAbstract).ToArray();
            foreach (Type serviceType in serviceTypes)
            {
                var attr = serviceType.GetCustomAttribute<ServiceTagAttribute>(true);
                if (actions.TryGetValue(attr.GetType(), out Action<IServiceCollection, Type, Type> action))
                {
                    if (attr.IocType != null)
                    {
                        action.Invoke(services, serviceType, attr.IocType);
                        continue;
                    }

                    var interfaces = serviceType.GetInterfaces();
                    foreach (var item in interfaces)
                    {
                        action.Invoke(services, serviceType, item);
                    }
                }
            }
        }
    }
}
