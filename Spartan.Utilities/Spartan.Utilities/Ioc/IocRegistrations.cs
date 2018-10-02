using System;
using SimpleInjector;

namespace Spartan.Utilities.Ioc
{
    public static class IocRegistrations
    {
        public static Container AddConfigurationUtilities(this Container container)
        {
            if (container == null)
                throw new ArgumentNullException(nameof(container));

            container.Register<IConfigurationService, ConfigurationService>();

            return container;
        }

        public static Container AddGuidUtilities(this Container container)
        {
            if (container == null)
                throw new ArgumentNullException(nameof(container));

            container.Register<IGuidUtility, GuidUtility>();

            return container;
        }
    }
}
