using System;
using StructureMap;
using System.Reflection;
using System.Web;

namespace WebTest.Common.ContainerAndIoC
{
    public class ContainerManager
    {
        private static void ScanConfiguration(ConfigurationExpression config)
        {
            config.Scan(scanner =>
            {
                scanner.WithDefaultConventions();
                scanner.AssembliesFromApplicationBaseDirectory(a => a.FullName.StartsWith(DependencyResolutionConstants.DllPrefix, StringComparison.OrdinalIgnoreCase));
                scanner.LookForRegistries();
            });
        }

        public static void Bootstrap(IContainer existingContainer)
        {
            ConfigureContainer(existingContainer);
        }

        private static void ConfigureContainer(IContainer existingContainer)
        {
            _rootContainer?.Dispose();
            //Initialize() completely resets the configuration of a Container, and Configure() is purely additive.
            existingContainer.Configure(ScanConfiguration);

            _rootContainer = existingContainer;

#if DEBUG
            //existingContainer.AssertConfigurationIsValid();
            //RootContainer.WhatDidIScan();
            //RootContainer.WhatDoIHave();
#endif
        }

        private static IContainer _rootContainer;
        public static IContainer Container
        {
            get
            {
                return _rootContainer;
            }
        }
    }
}
