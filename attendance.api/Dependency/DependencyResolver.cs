using attendance.business.Business;
using attendance.business.Commands.User;
using attendance.data;
using attendance.objects.Contracts.Business;
using attendance.objects.Contracts.Commands.User;
using attendance.objects.Contracts.Data;
using Autofac;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace attendance.api.Dependency
{
    public static class DependencyResolver
    {
        public static void Register(this ContainerBuilder builder)
        {
            var assemblyFiles = GetAssemblyFiles();

            builder.RegisterDatabase();
            builder.RegisterRepositories(assemblyFiles);
            builder.RegisterBusinesses(assemblyFiles);
        }

        private static IEnumerable<string> GetAssemblyFiles()
        {
            return Directory.EnumerateFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll", SearchOption.TopDirectoryOnly);
        }

        private static void RegisterDatabase(this ContainerBuilder builder)
        {
        }

        private static void RegisterRepositories(this ContainerBuilder builder, IEnumerable<string> files)
        {
            var assemblies = files
                   .Where(filePath => Path.GetFileName(filePath).EndsWith("data.dll"))
                   .Select(Assembly.LoadFrom);

            builder.RegisterAssemblyTypes(assemblies.ToArray())
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }

        private static void RegisterBusinesses(this ContainerBuilder builder, IEnumerable<string> files)
        {
            var assemblies = files
                   .Where(filePath => Path.GetFileName(filePath).EndsWith("business.dll"))
                   .Select(Assembly.LoadFrom);

            builder.RegisterAssemblyTypes(assemblies.ToArray())
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
