//-----------------------------------------------------------------------
// <copyright file="NetGraph.cs" company="Gundersoft">
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
    using System.Linq;

    /// <summary>
    /// Represents a directed graph of interconnected computers. Each node is a computer and
    /// each directed edge means that the origin computer can make an outgoing connection to 
    /// the destination computer.
    /// </summary>
    public sealed class NetGraph : INetGraph
    {
        private readonly INetNode thisNode;
        private readonly IReadOnlyDictionary<Guid, INetNode> nodes;

        /// <summary>
        /// A mapping from unique computer Id to the respective computer.
        /// </summary>
        public IReadOnlyDictionary<Guid, INetNode> Nodes
        {
            get
            {
                return this.nodes;
            }
        }

        /// <summary>
        /// A reference to this computer's node.
        /// </summary>
        public INetNode ThisNode
        {
            get
            {
                return this.thisNode;
            }
        }

        /// <summary>
        /// Creates an empty NetGraph with only this computer.
        /// </summary>
        /// <param name="name">The user friendly name for this computer.</param>
        /// <param name="uri">The uri to this computer.</param>
        internal NetGraph(string name, Uri uri) : 
            this(new INetNode[] { CreateAndVerifyThisNode(name, uri) })
        {
        }

        /// <summary>
        /// Creates a new NetGraph representation from raw data.
        /// </summary>
        /// <param name="nodes">
        /// A list of all nodes. The first node is assumed to be this computer.
        /// </param>
        private NetGraph(IEnumerable<INetNode> nodes)
        {
            nodes.AssertNotNull("nodes");

            if (nodes.FirstOrDefault() != null)
            {
                this.thisNode = nodes.First();
            }

            this.nodes = nodes.ToImmutableDictionary(edge => edge.Guid, edge => edge);
        }

        /// <summary>
        /// Creates the ThisNode NetNode object for this computer and verifies the inputs.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Thrown if name is null or empty.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// Thrown if the uri is null.
        /// </exception>
        /// <param name="name">A user friendly name for this computer.</param>
        /// <param name="uri">The uri to this computer, cannot be null.</param>
        /// <returns>A new node for the specified inputs.</returns>
        private static INetNode CreateAndVerifyThisNode(string name, Uri uri)
        {
            name.AssertNotNullOrEmptyOrWhitespace("name");
            uri.AssertNotNull("uri");

            return new NetNode(Guid.NewGuid(), name, uri, Enumerable.Empty<INetEdge>());
        }
    }
}
