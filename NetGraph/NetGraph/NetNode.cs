//-----------------------------------------------------------------------
// <copyright file="NetNode.cs" company="Gundersoft">
//     Copyright (c) Christian Gunderman. All rights reserved.
// </copyright>
// <author>Christian Gunderman</author>
//-----------------------------------------------------------------------

namespace NetGraph
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using Internal;

    /// <summary>
    /// NetNode represents a computer in the NetGraph and contains edges that indicate
    /// which computer this computer can make an outgoing connection to.
    /// </summary>
    public sealed class NetNode : INetNode
    {
        private readonly Guid guid;
        private readonly Uri uri;
        private readonly string name;
        private IReadOnlyDictionary<Guid, INetEdge> edges;

        /// <summary>
        /// A dictionary of edges from this computer.
        /// </summary>
        public IReadOnlyDictionary<Guid, INetEdge> Edges
        {
            get
            {
                return this.edges;
            }
        }

        /// <summary>
        /// A unique identifier for this computer.
        /// </summary>
        public Guid Guid
        {
            get
            {
                return this.guid;
            }
        }

        /// <summary>
        /// A user friendly name for this computer.
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }
        }

        /// <summary>
        /// This computer's Uri, if it can be connected to.
        /// </summary>
        public Uri Uri
        {
            get
            {
                return this.uri;
            }
        }

        /// <summary>
        /// Creates a new NetNode with the specified fields.
        /// </summary>
        /// <param name="guid">The unique Id for the computer.</param>
        /// <param name="name">The user friendly name for the computer.</param>
        /// <param name="uri">The computer's Uri, if it has one.</param>
        /// <param name="edges">Edges from this computer to others.</param>
        public NetNode(Guid guid, string name, Uri uri, IEnumerable<INetEdge> edges)
        {
            guid.AssertNotNull(nameof(guid));
            name.AssertNotNullOrEmptyOrWhitespace(nameof(name));
            edges.AssertNotNull(nameof(edges));

            this.guid = guid;
            this.name = name;
            this.edges = edges.ToImmutableDictionary(edge => edge.Destination.Guid, edge => edge);
        }
    }
}
