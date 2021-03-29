// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IExpressionParser.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Parsing
{
    using Sundew.Base.Primitives.Computation;
    using Sundew.Quantities.Parsing.Errors;
    using Sundew.Quantities.Parsing.LexicalAnalysis;
    using Sundew.Quantities.Representations.Expressions;

    /// <summary>
    /// Interface for implementing an expression parser.
    /// </summary>
    public interface IExpressionParser
    {
        /// <summary>
        /// Parses the specified lexeme list.
        /// </summary>
        /// <param name="lexemes">The lexemes.</param>
        /// <param name="parseSettings">The parse settings.</param>
        /// <returns>The parsed expression.</returns>
        Result<Expression, Error<ExpressionError>> Parse(Lexemes lexemes, ParseSettings parseSettings);
    }
}