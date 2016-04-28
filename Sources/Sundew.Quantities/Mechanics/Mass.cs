namespace Sundew.Quantities.Mechanics
{
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.UnitSelection;
    using Sundew.Quantities.Mechanics.UnitSelection;

    /// <summary>
    /// Represents a mass quantity.
    /// </summary>
    public sealed partial class Mass : Quantity<Mass, MassUnitSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mass"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="massUnitSelector">The mass unit selector.</param>
        public Mass(double value, SelectUnit<MassUnitSelector> massUnitSelector)
            : base(value, massUnitSelector(new MassUnitSelector()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mass"/> class.
        /// </summary>
        /// <param name="quantity">The quantity operation result.</param>
        public Mass(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mass"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        public Mass(double value, IUnit unit)
            : base(value, unit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mass" /> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public Mass(double value)
            : this(value, units => units.BaseUnit)
        {
        }

        /// <summary>
        /// Gets this instance as a <see cref="Mass"/>.
        /// </summary>
        /// <value>
        /// This instance.
        /// </value>
        protected override Mass Self => this;
        
        /// <summary>
        /// Increments the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The incremented result.</returns>
        public static Mass operator ++(Mass lhs)
        {
            return lhs.CreateQuantity(lhs.Value + 1, lhs.Unit);
        }

        /// <summary>
        /// Decrements the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The decremented result.</returns>
        public static Mass operator --(Mass lhs)
        {
            return lhs.CreateQuantity(lhs.Value - 1, lhs.Unit);
        }

        /// <summary>
        /// Creates a mass quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>A <see cref="Mass"/>.</returns>
        public override Mass CreateQuantity(double value, IUnit unit)
        {
            return new Mass(value, unit);
        }

        /// <summary>
        /// Creates the mass unit selector.
        /// </summary>
        /// <returns>A <see cref="MassUnitSelector"/>.</returns>
        public override MassUnitSelector CreateUnitSelector()
        {
            return new MassUnitSelector();
        }

        /// <summary>
        /// Creates a interval based on the specified min, max and unit.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The new interval.</returns>
        public static Interval<Mass> Interval(double min, double max, SelectUnit<MassUnitSelector> unitSelector)
        {
            return new Interval<Mass>(min, max, unitSelector(new MassUnitSelector()));
        }
    }
}