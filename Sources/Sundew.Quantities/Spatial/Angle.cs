namespace Sundew.Quantities.Spatial
{
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.UnitSelection;
    using Sundew.Quantities.Spatial.UnitSelection;

    /// <summary>
    /// Represents a amount of substance quantity.
    /// </summary>
    public sealed class Angle : Quantity<Angle, AngleUnitSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Angle" /> class.
        /// </summary>
        /// <param name="angle">The angle.</param>
        /// <param name="angleUnitSelector">The Angle unit selector.</param>
        public Angle(double angle, SelectUnit<AngleUnitSelector> angleUnitSelector)
            : base(angle, angleUnitSelector(new AngleUnitSelector()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Angle" /> class.
        /// </summary>
        /// <param name="quantity">The quantity operation result.</param>
        public Angle(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Angle" /> class.
        /// </summary>
        /// <param name="angle">The angle.</param>
        /// <param name="unit">The unit.</param>
        public Angle(double angle, IUnit unit)
            : base(angle, unit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Angle" /> class.
        /// </summary>
        /// <param name="angle">The angle.</param>
        public Angle(double angle)
                : this(angle, x => x.BaseUnit)
        {
        }

        /// <summary>
        /// Gets this instance as a <see cref="Angle"/>.
        /// </summary>
        /// <value>
        /// This instance.
        /// </value>
        protected override Angle Self => this;
        
        /// <summary>
        /// Increments the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The incremented result.</returns>
        public static Angle operator ++(Angle lhs)
        {
            return lhs.CreateQuantity(lhs.Value + 1, lhs.Unit);
        }

        /// <summary>
        /// Decrements the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The decremented result.</returns>
        public static Angle operator --(Angle lhs)
        {
            return lhs.CreateQuantity(lhs.Value - 1, lhs.Unit);
        }

        /// <summary>
        /// Creates an angle quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>A new <see cref="Angle"/>.</returns>
        public override Angle CreateQuantity(double value, IUnit unit)
        {
            return new Angle(value, unit);
        }

        /// <summary>
        /// Creates the electric current unit selector.
        /// </summary>
        /// <returns>A new <see cref="AngleUnitSelector"/>.</returns>
        public override AngleUnitSelector CreateUnitSelector()
        {
            return new AngleUnitSelector();
        }

        /// <summary>
        /// Creates a interval based on the specified min, max and unit.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The new interval.</returns>
        public static Interval<Angle> Interval(double min, double max, SelectUnit<AngleUnitSelector> unitSelector)
        {
            return new Interval<Angle>(min, max, unitSelector(new AngleUnitSelector()));
        }
    }
}
