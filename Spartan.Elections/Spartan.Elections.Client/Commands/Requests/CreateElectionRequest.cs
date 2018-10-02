using Spartan.Elections.Client;
using System;

namespace Spartan.Elections.Client.Commands.Requests
{
    /// <summary>
    /// TODO comment
    /// </summary>
    public sealed class CreateElectionRequest
    {
        /// <summary>
        /// The proposed id of this election.
        /// </summary>
        public Guid ElectionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime Date { get; set; }
        
        /// <summary>
        /// Election specific data or other parameters, wrapped inside an object.
        /// </summary>
        /// <remarks>
        /// A common usage is to send a string, which does not require any extra effort to serialize.
        /// </remarks>
        public object ElectionData { get; set; }

        /// <summary>
        /// The country where this election will occur.
        /// </summary>
        public Country Country { get; set; }
    }
}
