using Microsoft.ServiceFabric.Services.Remoting;
using Spartan.Persons.Command.Client.Requests;
using System.Threading.Tasks;

namespace Spartan.Persons.Command.Client
{
    public interface IPersonsCommandService : IService
    {
        Task Create(CreatePersonRequest request);
        Task Edit(EditPersonRequest request);
        Task Archive(ArchivePersonRequest request);
    }
}
