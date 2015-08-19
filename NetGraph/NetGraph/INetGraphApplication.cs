//-----------------------------------------------------------------------
// <copyright file="INetGraphApplication.cs" company="Gundersoft">
//     Copyright (c) Christian Gunderman. All rights reserved.
// </copyright>
// <author>Christian Gunderman</author>
//-----------------------------------------------------------------------

namespace NetGraph
{
    /// <summary>
    /// The main NetGraph API interface.
    /// </summary>
    public interface INetGraphApplication
    {
        /// <summary>
        /// The graph of discovered computers on the NetGraph network.
        /// </summary>
        INetGraph Graph { get; }
    }
}
