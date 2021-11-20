// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitExpressionParseException.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Parsing.Exceptions;

using Sundew.Quantities.Parsing.Errors;

/// <summary>
/// Exception for parsing an unit expression.
/// </summary>
/// <seealso cref="ParseException" />
public class UnitExpressionParseException : ParseException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UnitExpressionParseException"/> class.
    /// </summary>
    /// <param name="error">The error.</param>
    public UnitExpressionParseException(Error<UnitError> error)
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
    public Error<UnitError> Error { get; }
}