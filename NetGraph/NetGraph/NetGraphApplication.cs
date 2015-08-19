//-----------------------------------------------------------------------
// <copyright file="NetGraphApplication.cs" company="Gundersoft">
//     Copyright (c) Christian Gunderman. All rights reserved.
// </copyright>
// <author>Christian Gunderman</author>
//-----------------------------------------------------------------------

namespace NetGraph
{
    using System;
    using Internal;

    /// <summary>
    /// The main API class for all NetGraph applications.
    /// </summary>
    public sealed class NetGraphApplication : INetGraphApplication
    {
        // Platform dependent dependencies:
        private readonly INetProvider netProvider;

        // Fields:
        private readonly INetGraph graph;

        /// <summary>
        /// The graph of computers in the NetGraph network.
        /// </summary>
        public INetGraph Graph
        {
            get
            {
                return this.graph;
            }
        }

        /// <summary>
        /// Creates a new NetGraphApplication instance.
        /// </summary>
        /// <param name="netProvider">
        /// Interface provided by API consumer that provides required networking infrastructure.
        /// </param>
        /// <param name="name">The user friendly name for this computer.</param>
        /// <param name="uri">The URI for this computer.</param>
        public NetGraphApplication(INetProvider netProvider, string name, Uri uri)
        {
            netProvider.AssertNotNull(nameof(netProvider));
            name.AssertNotNullOrEmptyOrWhitespace(nameof(netProvider));
            uri.AssertNotNull(nameof(uri));

            this.netProvider = netProvider;
            this.graph = new NetGraph(name, uri);
        }
    }
}
