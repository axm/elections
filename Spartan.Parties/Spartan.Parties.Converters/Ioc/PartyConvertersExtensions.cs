using System;
using SimpleInjector;

namespace Spartan.Parties.Converters.Ioc
{
    public static class PartyConvertersExtensions
    {
        public static Container AddPartyConverters(this Container container)
        {
            if (container == null)
                throw new ArgumentNullException(nameof(container));
            container.Register<IPartyRequestsConverter, PartyRequestsConverter>();

            return container;
        }
    }
}