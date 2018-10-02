using Microsoft.ServiceFabric.Services.Remoting;
using Spartan.Elections.Client.Commands.Requests;
using System.Threading.Tasks;

namespace Spartan.Elections.Client.Commands
{
    public interface IElectionsCommandService : IService
    {
        /// <summary>
        /// Creates a new election.
        /// </summary>
        /// <param name="request">The parameters that will be used to create a new election.</param>
        /// <returns>
        /// A <see cref="Task"/> that represents outstanding operation.
        /// </returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="request"/> is null.</exception>
        Task Create(CreateElectionRequest request);
    }
}
