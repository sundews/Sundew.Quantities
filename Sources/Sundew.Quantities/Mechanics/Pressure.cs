namespace Sundew.Quantities.Mechanics
{
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.UnitSelection;
    using Sundew.Quantities.Mechanics.UnitSelection;

    /// <summary>
    /// Represents an pressure quantity.
    /// </summary>
    public sealed partial class Pressure : Quantity<Pressure, PressureUnitSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pressure" /> class.
        /// </summary>
        /// <param name="pressure">The pressure.</param>
        /// <param name="pressureUnitSelector">The Pressure unit selector.</param>
        public Pressure(double pressure, SelectUnit<PressureUnitSelector> pressureUnitSelector)
            : base(pressure, pressureUnitSelector(new PressureUnitSelector()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pressure" /> class.
        /// </summary>
        /// <param name="quantity">The quantity operation result.</param>
        public Pressure(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pressure" /> class.
        /// </summary>
        /// <param name="pressure">The pressure.</param>
        /// <param name="pressureUnit">The pressure unit.</param>
        public Pressure(double pressure, IUnit pressureUnit)
            : base(pressure, pressureUnit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pressure" /> class.
        /// </summary>
        /// <param name="pressure">The pressure.</param>
        public Pressure(double pressure)
            : this(pressure, x => x.BaseUnit)
        {
        }

        /// <summary>
        /// Gets this instance as a <see cref="Pressure"/>.
        /// </summary>
        /// <value>
        /// This instance.
        /// </value>
        protected override Pressure Self => this;
        
        /// <summary>
        /// Increments the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The incremented result.</returns>
        public static Pressure operator ++(Pressure lhs)
        {
            return lhs.CreateQuantity(lhs.Value + 1, lhs.Unit);
        }

        /// <summary>
        /// Decrements the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The decremented result.</returns>
        public static Pressure operator --(Pressure lhs)
        {
            return lhs.CreateQuantity(lhs.Value - 1, lhs.Unit);
        }

        /// <summary>
        /// Creates a pressure quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>A new <see cref="Pressure"/>.</returns>
        public override Pressure CreateQuantity(double value, IUnit unit)
        {
            return new Pressure(value, unit);
        }

        /// <summary>
        /// Creates the pressure unit selector.
        /// </summary>
        /// <returns>A new <see cref="PressureUnitSelector"/>.</returns>
        public override PressureUnitSelector CreateUnitSelector()
        {
            return new PressureUnitSelector();
        }

        /// <summary>
        /// Creates a interval based on the specified min, max and unit.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The new interval.</returns>
        public static Interval<Pressure> Interval(double min, double max, SelectUnit<PressureUnitSelector> unitSelector)
        {
            return new Interval<Pressure>(min, max, unitSelector(new PressureUnitSelector()));
        }
    }
}