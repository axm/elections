using Spartan.Parties.Types.Requests;

namespace Spartan.Parties.Converters
{
    /// <inheritdoc />
    internal sealed class PartyRequestsConverter : IPartyRequestsConverter
    {
        /// <inheritdoc />
        public CreatePartyRequest Convert(Api.Parties.Contracts.Command.Requests.CreatePartyRequest request)
        {
            if (request == null)
                return null;

            return new CreatePartyRequest
            {
                PartyId = request.PartyId,
                PartyRef = request.PartyRef,
                Name = request.Name,
                CountryCode = request.CountryCode
            };
        }

        /// <inheritdoc />
        public GetPartyRequest Convert(Api.Parties.Contracts.Query.Requests.GetPartyRequest request)
        {
            if (request == null)
                return null;

            return new GetPartyRequest();
        }

        /// <inheritdoc />
        public Api.Parties.Contracts.Query.Requests.GetPartyResponse Convert(GetPartyResponse request)
        {
            if (request == null)
                return null;

            return new Api.Parties.Contracts.Query.Requests.GetPartyResponse();
        }
    }
}
