using Spartan.Mappings;
using Validation;

namespace Spartan.PartyMembers.QueryService.Mapping
{
    public static class MappingRegistration
    {
        public static IMappingService AddQueryMappings(this IMappingService service)
        {
            Requires.NotNull(service, nameof(service));

            return service;
        }
    }
}
