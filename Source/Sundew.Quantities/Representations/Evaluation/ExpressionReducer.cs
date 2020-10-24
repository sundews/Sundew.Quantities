// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExpressionReducer.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Representations.Evaluation
{
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.Representations.Flat;

    /// <summary>
    /// An <see cref="Expression"/> reducer implemented using the <see cref="FlatRepresentation"/>.
    /// </summary>
    public class ExpressionReducer : IExpressionReducer
    {
        private readonly IExpressionToFlatRepresentationConverter expressionToFlatRepresentationConverter;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressionReducer"/> class.
        /// </summary>
        /// <param name="expressionToFlatRepresentationConverter">The expression to flat representation converter.</param>
        public ExpressionReducer(IExpressionToFlatRepresentationConverter expressionToFlatRepresentationConverter)
        {
            this.expressionToFlatRepresentationConverter = expressionToFlatRepresentationConverter;
        }

        /// <summary>
        /// Reduces the specified expression.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <param name="reduceByBaseUnits">If set to <c>true</c> reduction will be done using base units.</param>
        /// <returns>A <see cref="UnitReductionResult"/>.</returns>
        public UnitReductionResult Reduce(Expression expression, bool reduceByBaseUnits)
        {
            var flatRepresentationBuilderWithReductions = new FlatRepresentationBuilderWithReductions();
            var flatRepresentation = this.expressionToFlatRepresentationConverter.Convert(
                expression,
                reduceByBaseUnits,
                flatRepresentationBuilderWithReductions);
            return new UnitReductionResult(
                flatRepresentation,
                expression,
                reduceByBaseUnits,
                flatRepresentationBuilderWithReductions.Reductions,
                flatRepresentationBuilderWithReductions.HasReductions);
        }
    }
}