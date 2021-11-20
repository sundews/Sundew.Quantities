// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IQuantityParser.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Parsing;

using Sundew.Base.Primitives.Computation;
using Sundew.Quantities.Core;
using Sundew.Quantities.Parsing.Errors;
using Sundew.Quantities.Parsing.LexicalAnalysis;

/// <summary>
/// Interface for implementing a quantity parser.
/// </summary>
public interface IQuantityParser
{
    /// <summary>
    /// Parses the specified quantity.
    /// </summary>
    /// <param name="lexemes">The lexemes.</param>
    /// <param name="parseSettings">The parse settings.</param>
    /// <returns>The parsed <see cref="Quantity" />.</returns>
    Result<Quantity, Error<QuantityError>> Parse(Lexemes lexemes, ParseSettings parseSettings);
}