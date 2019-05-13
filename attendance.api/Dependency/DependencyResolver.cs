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

        private static void RegisterDatabase(this ContainerBuilder builder)
        {
        }

        private static void RegisterRepositories(this ContainerBuilder builder, IEnumerable<string> files)
        {
            builder.Register(files, "attendance.data.dll");
        }

        private static void RegisterBusinesses(this ContainerBuilder builder, IEnumerable<string> files)
        {
            builder.Register(files, "attendance.business.dll");
        }

        private static IEnumerable<string> GetAssemblyFiles()
        {
            return Directory.EnumerateFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll", SearchOption.TopDirectoryOnly);
        }

        private static void Register(this ContainerBuilder builder, IEnumerable<string> files, string filename)
        {
            var assemblies = files
                   .Where(filePath => Path.GetFileName(filePath).Equals(filename))
                   .Select(Assembly.LoadFrom);

            builder.RegisterAssemblyTypes(assemblies.ToArray())
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
