using System;
using SimpleInjector;

namespace Spartan.Parties.Data
{
    public static class DatabaseExtensions
    {
        public static Container AddReadWriteParties(this Container container)
        {
            if (container == null)
                throw new ArgumentNullException(nameof(container));

            container.Register<IPartiesDatabase, PartiesDatabase>();

            return container
                .AddPermissions()
                .AddReadParties()
                .AddWriteParties();
        }

        public static Container AddPermissions(this Container container)
        {
            if (container == null)
                throw new ArgumentNullException(nameof(container));

            container.Register<IReadPermissions, ReadPermissions>();

            return container;
        }

        public static Container AddReadParties(this Container container)
        {
            if (container == null)
                throw new ArgumentNullException(nameof(container));

            container.Register<IReadParties, ReadParties>();
            return container;
        }

        public static Container AddWriteParties(this Container container)
        {
            if(container == null)
                throw new ArgumentNullException(nameof(container));

            container.Register<IWriteParties, WriteParties>();
            return container;
        }
    }
}