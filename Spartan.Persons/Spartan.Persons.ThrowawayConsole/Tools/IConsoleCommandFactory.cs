using Spartan.Persons.ThrowawayConsole.Commands;

namespace Spartan.Persons.ThrowawayConsole.Tools
{
    interface IConsoleCommandFactory
    {
        IConsoleCommand CreateCommand(string line);
    }
}
