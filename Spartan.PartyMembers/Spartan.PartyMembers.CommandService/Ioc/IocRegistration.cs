﻿using SimpleInjector;
using Spartan.Mappings.Ioc;
using Spartan.PartyMembers.Data.Ioc;
using Spartan.PartyMembers.Services.Ioc;
using Spartan.PartyMembers.Validation.Ioc;
using Spartan.Utilities.Ioc;
using Validation;

namespace Spartan.PartyMembers.CommandService.Ioc
{
    public static class RegisterServices
    {
        public static Container AddCommandServices(this Container container)
        {
            Requires.NotNull(container, nameof(container));

            container.AddMappingUtilities()
                .AddCommandQueryServices()
                .AddConfigurationUtilities()
                .AddRepositoryUtilities()
                .AddCommandValidation();

            return container;
        } 
    }
}
