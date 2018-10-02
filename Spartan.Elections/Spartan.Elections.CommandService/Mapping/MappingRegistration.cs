using Spartan.Elections.Command.Client.Requests;
using Spartan.Mappings;
using Validation;

namespace Spartan.Elections.CommandService.Mapping
{
    internal static class MappingRegistration
    {
        public static IMappingService RegisterMappings(this IMappingService mappingService)
        {
            Requires.NotNull(mappingService, nameof(mappingService));

            mappingService.Bind<CreateElectionRequest, Types.Command.Requests.CreateElectionRequest>();

            return mappingService;
        }
    }
}
