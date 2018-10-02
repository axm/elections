using Spartan.Elections.Client.Templates.Requests;
using System.Threading.Tasks;

namespace Spartan.Elections.Services.Templates
{
    public interface IElectionTemplatesService
    {
        Task CreateAsync(CreateElectionTemplateRequest request);
        Task ArchiveAsync(ArchiveElectionTemplateRequest request);
    }
}
