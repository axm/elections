using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;
using Microsoft.ServiceFabric.Actors.Runtime;
using Microsoft.ServiceFabric.Actors.Client;
using Spartan.Precincts.Client;
using Spartan.Precincts.Client.Requests;
using Spartan.Precincts.Client.Events;
using Spartan.Messaging;

namespace Spartan.Precincts.PrecinctActor
{
    /// <remarks>
    /// This class represents an actor.
    /// Every ActorID maps to an instance of this class.
    /// The StatePersistence attribute determines persistence and replication of actor state:
    ///  - Persisted: State is written to disk and replicated.
    ///  - Volatile: State is kept in memory only and replicated.
    ///  - None: State is kept in memory only and not replicated.
    /// </remarks>
    [StatePersistence(StatePersistence.Persisted)]
    internal class PrecinctActor : Actor, IPrecinctActor
    {
        private readonly IMessageDispatcher<PrecinctVoteCompleteEvent> _dispatcher;

        /// <summary>
        /// Initializes a new instance of PrecinctActor
        /// </summary>
        /// <param name="actorService">The Microsoft.ServiceFabric.Actors.Runtime.ActorService that will host this actor instance.</param>
        /// <param name="actorId">The Microsoft.ServiceFabric.Actors.ActorId for this actor instance.</param>
        public PrecinctActor(ActorService actorService, ActorId actorId) 
            : base(actorService, actorId)
        {
        }

        public async Task<PrecinctVotesResponse> GetVotesAsync()
        {
            if(!await IsCompleteAsync())
            {

            }

            throw new NotImplementedException();
        }

        public async Task SetVoteAsync(PrecinctVotesRequest request)
        {
            if(await IsCompleteAsync())
            {
                throw new InvalidOperationException();
            }


            await CompleteAsync();
            await DispatchPrecinctVoteCompleteAsync();
        }

        private Task DispatchPrecinctVoteCompleteAsync()
        {
            var voteCompleteEvent = new PrecinctVoteCompleteEvent
            {
                PrecinctId = Id.GetStringId(),
                EventTimestamp = DateTime.UtcNow
            };

            return _dispatcher.DispatchAsync(voteCompleteEvent);
        }

        private Task CompleteAsync() => StateManager.SetStateAsync("complete", true);

        private async Task<bool> IsCompleteAsync()
        {
            var isResult = await StateManager.TryGetStateAsync<bool>("complete");

            return isResult.Value;
        }

        /// <summary>
        /// This method is called whenever an actor is activated.
        /// An actor is activated the first time any of its methods are invoked.
        /// </summary>
        protected override Task OnActivateAsync()
        {
            ActorEventSource.Current.ActorMessage(this, "Actor activated.");

            // The StateManager is this actor's private state store.
            // Data stored in the StateManager will be replicated for high-availability for actors that use volatile or persisted state storage.
            // Any serializable object can be saved in the StateManager.
            // For more information, see https://aka.ms/servicefabricactorsstateserialization

            return
                Task.WhenAll(
                    this.StateManager.TryAddStateAsync("votes", 0),
                    this.StateManager.TryAddStateAsync("complete", false)
                );
        }
    }
}
