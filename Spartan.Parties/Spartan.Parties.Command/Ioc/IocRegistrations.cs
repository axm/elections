using System;
using Spartan.Parties.Data;
using SimpleInjector;
using Spartan.Parties.Converters.Ioc;
using Spartan.Parties.Validation;
using Spartan.Utilities.Ioc;

namespace Spartan.Parties.Command.Ioc
{
    internal static class IocRegistrations
    {
        public static Container RegisterServices(this Container container)
        {
            if (container == null)
                throw new ArgumentNullException(nameof(container));

            container.Register<IPartyCommandHandler, PartyCommandHandler>();

            return container
                .AddConfigurationUtilities()
                .AddPartyCommandValidation()
                .AddReadWriteParties()
                .AddPartyConverters();
        }
    }
}
