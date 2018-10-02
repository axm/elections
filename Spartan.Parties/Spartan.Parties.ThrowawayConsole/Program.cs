using System;
using System.Threading.Tasks;
using AutoFixture;
using SimpleInjector;
using Spartan.Api.Parties.Contracts.Command;
using Spartan.Api.Parties.Contracts.Command.Requests;
using Spartan.Api.Parties.Contracts.Query;
using Spartan.ServiceFabric.Proxies;
using Spartan.ServiceFabric.Proxies.Ioc;

namespace Spartan.Parties.ThrowawayConsole
{
    class Program
    {
        private static readonly Uri PartiesQueryServiceUri = new Uri("fabric:/Spartan.Parties.Fabric/Spartan.Parties.Command");
        private static readonly Uri PartiesCommandServiceUri = new Uri("fabric:/Spartan.Parties.Fabric/Spartan.Parties.Query");

        private static async Task Main(string[] args)
        {
            var container = new Container();

            container.AddProxyUtilities();

            var proxy = container.GetInstance<ISpartanServiceProxy>();
            var query = proxy.Create<IPartiesQuery>(PartiesQueryServiceUri);
            var command = proxy.Create<IPartiesCommand>(PartiesCommandServiceUri);

            await TestCommand(command);
            await TestQuery(query);
        }

        private static async Task TestCommand(IPartiesCommand command)
        {
            await Task.WhenAll(command.Create(GetPartyRequest()));
        }

        private static CreatePartyRequest GetPartyRequest()
        {
            var fixture = new Fixture();

            var request = fixture.Create<CreatePartyRequest>();
            return request;
        }

        private static Task TestQuery(IPartiesQuery query)
        {
            throw new NotImplementedException();
        }
    }
}
