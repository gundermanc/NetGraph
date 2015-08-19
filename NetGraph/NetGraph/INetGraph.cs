//-----------------------------------------------------------------------
// <copyright file="INetGraph.cs" company="Gundersoft">
//     Copyright (c) Christian Gunderman. All rights reserved.
// </copyright>
// <author>Christian Gunderman</author>
//-----------------------------------------------------------------------

namespace NetGraph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The NetGraph interface.
    /// </summary>
    public interface INetGraph
    {
        /// <summary>
        /// A reference to this computer's node.
        /// </summary>
        INetNode ThisNode { get; }

        /// <summary>
        /// A mapping from a computer's unique Id to it's node.
        /// </summary>
        IReadOnlyDictionary<Guid, INetNode> Nodes { get; }
    }
}
