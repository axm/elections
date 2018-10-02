using SimpleInjector;
using Spartan.Mappings.Ioc;
using Spartan.Persons.Services.Ioc;
using Validation;

namespace Spartan.Persons.CommandService.Ioc
{
    internal static class IocRegistration
    {
        public static Container AddCommandServices(this Container container)
        {
            Requires.NotNull(container, nameof(container));

            return container.RegisterCommandServices().AddMappingUtilities().RegisterEvents();
        }
    }
}
