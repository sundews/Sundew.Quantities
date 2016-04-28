namespace Sundew.Quantities.Engine.Representations.Evaluation
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;

    /// <summary>
    /// Interface for implementing an <see cref="Expression"/> reducer.
    /// </summary>
    public interface IExpressionReducer
    {
        /// <summary>
        /// Reduces the specified expression.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <param name="reduceByBaseUnits">If set to <c>true</c> reduction will be done with base units.</param>
        /// <returns>A <see cref="UnitReductionResult"/>.</returns>
        UnitReductionResult Reduce(Expression expression, bool reduceByBaseUnits); 
    }
}