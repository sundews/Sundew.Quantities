namespace Sundew.Quantities.Engine.Representations.Evaluation
{
    using Sundew.Quantities.Engine.Representations.Conversion;
    using Sundew.Quantities.Engine.Representations.Flat;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;

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
            var flatRepresentation = this.expressionToFlatRepresentationConverter.Convert(expression, reduceByBaseUnits, flatRepresentationBuilderWithReductions);
            return new UnitReductionResult(
                flatRepresentation,
                expression,
                reduceByBaseUnits,
                flatRepresentationBuilderWithReductions.Reductions,
                flatRepresentationBuilderWithReductions.HasReductions);
        }
    }
}