using Spartan.Mappings;
using Validation;

namespace Spartan.Persons.CommandService.Mappings
{
    internal static class MappingRegistration
    {
        public static IMappingService AddCommandMappings(this IMappingService mappingService)
        {
            Requires.NotNull(mappingService, nameof(mappingService));

            return mappingService;
        }
    }
}
