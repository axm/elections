using Spartan.Mappings;
using Validation;

namespace Spartan.Persons.QueryService.Mappings
{
    internal static class MappingRegistration
    {
        public static IMappingService AddQueryMappings(this IMappingService mappingService)
        {
            Requires.NotNull(mappingService, nameof(mappingService));

            return mappingService;
        }
    }
}
