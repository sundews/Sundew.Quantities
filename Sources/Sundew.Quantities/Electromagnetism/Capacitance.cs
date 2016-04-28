namespace Sundew.Quantities.Electromagnetism
{
    using Sundew.Quantities.Electromagnetism.UnitSelection;
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Represents a capacitance quantity.
    /// </summary>
    public sealed partial class Capacitance : Quantity<Capacitance, CapacitanceUnitSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Capacitance" /> class.
        /// </summary>
        /// <param name="capacitance">The capacitance.</param>
        /// <param name="capacitanceUnitSelector">The Capacitance unit selector.</param>
        public Capacitance(double capacitance, SelectUnit<CapacitanceUnitSelector> capacitanceUnitSelector)
            : base(capacitance, capacitanceUnitSelector(new CapacitanceUnitSelector()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Capacitance" /> class.
        /// </summary>
        /// <param name="quantity">The quantity operation result.</param>
        public Capacitance(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Capacitance" /> class.
        /// </summary>
        /// <param name="capacitance">The capacitance.</param>
        /// <param name="unit">The unit.</param>
        public Capacitance(double capacitance, IUnit unit)
            : base(capacitance, unit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Capacitance" /> class.
        /// </summary>
        /// <param name="capacitance">The capacitance.</param>
        public Capacitance(double capacitance)
            : this(capacitance, x => x.BaseUnit)
        {
        }

        /// <summary>
        /// Gets this instance as <see cref="Capacitance"/>.
        /// </summary>
        /// <value>
        /// This instance.
        /// </value>
        protected override Capacitance Self => this;
        
        /// <summary>
        /// Increments the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The incremented result.</returns>
        public static Capacitance operator ++(Capacitance lhs)
        {
            return lhs.CreateQuantity(lhs.Value + 1, lhs.Unit);
        }

        /// <summary>
        /// Decrements the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The decremented result.</returns>
        public static Capacitance operator --(Capacitance lhs)
        {
            return lhs.CreateQuantity(lhs.Value - 1, lhs.Unit);
        }

        /// <summary>
        /// Creates the capacitance quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>A new <see cref="Capacitance"/>.</returns>
        public override Capacitance CreateQuantity(double value, IUnit unit)
        {
            return new Capacitance(value, unit);
        }

        /// <summary>
        /// Creates the capacitance unit selector.
        /// </summary>
        /// <returns>A new <see cref="CapacitanceUnitSelector"/>.</returns>
        public override CapacitanceUnitSelector CreateUnitSelector()
        {
            return new CapacitanceUnitSelector();
        }

        /// <summary>
        /// Creates a interval based on the specified min, max and unit.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The new interval.</returns>
        public static Interval<Capacitance> Interval(double min, double max, SelectUnit<CapacitanceUnitSelector> unitSelector)
        {
            return new Interval<Capacitance>(min, max, unitSelector(new CapacitanceUnitSelector()));
        }
    }
}
