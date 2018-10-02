using SimpleInjector;
using Spartan.Utilities.Ioc;
using System.Configuration;
using Validation;

namespace Spartan.Persons.Data.Ioc
{
    public static class IocRegistration
    {
        public static Container AddPersonsRepository(this Container container)
        {
            Requires.NotNull(container, nameof(container));

            container.AddConfigurationUtilities();
            container.Register<IDatabaseConnection>(() => new DatabaseConnection(ConfigurationManager.ConnectionStrings["PersonsConnection"].ConnectionString));
            container.Register<IPersonsRepository, PersonsRepository>();

            return container;
        }
    }
}
