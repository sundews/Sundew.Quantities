namespace Sundew.Quantities.Photometry
{
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.UnitSelection;
    using Sundew.Quantities.Photometry.UnitSelection;

    /// <summary>
    /// Represents a luminous intensity quantity. 
    /// </summary>
    public sealed partial class LuminousIntensity : Quantity<LuminousIntensity, LuminousIntensityUnitSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LuminousIntensity"/> class.
        /// </summary>
        /// <param name="luminousIntensity">The luminousIntensity.</param>
        /// <param name="luminousIntensityUnitSelector">The luminousIntensity unit selector.</param>
        public LuminousIntensity(double luminousIntensity, SelectUnit<LuminousIntensityUnitSelector> luminousIntensityUnitSelector)
            : base(luminousIntensity, luminousIntensityUnitSelector(new LuminousIntensityUnitSelector()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LuminousIntensity"/> class.
        /// </summary>
        /// <param name="quantity">The quantity operation result.</param>
        public LuminousIntensity(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LuminousIntensity"/> class.
        /// </summary>
        /// <param name="luminousIntensity">The luminousIntensity.</param>
        /// <param name="luminousIntensityUnit">The luminousIntensity unit.</param>
        public LuminousIntensity(double luminousIntensity, IUnit luminousIntensityUnit)
            : base(luminousIntensity, luminousIntensityUnit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LuminousIntensity" /> class.
        /// </summary>
        /// <param name="luminousIntensity">The luminousIntensity.</param>
        public LuminousIntensity(double luminousIntensity)
            : this(luminousIntensity, units => units.BaseUnit)
        {
        }

        /// <summary>
        /// Gets this instance as a <see cref="LuminousIntensity"/>.
        /// </summary>
        /// <value>
        /// This instance.
        /// </value>
        protected override LuminousIntensity Self => this;
        
        /// <summary>
        /// Increments the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The incremented result.</returns>
        public static LuminousIntensity operator ++(LuminousIntensity lhs)
        {
            return lhs.CreateQuantity(lhs.Value + 1, lhs.Unit);
        }

        /// <summary>
        /// Decrements the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The decremented result.</returns>
        public static LuminousIntensity operator --(LuminousIntensity lhs)
        {
            return lhs.CreateQuantity(lhs.Value - 1, lhs.Unit);
        }

        /// <summary>
        /// Creates a luminous intensity quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>A <see cref="LuminousIntensity"/>.</returns>
        public override LuminousIntensity CreateQuantity(double value, IUnit unit)
        {
            return new LuminousIntensity(value, unit);
        }

        /// <summary>
        /// Creates the luminousIntensity unit selector.
        /// </summary>
        /// <returns>A <see cref="LuminousIntensityUnitSelector"/>.</returns>
        public override LuminousIntensityUnitSelector CreateUnitSelector()
        {
            return new LuminousIntensityUnitSelector();
        }

        /// <summary>
        /// Creates a interval based on the specified min, max and unit.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The new interval.</returns>
        public static Interval<LuminousIntensity> Interval(double min, double max, SelectUnit<LuminousIntensityUnitSelector> unitSelector)
        {
            return new Interval<LuminousIntensity>(min, max, unitSelector(new LuminousIntensityUnitSelector()));
        }
    }
}