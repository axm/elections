using System.Data;
using System.Threading.Tasks;

namespace Spartan.Parties.Data
{
    public interface IPartiesDatabase
    {
        Task<IDbConnection> GetReadOnlyConnection();
        Task<IDbTransaction> GetReadWriteConnection();
    }
}