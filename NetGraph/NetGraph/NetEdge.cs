//-----------------------------------------------------------------------
// <copyright file="NetEdge.cs" company="Gundersoft">
//     Copyright (c) Christian Gunderman. All rights reserved.
// </copyright>
// <author>Christian Gunderman</author>
//-----------------------------------------------------------------------

namespace NetGraph
{
    using Internal;

    /// <summary>
    /// An edge in the NetGraph connecting one computer to another. Edge is directed
    /// from Origin to Destination. If an edge in the opposite direction exists,
    /// IsBidirectional is true.
    /// </summary>
    public sealed class NetEdge : INetEdge
    {
        private readonly INetNode destination;
        private readonly INetNode origin;
        private readonly bool isBidirectional;

        /// <summary>
        /// The node this edge points to.
        /// </summary>
        public INetNode Destination
        {
            get
            {
                return this.destination;
            }
        }

        /// <summary>
        /// Indicates that an edge exists that points the opposite direction.
        /// </summary>
        public bool IsBidirectional
        {
            get
            {
                return this.isBidirectional;
            }
        }

        /// <summary>
        /// The node this edge emits from.
        /// </summary>
        public INetNode Origin
        {
            get
            {
                return this.origin;
            }
        }

        /// <summary>
        /// Creates a new directed NetEdge from the origin to the destination.
        /// </summary>
        /// <param name="origin">The node that the edge emits from.</param>
        /// <param name="destination">The node that the edge points to.</param>
        /// <param name="isBidirectional">
        /// Returns true if there exists an edge pointing the opposite direction.
        /// </param>
        public NetEdge(INetNode origin, INetNode destination, bool isBidirectional)
        {
            origin.AssertNotNull(nameof(origin));
            destination.AssertNotNull(nameof(destination));

            this.origin = origin;
            this.destination = destination;
            this.isBidirectional = isBidirectional;
        }
    }
}
