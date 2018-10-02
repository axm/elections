using SimpleInjector;
using Spartan.Persons.Data.Ioc;
using Spartan.Persons.Events;
using Spartan.Persons.Services.Events;
using Spartan.Persons.Services.Services;
using Spartan.Persons.Services.Services.Implementation;
using Validation;

namespace Spartan.Persons.Services.Ioc
{
    public static class IocRegistration
    {
        public static Container RegisterCommandQueryServices(this Container container)
        {
            Requires.NotNull(container, nameof(container));

            return container
                .RegisterCommandServices()
                .RegisterQueryServices();
        }

        public static Container RegisterCommandServices(this Container container)
        {
            Requires.NotNull(container, nameof(container));

            container
                .AddPersonsRepository()
                .Register<IPersonsService, PersonsService>();

            return container;
        }

        public static Container RegisterQueryServices(this Container container)
        {
            Requires.NotNull(container, nameof(container));
            
            container
                .AddPersonsRepository()
                .Register<IPersonsService, PersonsService>();

            return container;
        }

        public static Container RegisterEvents(this Container container)
        {
            Requires.NotNull(container, nameof(container));

            container.Register<IRabbitConnectionManager, RabbitConnectionManager>();
            container.Register<IEventsDispatcher<PersonCreatedEvent>, PersonCreatedEventDispatcher>();
            container.Register<IEventsDispatcher<PersonArchivedEvent>, PersonArchivedEventDispatcher>();
            container.Register<IEventsDispatcher<PersonModifiedEvent>, PersonModifiedEventDispatcher>();

            return container;
        }
    }
}
