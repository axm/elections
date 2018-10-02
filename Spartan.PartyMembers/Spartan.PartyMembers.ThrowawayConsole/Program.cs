using SimpleInjector;
using Spartan.PartyMembers.ThrowawayConsole.Commands;
using System;
using System.Threading.Tasks;

namespace Spartan.PartyMembers.ThrowawayConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await new AddPartyMemberTest().Execute();

            Console.ReadKey();
        }
    }
}
