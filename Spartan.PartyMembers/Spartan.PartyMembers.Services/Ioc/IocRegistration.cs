using SimpleInjector;
using Spartan.PartyMembers.Services.Commands;
using Spartan.PartyMembers.Services.Commands.Implementation;
using Validation;

namespace Spartan.PartyMembers.Services.Ioc
{
    public static class IocRegistration
    {
        public static Container AddCommandQueryServices(this Container container)
        {
            Requires.NotNull(container, nameof(container));

            return container
                .AddCommandServices()
                .AddQueryServices();
        }

        public static Container AddCommandServices(this Container container)
        {
            Requires.NotNull(container, nameof(container));

            container.Register<IPartyMembersCommandHandler, PartyMembersCommandHandler>();

            return container;
        }

        public static Container AddQueryServices(this Container container)
        {
            Requires.NotNull(container, nameof(container));


            return container;
        }
    }
}
