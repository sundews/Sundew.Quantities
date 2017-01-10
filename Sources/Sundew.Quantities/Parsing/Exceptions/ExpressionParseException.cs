// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExpressionParseException.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Parsing.Exceptions
{
    using System.Diagnostics.Contracts;
    using Sundew.Quantities.Parsing.Errors;

    /// <summary>
    /// Exception for indicating a parse error.
    /// </summary>
    public sealed class ExpressionParseException : ParseException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressionParseException" /> class.
        /// </summary>
        /// <param name="error">The parse error.</param>
        public ExpressionParseException(Error<ExpressionError> error)
            : base(error)
        {
            Contract.Requires(error != null);
            this.Error = error;
        }

        /// <summary>
        /// Gets the error.
        /// </summary>
        /// <value>
        /// The error.
        /// </value>
        public Error<ExpressionError> Error { get; }
    }
}