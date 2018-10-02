using SimpleInjector;
using Spartan.Elections.Data.Ioc;
using Spartan.Elections.Services.Ioc;
using Spartan.Mappings.Ioc;
using Validation;

namespace Spartan.Elections.CommandService.Ioc
{
    internal static class IocRegistration
    {
        public static Container RegisterServices(this Container container)
        {
            Requires.NotNull(container, nameof(container));

            container
                .AddMappingUtilities()
                .AddRepositories()
                .AddCommandServices();

            return container;
        }
    }
}
