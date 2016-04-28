namespace Sundew.Quantities.Electromagnetism
{
    using Sundew.Quantities.Electromagnetism.UnitSelection;
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Represents a inductance quantity.
    /// </summary>
    public sealed partial class Inductance : Quantity<Inductance, InductanceUnitSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Inductance" /> class.
        /// </summary>
        /// <param name="inductance">The inductance.</param>
        /// <param name="inductanceUnitSelector">The Inductance unit selector.</param>
        public Inductance(double inductance, SelectUnit<InductanceUnitSelector> inductanceUnitSelector)
            : base(inductance, inductanceUnitSelector(new InductanceUnitSelector()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Inductance" /> class.
        /// </summary>
        /// <param name="quantity">The quantity operation result.</param>
        public Inductance(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Inductance" /> class.
        /// </summary>
        /// <param name="inductance">The inductance.</param>
        /// <param name="unit">The unit.</param>
        public Inductance(double inductance, IUnit unit)
            : base(inductance, unit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Inductance" /> class.
        /// </summary>
        /// <param name="inductance">The inductance.</param>
        public Inductance(double inductance)
                : this(inductance, x => x.BaseUnit)
        {
        }

        /// <summary>
        /// Gets this instance as a <see cref="Inductance"/>.
        /// </summary>
        /// <value>
        /// This instance.
        /// </value>
        protected override Inductance Self => this;
        
        /// <summary>
        /// Increments the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The incremented result.</returns>
        public static Inductance operator ++(Inductance lhs)
        {
            return lhs.CreateQuantity(lhs.Value + 1, lhs.Unit);
        }

        /// <summary>
        /// Decrements the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The decremented result.</returns>
        public static Inductance operator --(Inductance lhs)
        {
            return lhs.CreateQuantity(lhs.Value - 1, lhs.Unit);
        }

        /// <summary>
        /// Creates the inductance quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>A new <see cref="Inductance"/>.</returns>
        public override Inductance CreateQuantity(double value, IUnit unit)
        {
            return new Inductance(value, unit);
        }

        /// <summary>
        /// Creates the electric current unit selector.
        /// </summary>
        /// <returns>A new <see cref="InductanceUnitSelector"/>.</returns>
        public override InductanceUnitSelector CreateUnitSelector()
        {
            return new InductanceUnitSelector();
        }

        /// <summary>
        /// Creates a interval based on the specified min, max and unit.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The new interval.</returns>
        public static Interval<Inductance> Interval(double min, double max, SelectUnit<InductanceUnitSelector> unitSelector)
        {
            return new Interval<Inductance>(min, max, unitSelector(new InductanceUnitSelector()));
        }
    }
}
