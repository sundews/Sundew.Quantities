namespace Sundew.Quantities.Spatial
{
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.UnitSelection;
    using Sundew.Quantities.Spatial.UnitSelection;

    /// <summary>
    /// Implementation of the Distance base unit.
    /// </summary>
    public sealed partial class Distance : Quantity<Distance, DistanceUnitSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Distance"/> class.
        /// </summary>
        /// <param name="distance">The distance.</param>
        /// <param name="distanceUnitSelector">The distance unit selector.</param>
        public Distance(double distance, SelectUnit<DistanceUnitSelector> distanceUnitSelector)
            : base(distance, distanceUnitSelector(new DistanceUnitSelector()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Distance"/> class.
        /// </summary>
        /// <param name="quantity">The quantity operation result.</param>
        public Distance(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Distance"/> class.
        /// </summary>
        /// <param name="distance">The distance.</param>
        /// <param name="distanceUnit">The distance unit.</param>
        public Distance(double distance, IUnit distanceUnit)
            : base(distance, distanceUnit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Distance" /> class.
        /// </summary>
        /// <param name="distance">The distance.</param>
        public Distance(double distance)
            : this(distance, units => units.BaseUnit)
        {
        }

        /// <summary>
        /// Gets this instance as a <see cref="Distance"/>.
        /// </summary>
        /// <value>
        /// This instance.
        /// </value>
        protected override Distance Self => this;
        
        /// <summary>
        /// Increments the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The incremented result.</returns>
        public static Distance operator ++(Distance lhs)
        {
            return lhs.CreateQuantity(lhs.Value + 1, lhs.Unit);
        }

        /// <summary>
        /// Decrements the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The decremented result.</returns>
        public static Distance operator --(Distance lhs)
        {
            return lhs.CreateQuantity(lhs.Value - 1, lhs.Unit);
        }

        /// <summary>
        /// Creates a distance quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>A new <see cref="Distance"/>.</returns>
        public override Distance CreateQuantity(double value, IUnit unit)
        {
            return new Distance(value, unit);
        }

        /// <summary>
        /// Creates the distance unit selector.
        /// </summary>
        /// <returns>A new <see cref="DistanceUnitSelector"/>.</returns>
        public override DistanceUnitSelector CreateUnitSelector()
        {
            return new DistanceUnitSelector();
        }

        /// <summary>
        /// Creates a interval based on the specified min, max and unit.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The new interval.</returns>
        public static Interval<Distance> Interval(double min, double max, SelectUnit<DistanceUnitSelector> unitSelector)
        {
            return new Interval<Distance>(min, max, unitSelector(new DistanceUnitSelector()));
        }
    }
}