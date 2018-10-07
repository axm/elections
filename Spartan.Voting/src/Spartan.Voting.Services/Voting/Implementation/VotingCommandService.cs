using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Spartan.Blobs;
using Spartan.Elections.Client.Queries;
using Spartan.Elections.Client.Queries.Requests;
using Spartan.Voting.Client.Requests;

namespace Spartan.Voting.Services.Voting.Implementation
{
    public sealed class VotingCommandService : IVotingCommandService
    {
        private readonly ISpartanBlobClient _blobClient;
        private readonly IOpenElectionsQueryService _openElectionsService;

        public VotingCommandService(ISpartanBlobClient blobClient, IOpenElectionsQueryService openElectionsService)
        {
            _blobClient = blobClient;
            _openElectionsService = openElectionsService;
        }

        /// <inheritdoc />
        public async Task<VoteResponse> VoteAsync(VoteRequest request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            var openElectionResponse = await _openElectionsService.GetOpenElectionAsync(new GetOpenElectionRequest
            {
                 ElectionId = request.ElectionId
            });

            if(!openElectionResponse.IsOpen)
            {
                throw new InvalidOperationException();
            }
            
            // publish to US voting
            //_blobClient.UploadAsync()

            throw new NotImplementedException();
        }
    }
}
