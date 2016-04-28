namespace Sundew.Quantities.Engine.Operations
{
    using System;

    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Engine.Representations.Evaluation;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;

    /// <summary>
    /// Operation for raising a <see cref="IQuantity"/> instance with an exponent.
    /// </summary>
    public class ExponentiationOperation : IQuantityOperation<double>
    {
        private readonly IUnitFactory unitFactory;

        private readonly IExpressionReducer expressionReducer;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExponentiationOperation"/> class.
        /// </summary>
        /// <param name="unitFactory">The unit factory.</param>
        /// <param name="expressionReducer">The expression reducer.</param>
        public ExponentiationOperation(IUnitFactory unitFactory, IExpressionReducer expressionReducer)
        {
            this.unitFactory = unitFactory;
            this.expressionReducer = expressionReducer;
        }

        /// <summary>
        /// Executes the specified LHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS value.</param>
        /// <returns>
        /// A <see cref="Quantity" />.
        /// </returns>
        public IQuantity Execute(IQuantity lhs, double rhs)
        {
            var magnitudeExpression = new MagnitudeExpression(lhs.Unit.GetExpression(), new ConstantExpression(rhs));
            return new Quantity(
                Math.Pow(lhs.Value, rhs),
                this.unitFactory.Create(this.expressionReducer.Reduce(magnitudeExpression, true)));
        }
    }
}