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
        /// Creates a new NetGraph representation from raw data.
        /// </summary>
        /// <param name="thisNode">The node for this computer.</param>
        /// <param name="nodes">A list of all nodes.</param>
        public NetGraph(INetNode thisNode, IEnumerable<INetNode> nodes)
        {
            this.nodes = nodes.ToImmutableDictionary(edge => edge.Guid, edge => edge);
        }
    }
}
