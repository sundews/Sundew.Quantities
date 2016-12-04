// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReductionResult.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.Engine.Representations.Evaluation
{
    using Sundew.Quantities.Engine.Representations.Flat;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;

    /// <summary>
    /// The result of reducing two <see cref="Expression"/>s.
    /// </summary>
    public class ReductionResult : IReductionResult
    {
        private readonly Expression expression;

        private readonly bool reduceByBaseUnit;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReductionResult"/> class.
        /// </summary>
        /// <param name="flatRepresentation">The flat representation.</param>
        /// <param name="expression">The expression.</param>
        /// <param name="reduceByBaseUnit">If set to <c>true</c> reducing was performed using the base unit.</param>
        public ReductionResult(FlatRepresentation flatRepresentation, Expression expression, bool reduceByBaseUnit)
        {
            this.expression = expression;
            this.reduceByBaseUnit = reduceByBaseUnit;
            this.FlatRepresentation = flatRepresentation;
        }

        /// <summary>
        /// Gets the flat representation.
        /// </summary>
        /// <value>
        /// A <see cref="FlatRepresentation" />.
        /// </value>
        public FlatRepresentation FlatRepresentation { get; }

        /// <summary>
        /// Gets the reduced expression.
        /// </summary>
        /// <param name="expressionRewriter">The expression rewriter.</param>
        /// <returns>
        /// A <see cref="Expression" />.
        /// </returns>
        public Expression GetReducedExpression(IExpressionRewriter expressionRewriter)
        {
            return expressionRewriter.Rewrite(
                this.expression,
                this.reduceByBaseUnit,
                this.FlatRepresentation.GetConsumer());
        }
    }
}