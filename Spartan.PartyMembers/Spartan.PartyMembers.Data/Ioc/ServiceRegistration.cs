using SimpleInjector;
using Spartan.Utilities.Ioc;
using Validation;

namespace Spartan.PartyMembers.Data.Ioc
{
    public static class ServiceRegistration
    {
        public static Container AddRepositoryUtilities(this Container container)
        {
            Requires.NotNull(container, nameof(container));

            container.AddConfigurationUtilities();
            container.Register<IPartyMembersRepository, PartyMembersRepository>();

            return container;
        }

        public static Container VerifyRepositoryUtilitiesRegistration(this Container container)
        {
            Requires.NotNull(container, nameof(container));

            // check if has correct config keys etc

            return container;
        }
    }
}
