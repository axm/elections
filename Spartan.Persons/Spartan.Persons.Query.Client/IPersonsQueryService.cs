using Microsoft.ServiceFabric.Services.Remoting;
using Spartan.Persons.Query.Client.Requests;
using System.Threading.Tasks;

namespace Spartan.Persons.Query.Client
{
    public interface IPersonsQueryService : IService
    {
        Task<GetPersonResponse> GetPerson(GetPersonRequest request);
        Task<FindPersonsResponse> FindPersons(FindPersonsRequest request);
    }
}
