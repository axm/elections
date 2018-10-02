using Spartan.Parties.Types.Requests;

namespace Spartan.Parties.Converters
{
    public interface IPartyRequestsConverter
    {
        CreatePartyRequest Convert(Api.Parties.Contracts.Command.Requests.CreatePartyRequest request);
        GetPartyRequest Convert(Api.Parties.Contracts.Query.Requests.GetPartyRequest request);
        Api.Parties.Contracts.Query.Requests.GetPartyResponse Convert(GetPartyResponse request);
    }
}