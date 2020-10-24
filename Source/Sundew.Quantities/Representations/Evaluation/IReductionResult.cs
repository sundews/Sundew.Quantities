// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IReductionResult.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Evaluation
{
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.Representations.Flat;

    /// <summary>
    /// Interface for implementing results from reducing two <see cref="Expression"/>s.
    /// </summary>
    public interface IReductionResult
    {
        /// <summary>
        /// Gets the flat representation.
        /// </summary>
        /// <value>
        /// The flat representation.
        /// </value>
        FlatRepresentation FlatRepresentation { get; }

        /// <summary>
        /// Gets the reduced expression.
        /// </summary>
        /// <param name="expressionRewriter">The expression rewriter.</param>
        /// <returns>A <see cref="Expression"/>.</returns>
        Expression GetReducedExpression(IExpressionRewriter expressionRewriter);
    }
}