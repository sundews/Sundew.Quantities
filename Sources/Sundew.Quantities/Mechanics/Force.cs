namespace Sundew.Quantities.Mechanics
{
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.UnitSelection;
    using Sundew.Quantities.Mechanics.UnitSelection;

    /// <summary>
    /// Represents a force quantity.
    /// </summary>
    public sealed partial class Force : Quantity<Force, ForceUnitSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Force"/> class.
        /// </summary>
        /// <param name="force">The Force.</param>
        /// <param name="forceUnitSelector">The Force unit selector.</param>
        public Force(double force, SelectUnit<ForceUnitSelector> forceUnitSelector)
            : base(force, forceUnitSelector(new ForceUnitSelector()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Force"/> class.
        /// </summary>
        /// <param name="quantity">The quantity operation result.</param>
        public Force(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Force"/> class.
        /// </summary>
        /// <param name="force">The Force.</param>
        /// <param name="forceUnit">The Force unit.</param>
        public Force(double force, IUnit forceUnit)
            : base(force, forceUnit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Force" /> class.
        /// </summary>
        /// <param name="force">The Force.</param>
        public Force(double force)
            : this(force, units => units.BaseUnit)
        {
        }

        /// <summary>
        /// Gets this instance as a <see cref="Force"/>.
        /// </summary>
        /// <value>
        /// This instance.
        /// </value>
        protected override Force Self => this;
        
        /// <summary>
        /// Increments the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The incremented result.</returns>
        public static Force operator ++(Force lhs)
        {
            return lhs.CreateQuantity(lhs.Value + 1, lhs.Unit);
        }

        /// <summary>
        /// Decrements the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The decremented result.</returns>
        public static Force operator --(Force lhs)
        {
            return lhs.CreateQuantity(lhs.Value - 1, lhs.Unit);
        }

        /// <summary>
        /// Creates a force quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>A new <see cref="Force"/>.</returns>
        public override Force CreateQuantity(double value, IUnit unit)
        {
            return new Force(value, unit);
        }

        /// <summary>
        /// Creates the force unit selector.
        /// </summary>
        /// <returns>A new <see cref="ForceUnitSelector"/>.</returns>
        public override ForceUnitSelector CreateUnitSelector()
        {
            return new ForceUnitSelector();
        }

        /// <summary>
        /// Creates a interval based on the specified min, max and unit.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The new interval.</returns>
        public static Interval<Force> Interval(double min, double max, SelectUnit<ForceUnitSelector> unitSelector)
        {
            return new Interval<Force>(min, max, unitSelector(new ForceUnitSelector()));
        }
    }
}