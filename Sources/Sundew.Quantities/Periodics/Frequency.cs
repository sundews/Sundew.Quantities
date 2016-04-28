namespace Sundew.Quantities.Periodics
{
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.UnitSelection;
    using Sundew.Quantities.Periodics.UnitSelection;

    /// <summary>
    /// Represents a frequency quantity.
    /// </summary>
    public sealed partial class Frequency : Quantity<Frequency, FrequencyUnitSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Frequency" /> class.
        /// </summary>
        /// <param name="frequency">The acceleration.</param>
        /// <param name="frequencyUnitSelector">The frequency unit selector.</param>
        public Frequency(double frequency, SelectUnit<FrequencyUnitSelector> frequencyUnitSelector)
            : base(frequency, frequencyUnitSelector(new FrequencyUnitSelector()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Frequency"/> class.
        /// </summary>
        /// <param name="quantity">The quantity operation result.</param>
        public Frequency(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Frequency"/> class.
        /// </summary>
        /// <param name="frequency">The frequency.</param>
        /// <param name="frequencyUnit">The frequency unit.</param>
        public Frequency(double frequency, IUnit frequencyUnit)
            : base(frequency, frequencyUnit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Frequency" /> class.
        /// </summary>
        /// <param name="frequency">The frequency.</param>
        public Frequency(double frequency)
            : this(frequency, units => units.BaseUnit)
        {
        }

        /// <summary>
        /// Gets this instance as a <see cref="Frequency"/>.
        /// </summary>
        /// <value>
        /// This instance.
        /// </value>
        protected override Frequency Self => this;
        
        /// <summary>
        /// Increments the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The incremented result.</returns>
        public static Frequency operator ++(Frequency lhs)
        {
            return lhs.CreateQuantity(lhs.Value + 1, lhs.Unit);
        }

        /// <summary>
        /// Decrements the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The decremented result.</returns>
        public static Frequency operator --(Frequency lhs)
        {
            return lhs.CreateQuantity(lhs.Value - 1, lhs.Unit);
        }

        /// <summary>
        /// Creates a frequency quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>
        /// A new <see cref="Frequency"/>.
        /// </returns>
        public override Frequency CreateQuantity(double value, IUnit unit)
        {
            return new Frequency(value, unit);
        }

        /// <summary>
        /// Creates a new unit selector.
        /// </summary>
        /// <returns>
        /// A new <see cref="FrequencyUnitSelector"/>.
        /// </returns>
        public override FrequencyUnitSelector CreateUnitSelector()
        {
            return new FrequencyUnitSelector();
        }

        /// <summary>
        /// Creates a interval based on the specified min, max and unit.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The new interval.</returns>
        public static Interval<Frequency> Interval(double min, double max, SelectUnit<FrequencyUnitSelector> unitSelector)
        {
            return new Interval<Frequency>(min, max, unitSelector(new FrequencyUnitSelector()));
        }
    }
}