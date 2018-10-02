using System.Threading.Tasks;
using Spartan.Parties.Types.Requests;

namespace Spartan.Parties.Data
{
    public interface IWriteParties
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task Create(CreatePartyRequest request);
    }
}