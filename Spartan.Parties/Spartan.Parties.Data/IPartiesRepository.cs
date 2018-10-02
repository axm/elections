using System;
using System.Threading.Tasks;
using Spartan.Parties.Types.Requests;

namespace Spartan.Parties.Data
{
    public interface IPartiesRepository
    {
        Task AddToElection(Guid electionId, Guid partyId);
        Task Create(CreatePartyRequest request);
    }
}
