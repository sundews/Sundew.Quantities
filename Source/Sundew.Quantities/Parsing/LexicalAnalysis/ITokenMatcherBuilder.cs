// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITokenMatcherBuilder.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Parsing.LexicalAnalysis;

using System.Collections.Generic;

/// <summary>
/// Interface for implementing a token matcher builder.
/// </summary>
public interface ITokenMatcherBuilder
{
    /// <summary>
    /// Builds a <see cref="TokenMatcher"/> based on the specified valid tokens.
    /// </summary>
    /// <param name="validTokens">The valid tokens.</param>
    /// <param name="areOptional">If set to <c>true</c> the tokens are optional.</param>
    /// <returns>A new <see cref="TokenMatcher"/>.</returns>
    TokenMatcher Build(IEnumerable<string> validTokens, bool areOptional);
}