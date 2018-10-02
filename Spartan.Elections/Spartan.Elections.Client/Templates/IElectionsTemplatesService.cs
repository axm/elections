using Microsoft.ServiceFabric.Services.Remoting;
using Spartan.Elections.Client.Templates.Requests;
using System.Threading.Tasks;

namespace Spartan.Elections.Client.Templates
{
    public interface IElectionsTemplatesService : IService
    {
        Task CreateAsync(CreateElectionTemplateRequest request);
        Task ArchiveAsync(ArchiveElectionTemplateRequest request);
    }
}
