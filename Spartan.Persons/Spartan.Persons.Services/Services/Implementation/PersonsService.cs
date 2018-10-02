using System;
using System.Threading.Tasks;
using Spartan.Persons.Command.Client.Requests;
using Spartan.Persons.Data;
using Spartan.Persons.Query.Client.Requests;
using Validation;

namespace Spartan.Persons.Services.Services.Implementation
{
    internal sealed class PersonsService : IPersonsService
    {
        private readonly IPersonsRepository _personsRepository;

        public PersonsService(IPersonsRepository personsRepository)
        {
            _personsRepository = personsRepository ?? throw new ArgumentNullException(nameof(personsRepository));
        }

        public Task Archive(ArchivePersonRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return _personsRepository.Archive(request.PersonId);
        }

        public Task Create(CreatePersonRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return _personsRepository.Create(request);
        }

        public Task Edit(EditPersonRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return _personsRepository.Edit(request);
        }

        public Task<FindPersonsResponse> FindPersons(FindPersonsRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<GetPersonResponse> GetPerson(GetPersonRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
