using Spartan.Persons.Command.Client.Requests;
using Spartan.Persons.ThrowawayConsole.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using AutoFixture;
using Validation;

namespace Spartan.Persons.ThrowawayConsole.Tools
{
    sealed class ConsoleCommandFactory : IConsoleCommandFactory
    {
        private AutoFixture.Fixture AutoFixture = new AutoFixture.Fixture();

        public IConsoleCommand CreateCommand(string line)
        {
            Requires.NotNullOrWhiteSpace(line, nameof(line));

            var parameters = line.Split(' ');
            if(!int.TryParse(parameters[0], out var commandIndex))
            {
                throw new InvalidOperationException($"Invalid command index: '{commandIndex}'.");
            }

            switch(commandIndex)
            {
                case 1:
                    // new person
                    return BuildCreatePersonCommand(parameters);
                default:
                    throw new InvalidOperationException();
            }
        }

        private IConsoleCommand BuildCreatePersonCommand(string[] parameters)
        {
            if(parameters.Length == 0)
            {

            }
            var request = AutoFixture.Create<CreatePersonRequest>();

            return new CreatePersonCommand(request);
        }
    }
}
