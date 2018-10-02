using SimpleInjector;
using Validation;

namespace Spartan.PartyMembers.Validation.Ioc
{
    public static class IocRegistration
    {
        public static Container AddValidation(this Container container)
        {
            Requires.NotNull(container, nameof(container));

            return container.AddCommandValidation().AddQueryValidation();
        }

        public static Container AddCommandValidation(this Container container)
        {
            Requires.NotNull(container, nameof(container));

            container.Register<IPartyMembersCommandValidator, PartyMembersCommandValidator>();

            return container;
        }

        public static Container AddQueryValidation(this Container container)
        {
            Requires.NotNull(container, nameof(container));

            container.Register<IPartyMembersQueryValidator, PartyMembersQueryValidator>();

            return container;
        }
    }
}
