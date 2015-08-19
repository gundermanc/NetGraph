//-----------------------------------------------------------------------
// <copyright file="CodeContractExtensions.cs" company="Gundersoft">
//     Copyright (c) Christian Gunderman. All rights reserved.
// </copyright>
// <author>Christian Gunderman</author>
//-----------------------------------------------------------------------

namespace NetGraph.Internal
{
    using System;

    /// <summary>
    /// Extension assert methods for maintaining class code contracts.
    /// </summary>
    internal static class CodeContractExtensions
    {
        /// <summary>
        /// Asserts that an object is not null.
        /// </summary>
        /// <exception cref="ArgumentNullException">
        /// Thrown if obj is null.
        /// </exception>
        /// <typeparam name="T">The type of the object.</typeparam>
        /// <param name="obj">The object to check.</param>
        /// <param name="argName">The name of the argument.</param>
        public static void AssertNotNull<T>(this T obj, string argName)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(string.Format("{0} cannot be null.", argName));
            }
        }

        /// <summary>
        /// Asserts that a string is not null, empty, or whitespace.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Thrown if obj is null, empty, or whitespace.
        /// </exception>
        /// <param name="obj">The string to check.</param>
        /// <param name="argName">The argument to check.</param>
        public static void AssertNotNullOrEmptyOrWhitespace(this string obj, string argName)
        {
            if (string.IsNullOrWhiteSpace(obj))
            {
                throw new ArgumentException(string.Format("{0} cannot be null, empty, or whitespace."));
            }
        }
    }
}
