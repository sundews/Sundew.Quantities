namespace Sundew.Quantities.Thermodynamics
{
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.UnitSelection;
    using Sundew.Quantities.Thermodynamics.UnitSelection;

    /// <summary>
    /// Represents a temperature quantity.
    /// </summary>
    public sealed partial class Temperature : Quantity<Temperature, TemperatureUnitSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Temperature"/> class.
        /// </summary>
        /// <param name="temperature">
        /// The temperature.
        /// </param>
        /// <param name="temperatureUnitSelector">
        /// The Temperature unit selector.
        /// </param>
        public Temperature(double temperature, SelectUnit<TemperatureUnitSelector> temperatureUnitSelector)
            : base(temperature, temperatureUnitSelector(new TemperatureUnitSelector()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Temperature"/> class.
        /// </summary>
        /// <param name="quantity">
        /// The quantity operation result.
        /// </param>
        public Temperature(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Temperature"/> class.
        /// </summary>
        /// <param name="temperature">
        /// The temperature.
        /// </param>
        /// <param name="unit">
        /// The unit.
        /// </param>
        public Temperature(double temperature, IUnit unit)
            : base(temperature, unit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Temperature"/> class.
        /// </summary>
        /// <param name="temperature">
        /// The temperature.
        /// </param>
        public Temperature(double temperature)
                : this(temperature, x => x.BaseUnit)
        {
        }

        /// <summary>
        /// Gets this instance as a <see cref="Temperature"/>.
        /// </summary>
        /// <value>
        /// This instance.
        /// </value>
        protected override Temperature Self => this;

        /// <summary>
        /// Increments the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The incremented result.</returns>
        public static Temperature operator ++(Temperature lhs)
        {
            return lhs.CreateQuantity(lhs.Value + 1, lhs.Unit);
        }

        /// <summary>
        /// Decrements the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The decremented result.</returns>
        public static Temperature operator --(Temperature lhs)
        {
            return lhs.CreateQuantity(lhs.Value - 1, lhs.Unit);
        }

        /// <summary>
        /// Creates a temperature quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>A new <see cref="Temperature"/>.</returns>
        public override Temperature CreateQuantity(double value, IUnit unit)
        {
            return new Temperature(value, unit);
        }

        /// <summary>
        /// Creates the electric current unit selector.
        /// </summary>
        /// <returns>A new <see cref="TemperatureUnitSelector"/>.</returns>
        public override TemperatureUnitSelector CreateUnitSelector()
        {
            return new TemperatureUnitSelector();
        }
        
        /// <summary>
        /// Creates a interval based on the specified min, max and unit.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The new interval.</returns>
        public static Interval<Temperature> Interval(double min, double max, SelectUnit<TemperatureUnitSelector> unitSelector)
        {
            return new Interval<Temperature>(min, max, unitSelector(new TemperatureUnitSelector()));
        }
    }
}
