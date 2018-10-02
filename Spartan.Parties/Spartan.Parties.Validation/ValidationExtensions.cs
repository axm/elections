using System;
using SimpleInjector;

namespace Spartan.Parties.Validation
{
    public static class ValidationExtensions
    {
        public static Container AddPartyCommandValidation(this Container container)
        {
            if (container == null)
                throw new ArgumentNullException(nameof(container));

            container.Register<IPartyCommandValidator, PartyCommandValidator>();
            return container;
        }

        public static Container AddPartyQueryValidation(this Container container)
        {
            if (container == null)
                throw new ArgumentNullException(nameof(container));

            container.Register<IPartyQueryValidator, PartyQueryValidator>();
            return container;
        }
    }
}