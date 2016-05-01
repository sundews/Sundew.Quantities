// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="UnitMultiplicationOperation.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Operations
{
    using Sundew.Quantities.Engine.Representations.Evaluation;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;

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