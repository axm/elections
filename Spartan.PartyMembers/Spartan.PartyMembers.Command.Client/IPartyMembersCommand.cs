using Microsoft.ServiceFabric.Services.Remoting;
using Spartan.PartyMembers.Command.Client.Requests;
using System.Threading.Tasks;
using System;

namespace Spartan.PartyMembers.Command.Client
{
    public interface IPartyMembersCommand : IService
    {
        /// <summary>
        /// 
        /// </summary>
        Task AddPartyMember(AddPartyMemberRequest request);
    }
}
