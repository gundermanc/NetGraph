//-----------------------------------------------------------------------
// <copyright file="INetEdge.cs" company="Gundersoft">
//     Copyright (c) Christian Gunderman. All rights reserved.
// </copyright>
// <author>Christian Gunderman</author>
//-----------------------------------------------------------------------

namespace NetGraph
{
    /// <summary>
    /// The interface for the graph edges between computers.
    /// </summary>
    public interface INetEdge
    {
        /// <summary>
        /// The computer that this edge connects to.
        /// </summary>
        INetNode Destination { get; }

        /// <summary>
        /// Indicates that there exists an edge in the opposite direction.
        /// </summary>
        bool IsBidirectional { get; }

        /// <summary>
        /// The computer that this edged emits from.
        /// </summary>
        INetNode Origin { get; }
    }
}
