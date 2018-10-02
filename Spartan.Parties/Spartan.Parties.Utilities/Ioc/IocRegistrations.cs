using System;
using SimpleInjector;

namespace Spartan.Parties.Utilities.Ioc
{
    public static class IocRegistrations
    {
        public static Container AddConfiguration(this Container container)
        {
            if(container == null)
                throw new ArgumentNullException(nameof(container));

            container.Register<IConfigurationService, ConfigurationService>();

            return container;
        }
    }
}
