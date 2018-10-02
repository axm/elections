using Spartan.Elections.Data.Types;
using System.Threading.Tasks;

namespace Spartan.Elections.Data.Repositories
{
    public sealed class ElectionsRepository : IElectionsRepository
    {
        public ElectionsRepository()
        {
        }

        public Task CreateAsync(Election election)
        {
            throw new System.NotImplementedException();
        }
    }
}
