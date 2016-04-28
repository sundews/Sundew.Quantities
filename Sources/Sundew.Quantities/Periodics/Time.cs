namespace Sundew.Quantities.Periodics
{
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.UnitSelection;
    using Sundew.Quantities.Periodics.UnitSelection;

    /// <summary>
    /// Represents a time quantity. 
    /// </summary>
    public sealed partial class Time : Quantity<Time, TimeUnitSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Time"/> class.
        /// </summary>
        /// <param name="time">The time.</param>
        /// <param name="timeUnitSelector">The time unit selector.</param>
        public Time(double time, SelectUnit<TimeUnitSelector> timeUnitSelector)
            : base(time, timeUnitSelector(new TimeUnitSelector()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Time"/> class.
        /// </summary>
        /// <param name="quantity">The quantity operation result.</param>
        public Time(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Time"/> class.
        /// </summary>
        /// <param name="time">The time.</param>
        /// <param name="timeUnit">The time unit.</param>
        public Time(double time, IUnit timeUnit)
            : base(time, timeUnit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Time" /> class.
        /// </summary>
        /// <param name="time">The time.</param>
        public Time(double time)
            : this(time, units => units.BaseUnit)
        {
        }

        /// <summary>
        /// Gets this instance as a <see cref="Time"/>.
        /// </summary>
        /// <value>
        /// This instance.
        /// </value>
        protected override Time Self => this;
        
        /// <summary>
        /// Increments the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The incremented result.</returns>
        public static Time operator ++(Time lhs)
        {
            return lhs.CreateQuantity(lhs.Value + 1, lhs.Unit);
        }

        /// <summary>
        /// Decrements the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The decremented result.</returns>
        public static Time operator --(Time lhs)
        {
            return lhs.CreateQuantity(lhs.Value - 1, lhs.Unit);
        }

        /// <summary>
        /// Creates a time quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>A <see cref="Time"/>.</returns>
        public override Time CreateQuantity(double value, IUnit unit)
        {
            return new Time(value, unit);
        }

        /// <summary>
        /// Creates the time unit selector.
        /// </summary>
        /// <returns>A <see cref="TimeUnitSelector"/>.</returns>
        public override TimeUnitSelector CreateUnitSelector()
        {
            return new TimeUnitSelector();
        }

        /// <summary>
        /// Creates a interval based on the specified min, max and unit.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The new interval.</returns>
        public static Interval<Time> Interval(double min, double max, SelectUnit<TimeUnitSelector> unitSelector)
        {
            return new Interval<Time>(min, max, unitSelector(new TimeUnitSelector()));
        }
    }
}