using System.Data;
using System.Threading.Tasks;

namespace Spartan.Persons.Data
{
    public interface IDatabaseConnection
    {
        Task<IDbTransaction> GetConnection();
    }
}
