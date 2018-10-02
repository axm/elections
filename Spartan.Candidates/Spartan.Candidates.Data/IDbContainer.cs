using System.Data;
using System.Threading.Tasks;

namespace Elections.Candidates.Data
{
    public interface IDbContainer
    {
        Task<IDbConnection> GetReadOnlyConnection();
        Task<IDbTransaction> GetReadWriteConnection();
    }
}
