namespace Sundew.Quantities.Engine.Quantities
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Abstract base class for implementing quantities.
    /// </summary>
    /// <typeparam name="TQuantity">The type of the quantity.</typeparam>
    /// <typeparam name="TUnitSelector">The type of the unit selector.</typeparam>
    public abstract class Quantity<TQuantity, TUnitSelector> : Quantity<TQuantity>,
        IUnitConvertible<TQuantity, TUnitSelector>
        where TQuantity : class, IQuantity<TQuantity>, IDeferredQuantity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Quantity{TQuantity, TUnitSelector}" /> class.
        /// </summary>
        /// <param name="quantity">The quantity operation result.</param>
        protected Quantity(IQuantity quantity)
            : base(quantity.Value, quantity.Unit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Quantity{TQuantity, TUnitSelector}"/> class.
        /// </summary>
        /// <param name="value">The quantity value.</param>
        /// <param name="unit">The quantity unit.</param>
        protected Quantity(double value, IUnit unit)
            : base(value, unit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Quantity{TQuantity, TUnitSelector}" /> class.
        /// </summary>
        /// <param name="value">The quantity value.</param>
        /// <param name="expression">The expression.</param>
        protected Quantity(double value, Expression expression)
            : base(value, UnitBuilder.BuildUnit(expression))
        {
        }

        /// <summary>
        /// Checks if the specified LHS is greater than or equal to the RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>A value indicating whether the lhs is greater than or equal to the rhs.</returns>
        public static Squared<TQuantity> operator *(Quantity<TQuantity, TUnitSelector> lhs, Quantity<TQuantity, TUnitSelector> rhs)
        {
            return new Squared<TQuantity>(lhs.CreateQuantity(QuantityOperations.Multiply(lhs, rhs).Value, lhs.Unit));
        }

        /// <summary>
        /// Converts this object to a <see cref="TQuantity"/> using the unit specified by the <see cref="TUnitSelector"/>.
        /// </summary>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The converted <see cref="TQuantity"/>.</returns>
        public TQuantity ToUnit(SelectUnit<TUnitSelector> unitSelector)
        {
            return this.ToUnit(unitSelector(this.CreateUnitSelector()));
        }
        
        /// <summary>
        /// Converts this object to a <see cref="double"/> using the unit specified by the <see cref="TUnitSelector"/>.
        /// </summary>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The converted <see cref="double"/>.</returns>
        public double ToDouble(SelectUnit<TUnitSelector> unitSelector)
        {
            return this.ToDouble(unitSelector(this.CreateUnitSelector()));
        }

        /// <summary>
        /// Creates a new unit selector.
        /// </summary>
        /// <returns>A new <see cref="TUnitSelector"/>.</returns>
        public abstract TUnitSelector CreateUnitSelector();
    }
}