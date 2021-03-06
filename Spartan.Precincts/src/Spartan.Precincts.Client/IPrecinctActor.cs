﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;
using Microsoft.ServiceFabric.Actors.Remoting.FabricTransport;
using Microsoft.ServiceFabric.Services.Remoting;
using Spartan.Precincts.Client.Requests;

[assembly: FabricTransportActorRemotingProvider]

//[assembly: FabricTransportActorRemotingProvider(RemotingListener = RemotingListener.V2Listener, RemotingClient = RemotingClient.V2Client)]


namespace Spartan.Precincts.Client
{
    /// <summary>
    /// This interface defines the methods exposed by an actor.
    /// Clients use this interface to interact with the actor that implements it.
    /// </summary>
    public interface IPrecinctActor : IActor
    {
        Task SetVoteAsync(PrecinctVotesRequest request);

        Task<PrecinctVotesResponse> GetVotesAsync();
    }
}
