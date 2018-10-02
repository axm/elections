using SimpleInjector;
using Spartan.Elections.Data.Repositories;
using Validation;

namespace Spartan.Elections.Data.Ioc
{
    public static class IocRegistration
    {
        public static Container AddRepositories(this Container container)
        {
            Requires.NotNull(container, nameof(container));

            container.Register<IElectionsRepository, ElectionsRepository>();

            return container;
        }
    }
}
