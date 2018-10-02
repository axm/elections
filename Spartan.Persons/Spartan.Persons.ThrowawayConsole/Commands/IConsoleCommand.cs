using Spartan.Persons.Command.Client.Requests;
using System.Threading.Tasks;

namespace Spartan.Persons.ThrowawayConsole.Commands
{
    interface IConsoleCommand
    {
        Task Execute();
    }
}
