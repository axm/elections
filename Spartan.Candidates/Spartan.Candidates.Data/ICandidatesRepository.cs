using Spartan.Candidates.Types.Commands;
using System.Threading.Tasks;

namespace Elections.Candidates.Data
{
    public interface ICandidatesRepository
    {
        Task CreateCandidate(CreateCandidateRequest request);
    }
}
