namespace Sundew.Quantities.Engine.Operations
{
    using Sundew.Quantities.Engine.Representations.Evaluation;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;

    /// <summary>
    /// Operation for dividing two <see cref="IUnit"/>s.
    /// </summary>
    public class UnitDivisionOperation : IUnitOperation<UnitReductionResult>
    {
        private readonly IExpressionReducer expressionReducer;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitDivisionOperation"/> class.
        /// </summary>
        /// <param name="expressionReducer">The expression reducer.</param>
        public UnitDivisionOperation(IExpressionReducer expressionReducer)
        {
            this.expressionReducer = expressionReducer;
        }

        /// <summary>
        /// Executes the specified LHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <param name="reduceByBaseUnits">If set to <c>true</c> reduction will be done with base units.</param>
        /// <returns>A <see cref="UnitReductionResult"/>.</returns>
        public UnitReductionResult Execute(IUnit lhs, IUnit rhs, bool reduceByBaseUnits)
        {
            return this.expressionReducer.Reduce(
                new DivisionExpression(lhs.GetExpression(), rhs.GetExpression()),
                reduceByBaseUnits);
        }
    }
}