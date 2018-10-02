using Spartan.Persons.Command.Client.Requests;
using System;
using System.Threading.Tasks;

namespace Spartan.Persons.Data
{
    public interface IPersonsRepository
    {
        Task Archive(Guid personId);
        Task Create(CreatePersonRequest request);
        Task Edit(EditPersonRequest request);
    }
}
