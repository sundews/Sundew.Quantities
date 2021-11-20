// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QuantityParseException.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Parsing;

using Sundew.Quantities.Parsing.Errors;
using Sundew.Quantities.Parsing.Exceptions;

/// <summary>
/// Exception for parsing quantities.
/// </summary>
public class QuantityParseException : ParseException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QuantityParseException" /> class.
    /// </summary>
    /// <param name="error">The error.</param>
    public QuantityParseException(Error<QuantityError> error)
        : base(error)
    {
        this.Error = error;
    }

    /// <summary>
    /// Gets the error.
    /// </summary>
    /// <value>
    /// The error.
    /// </value>
    public Error<QuantityError> Error { get; }
}