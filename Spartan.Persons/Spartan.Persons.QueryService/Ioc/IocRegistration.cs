using SimpleInjector;
using Spartan.Persons.Services.Ioc;
using Validation;

namespace Spartan.Persons.QueryService.Ioc
{
    public static class IocRegistration
    {
        public static Container AddQueryServices(this Container container)
        {
            Requires.NotNull(container, nameof(container));

            return container.RegisterQueryServices();
        }
    }
}
