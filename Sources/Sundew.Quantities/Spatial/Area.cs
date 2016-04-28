namespace Sundew.Quantities.Spatial
{
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.UnitSelection;
    using Sundew.Quantities.Spatial.UnitSelection;

    /// <summary>
    /// Represents an area quantity.
    /// </summary>
    public sealed partial class Area : Quantity<Area, DistanceUnitSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Area"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="areaUnitSelector">The area unit selector.</param>
        public Area(double value, SelectUnit<DistanceUnitSelector> areaUnitSelector)
            : base(value, areaUnitSelector(new DistanceUnitSelector()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Area"/> class.
        /// </summary>
        /// <param name="quantity">The quantity operation result.</param>
        public Area(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Area"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="areaUnit">The area unit.</param>
        public Area(double value, IUnit areaUnit)
            : base(value, areaUnit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Area" /> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public Area(double value)
            : this(value, units => units.BaseUnit)
        {
        }

        /// <summary>
        /// Gets this instance as a <see cref="Area"/>.
        /// </summary>
        /// <value>
        /// This instance.
        /// </value>
        protected override Area Self => this;
        
        /// <summary>
        /// Increments the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The incremented result.</returns>
        public static Area operator ++(Area lhs)
        {
            return lhs.CreateQuantity(lhs.Value + 1, lhs.Unit);
        }

        /// <summary>
        /// Decrements the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The decremented result.</returns>
        public static Area operator --(Area lhs)
        {
            return lhs.CreateQuantity(lhs.Value - 1, lhs.Unit);
        }

        /// <summary>
        /// Creates an area quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>An <see cref="Area"/>.</returns>
        public override Area CreateQuantity(double value, IUnit unit)
        {
            return new Area(value, unit);
        }

        /// <summary>
        /// Creates the area unit selector.
        /// </summary>
        /// <returns>An <see cref="DistanceUnitSelector"/>.</returns>
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
        public static Interval<Area> Interval(double min, double max, SelectUnit<DistanceUnitSelector> unitSelector)
        {
            return new Interval<Area>(min, max, unitSelector(new DistanceUnitSelector()));
        }
    }
}