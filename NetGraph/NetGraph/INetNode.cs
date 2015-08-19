//-----------------------------------------------------------------------
// <copyright file="INetNode.cs" company="Gundersoft">
//     Copyright (c) Christian Gunderman. All rights reserved.
// </copyright>
// <author>Christian Gunderman</author>
//-----------------------------------------------------------------------

namespace NetGraph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Interface definition for the NetNode that represents a computer in the NetGraph.
    /// </summary>
    public interface INetNode
    {
        /// <summary>
        /// User friendly computer name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Computer's unique Guid.
        /// </summary>
        Guid Guid { get; }

        /// <summary>
        /// The Uri for the computer or null if none.
        /// </summary>
        Uri Uri { get; }

        /// <summary>
        /// A mapping from NetNode Guid to the edge to that node.
        /// </summary>
        IDictionary<Guid, INetEdge> Edges { get; }
    }
}
