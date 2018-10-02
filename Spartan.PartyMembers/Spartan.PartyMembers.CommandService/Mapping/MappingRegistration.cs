using Spartan.Mappings;
using Validation;

namespace Spartan.PartyMembers.CommandService.Mapping
{
    public static class MappingRegistration
    {
        public static IMappingService AddCommandMappings(this IMappingService service)
        {
            Requires.NotNull(service, nameof(service));

            return service;
        }
    }
}
