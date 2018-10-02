using System.Threading.Tasks;
using Spartan.Persons.Command.Client.Requests;
using Spartan.Persons.Query.Client.Requests;

namespace Spartan.Persons.Services.Services
{
    public interface IPersonsService
    {
        Task Create(CreatePersonRequest request);
        Task Edit(EditPersonRequest request);
        Task<FindPersonsResponse> FindPersons(FindPersonsRequest request);
        Task<GetPersonResponse> GetPerson(GetPersonRequest request);
        Task Archive(ArchivePersonRequest request);
    }
}
