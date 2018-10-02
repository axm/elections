using System;
using Spartan.Parties.Data;
using SimpleInjector;
using Spartan.Parties.Converters.Ioc;
using Spartan.Parties.Validation;
using Spartan.Utilities.Ioc;

namespace Spartan.Parties.Query.Ioc
{
    internal static class IocRegistration
    {
        public static Container RegisterServices(this Container container)
        {
            if (container == null)
                throw new ArgumentNullException(nameof(container));

            container.Register<IPartyQueryHandler, PartyQueryHandler>();

            return container
                .AddConfigurationUtilities()
                .AddReadWriteParties()
                .AddPartyQueryValidation()
                .AddPartyConverters();
        }
    }
}
