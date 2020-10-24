// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitMultiplicationOperation.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Core.Operations
{
    using Sundew.Quantities.Representations.Evaluation;
    using Sundew.Quantities.Representations.Expressions;

    /// <summary>
    /// Operation for multiplying two <see cref="IUnit"/>s.
    /// </summary>
    public class UnitMultiplicationOperation : IUnitOperation<UnitReductionResult>
    {
        private readonly IExpressionReducer expressionReducer;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitMultiplicationOperation"/> class.
        /// </summary>
        /// <param name="expressionReducer">The expression reducer.</param>
        public UnitMultiplicationOperation(IExpressionReducer expressionReducer)
        {
            this.expressionReducer = expressionReducer;
        }

        /// <summary>
        /// Executes the specified LHS.
        /// </summary>
        /// <param name="lhs">The LHS unit.</param>
        /// <param name="rhs">The RHS unit.</param>
        /// <param name="reduceByBaseUnits">If set to <c>true</c> reduction will be done with base units.</param>
        /// <returns>A <see cref="UnitReductionResult"/>.</returns>
        public UnitReductionResult Execute(IUnit lhs, IUnit rhs, bool reduceByBaseUnits)
        {
            return this.expressionReducer.Reduce(
                new MultiplicationExpression(lhs.GetExpression(), rhs.GetExpression()),
                reduceByBaseUnits);
        }
    }
}