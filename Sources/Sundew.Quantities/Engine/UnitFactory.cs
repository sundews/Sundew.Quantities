namespace Sundew.Quantities.Engine
{
    using Sundew.Quantities.Engine.Registration;
    using Sundew.Quantities.Engine.Representations.Conversion;
    using Sundew.Quantities.Engine.Representations.Evaluation;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.Units;

    /// <summary>
    /// Default implementation of <see cref="IUnitFactory"/>.
    /// </summary>
    public class UnitFactory : IUnitFactory
    {
        private readonly IExpressionToFlatRepresentationConverter expressionToFlatRepresentationConverter;

        private readonly IExpressionRewriter expressionRewriter;

        private readonly IDerivedUnitRegistry derivedUnitRegistry;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitFactory" /> class.
        /// </summary>
        /// <param name="expressionToFlatRepresentationConverter">The expression to flat representation converter.</param>
        /// <param name="expressionRewriter">The expression rewriter.</param>
        /// <param name="derivedUnitRegistry">The derived unit registry.</param>
        public UnitFactory(IExpressionToFlatRepresentationConverter expressionToFlatRepresentationConverter, IExpressionRewriter expressionRewriter, IDerivedUnitRegistry derivedUnitRegistry)
        {
            this.expressionToFlatRepresentationConverter = expressionToFlatRepresentationConverter;
            this.expressionRewriter = expressionRewriter;
            this.derivedUnitRegistry = derivedUnitRegistry;
        }

        /// <summary>
        /// Creates an unit for the specified expression.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns>A new <see cref="IUnit"/>.</returns>
        public IUnit Create(Expression expression)
        {
            var unitExpression = expression as UnitExpression;
            return unitExpression != null ? unitExpression.Unit : this.CreateDerivedUnit(expression);
        }

        /// <summary>
        /// Creates the derived unit from the specified expression.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns>A new <see cref="DerivedUnit"/>.</returns>
        public DerivedUnit CreateDerivedUnit(Expression expression)
        {
            var flatRepresentation = this.expressionToFlatRepresentationConverter.Convert(
                expression,
                false,
                new FlatRepresentationBuilder());
            var reductionResult = new ReductionResult(flatRepresentation, expression, false);
            return this.CreateDerivedUnit(reductionResult);
        }

        /// <summary>
        /// Creates the specified reduction result.
        /// </summary>
        /// <param name="reductionResult">The reduction result.</param>
        /// <returns>A new  <see cref="IUnit"/> for the <see cref="IReductionResult"/>.</returns>
        public IUnit Create(IReductionResult reductionResult)
        {
            return this.CreateDerivedUnit(reductionResult);
        }

        /// <summary>
        /// Creates the derived unit.
        /// </summary>
        /// <param name="reductionResult">The reduction result.</param>
        /// <returns>A new <see cref="DerivedUnit" />.</returns>
        public DerivedUnit CreateDerivedUnit(IReductionResult reductionResult)
        {
            return this.CreateDerivedUnit(reductionResult, reductionResult);
        }
        
        /// <summary>
        /// Creates the derived unit.
        /// </summary>
        /// <param name="baseReductionResult">The base reduction result.</param>
        /// <param name="reductionResult">The reduction result.</param>
        /// <returns>A new <see cref="DerivedUnit" /> for the <see cref="IReductionResult" />.</returns>
        public DerivedUnit CreateDerivedUnit(IReductionResult baseReductionResult, IReductionResult reductionResult)
        {
            DerivedUnit derivedUnit;
            if (this.derivedUnitRegistry.TryGetUnit(baseReductionResult.FlatRepresentation, out derivedUnit))
            {
                return derivedUnit;
            }

            var expression = reductionResult.GetReducedExpression(this.expressionRewriter);
            var unitExpression = expression as UnitExpression;
            if (unitExpression != null)
            {
                derivedUnit = unitExpression.Unit as DerivedUnit;
                if (derivedUnit != null)
                {
                    return derivedUnit;
                }
            }

            return new DerivedUnit(null, expression);
        }

        /// <summary>
        /// Creates the prefixed unit.
        /// </summary>
        /// <param name="unit">The quantity unit.</param>
        /// <param name="prefixFactor">The prefix factor.</param>
        /// <returns>A new <see cref="IUnit"/>.</returns>
        public IUnit CreatePrefixedUnit(IUnit unit, double prefixFactor)
        {
            Prefix prefix;
            if (this.derivedUnitRegistry.TryGetPrefix(prefixFactor, out prefix))
            {
                return unit.GetPrefixedUnit(prefix);
            }

            return unit;
        }
    }
}