using attendance.business.Business;
using attendance.business.Commands.User;
using attendance.data;
using attendance.objects.Contracts.Business;
using attendance.objects.Contracts.Commands.User;
using attendance.objects.Contracts.Data;
using Autofac;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace attendance.api.Dependency
{
    public static class DependencyResolver
    {
        public static void Register(this ContainerBuilder builder)
        {
            builder.RegisterDatabase();
            builder.RegisterRepositories();
            builder.RegisterBusinesses();
        }

        private static void RegisterDatabase(this ContainerBuilder builder)
        {
        }

        private static void RegisterRepositories(this ContainerBuilder builder)
        {
            var assemblies = Directory.EnumerateFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll", SearchOption.TopDirectoryOnly)
                   .Where(filePath => Path.GetFileName(filePath).EndsWith("data.dll"))
                   .Select(Assembly.LoadFrom);

            builder.RegisterAssemblyTypes(assemblies.ToArray())
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }

        private static void RegisterBusinesses(this ContainerBuilder builder)
        {
            var assemblies = Directory.EnumerateFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll", SearchOption.TopDirectoryOnly)
                   .Where(filePath => Path.GetFileName(filePath).EndsWith("business.dll"))
                   .Select(Assembly.LoadFrom);

            builder.RegisterAssemblyTypes(assemblies.ToArray())
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
