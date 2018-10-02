using Spartan.Persons.Command.Client.Requests;
using Spartan.Persons.ThrowawayConsole.Commands;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using AutoFixture;
using Microsoft.ServiceFabric.Services.Remoting.Client;
using Spartan.Persons.Command.Client;

namespace Spartan.Persons.ThrowawayConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var service = ServiceProxy.Create<IPersonsCommandService>(new Uri("fabric:/Spartan.Persons.Fabric/Spartan.Persons.CommandService"));
            var createPerson = new Fixture().Create<CreatePersonRequest>();
            await service.Create(createPerson);

            //var optionsText = File.ReadAllText(@"Resources\options.txt");
            //var run = true;

            //while(run)
            //{
            //    WriteInfo(optionsText);
            //    var line = Console.ReadLine();

            //    if(TryParseLine(line, out var command))
            //    {
            //        await Try(() => command.Execute());
            //    }
            //    else
            //    {
            //        WriteError($"Invalid command: '{line}'.");
            //    }
            //}
        }

        private static async Task Try(Func<Task> function)
        {
            var timer = new Stopwatch();
            timer.Start();
            try
            {
                await function();
            }
            catch (Exception e)
            {
                WriteError(e.Message);
                WriteError(e.StackTrace);
            }
            finally
            {
                timer.Stop();
                WriteInfo($"Command executed in {timer.ElapsedMilliseconds}ms");
            }
        }

        private static bool TryParseLine(string line, out IConsoleCommand command)
        {
            var fixture = new AutoFixture.Fixture();

            command = new CreatePersonCommand(fixture.Create<CreatePersonRequest>());

            return true;
        }

        private static void WriteInfo(string text)
        {
            Console.ResetColor();
            WriteText(text);
        }

        private static void WriteSuccess(string text)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            WriteText(text);
            Console.ResetColor();

        }

        private static void WriteError(string text)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            WriteText(text);
            Console.ResetColor();
        }

        private static void WriteText(string text) => Console.WriteLine(text);
    }
}
