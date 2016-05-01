// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IReductionResult.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Representations.Evaluation
{
    using Sundew.Quantities.Engine.Representations.Flat;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;

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