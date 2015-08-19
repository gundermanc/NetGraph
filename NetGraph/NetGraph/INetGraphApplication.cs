//-----------------------------------------------------------------------
// <copyright file="INetGraphApplication.cs" company="Gundersoft">
//     Copyright (c) Christian Gunderman. All rights reserved.
// </copyright>
// <author>Christian Gunderman</author>
//-----------------------------------------------------------------------

namespace NetGraph
{
    using System;

    /// <summary>
    /// The main NetGraph API interface.
    /// </summary>
    public interface INetGraphApplication : IDisposable
    {
        /// <summary>
        /// The graph of discovered computers on the NetGraph network.
        /// </summary>
        INetGraph Graph { get; }

        /// <summary>
        /// Starts and stops the NetGraphApplication service.
        /// </summary>
        bool IsRunning { get; set; }
    }
}
