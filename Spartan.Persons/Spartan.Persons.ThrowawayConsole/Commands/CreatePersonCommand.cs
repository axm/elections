using Microsoft.ServiceFabric.Services.Remoting.Client;
using Spartan.Persons.Command.Client;
using Spartan.Persons.Command.Client.Requests;
using Spartan.Persons.Types;
using System;
using System.Threading.Tasks;

namespace Spartan.Persons.ThrowawayConsole.Commands
{
    internal sealed class CreatePersonCommand : IConsoleCommand
    {
        private CreatePersonRequest Request { get; }

        public CreatePersonCommand(CreatePersonRequest request)
        {
            Request = request;
        }

        public Task Execute()
        {
            var proxy = ServiceProxy.Create<IPersonsCommandService>(new Uri(ServiceUris.PersonsCommandService));

            return proxy.Create(Request);
        }
    }
}
