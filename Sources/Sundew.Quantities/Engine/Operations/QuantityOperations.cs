namespace Sundew.Quantities.Engine.Operations
{
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Engine.Representations.Evaluation;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Visitors;

    /// <summary>
    /// Contains operations for <see cref="IQuantity{IQuantity}"/> instances.
    /// </summary>
    public class QuantityOperations : IQuantityOperations
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuantityOperations"/> class.
        /// </summary>
        /// <param name="unitFactory">The unit factory.</param>
        /// <param name="expressionReducer">The expression reducer.</param>
        /// <param name="valueFromBaseVisitor">From base visitor.</param>
        /// <param name="valueToBaseVisitor">To base visitor.</param>
        public QuantityOperations(IUnitFactory unitFactory, IExpressionReducer expressionReducer, ValueFromBaseVisitor valueFromBaseVisitor, ValueToBaseVisitor valueToBaseVisitor)
        {
            this.Addition = new AdditionOperation(valueFromBaseVisitor, valueToBaseVisitor);
            this.Subtraction = new SubtractionOperation(valueFromBaseVisitor, valueToBaseVisitor);
            this.Multiplication = new ReducingOperation(unitFactory, new UnitMultiplicationOperation(expressionReducer), new MultiplicationOperation());
            this.Division = new ReducingOperation(unitFactory, new UnitDivisionOperation(expressionReducer), new DivisionOperation());
            this.Exponentiation = new ExponentiationOperation(unitFactory, expressionReducer);
            this.NthRoot = new NthRootOperation(unitFactory, expressionReducer);
            this.ConvertToUnit = new ConvertToUnitOperation();
        }

        /// <summary>
        /// Gets the addition operation.
        /// </summary>
        /// <value>
        /// The addition operation.
        /// </value>
        public IQuantityOperation<IQuantity> Addition { get; }

        /// <summary>
        /// Gets the subtraction operation.
        /// </summary>
        /// <value>
        /// The subtraction operation.
        /// </value>
        public IQuantityOperation<IQuantity> Subtraction { get; }

        /// <summary>
        /// Gets the multiplication operation.
        /// </summary>
        /// <value>
        /// The multiplication operation.
        /// </value>
        public IQuantityOperation<IQuantity> Multiplication { get; }

        /// <summary>
        /// Gets the division.
        /// </summary>
        /// <value>
        /// The division.
        /// </value>
        public IQuantityOperation<IQuantity> Division { get; }

        /// <summary>
        /// Gets the exponentiation operation.
        /// </summary>
        /// <value>
        /// The exponentiation operation.
        /// </value>
        public IQuantityOperation<double> Exponentiation { get; }

        /// <summary>
        /// Gets the NTH root.
        /// </summary>
        /// <value>
        /// The NTH root.
        /// </value>
        public IQuantityOperation<double> NthRoot { get; }

        /// <summary>
        /// Gets the convert to unit operation.
        /// </summary>
        /// <value>
        /// The convert to unit operation.
        /// </value>
        public IQuantityAndUnitOperation ConvertToUnit { get; }
    }
}