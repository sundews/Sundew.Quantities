// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ParseException.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Parsing.Exceptions
{
    using System;
    using System.Diagnostics.Contracts;

    /// <summary>
    /// Abstract base class for various parse exceptions.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public abstract class ParseException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParseException" /> class.
        /// </summary>
        /// <param name="error">The parse error.</param>
        protected ParseException(IError error)
            : base(error.GetMessage())
        {
            Contract.Requires(error != null);
        }
    }
}