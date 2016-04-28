namespace Sundew.Quantities.Spatial
{
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.UnitSelection;
    using Sundew.Quantities.Spatial.UnitSelection;

    /// <summary>
    /// Represents a volume quantity.
    /// </summary>
    public sealed partial class Volume : Quantity<Volume, VolumeUnitSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Volume"/> class.
        /// </summary>
        /// <param name="volume">The volume.</param>
        /// <param name="volumeUnitSelector">The volume unit selector.</param>
        public Volume(double volume, SelectUnit<VolumeUnitSelector> volumeUnitSelector)
            : base(volume, volumeUnitSelector(new VolumeUnitSelector()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Volume"/> class.
        /// </summary>
        /// <param name="quantity">The quantity operation result.</param>
        public Volume(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Volume"/> class.
        /// </summary>
        /// <param name="volume">The volume.</param>
        /// <param name="unit">The unit.</param>
        public Volume(double volume, IUnit unit)
            : base(volume, unit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Volume" /> class.
        /// </summary>
        /// <param name="volume">The volume.</param>
        public Volume(double volume)
            : this(volume, units => units.BaseUnit)
        {
        }

        /// <summary>
        /// Gets this instance as a <see cref="Volume"/>.
        /// </summary>
        /// <value>
        /// This instance.
        /// </value>
        protected override Volume Self => this;
        
        /// <summary>
        /// Increments the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The incremented result.</returns>
        public static Volume operator ++(Volume lhs)
        {
            return lhs.CreateQuantity(lhs.Value + 1, lhs.Unit);
        }

        /// <summary>
        /// Decrements the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The decremented result.</returns>
        public static Volume operator --(Volume lhs)
        {
            return lhs.CreateQuantity(lhs.Value - 1, lhs.Unit);
        }

        /// <summary>
        /// Creates a volume quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>A new <see cref="Volume"/>.</returns>
        public override Volume CreateQuantity(double value, IUnit unit)
        {
            return new Volume(value, unit);
        }

        /// <summary>
        /// Creates the volume unit selector.
        /// </summary>
        /// <returns>A new <see cref="VolumeUnitSelector"/>.</returns>
        public override VolumeUnitSelector CreateUnitSelector()
        {
            return new VolumeUnitSelector();
        }

        /// <summary>
        /// Creates a interval based on the specified min, max and unit.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The new interval.</returns>
        public static Interval<Volume> Interval(double min, double max, SelectUnit<VolumeUnitSelector> unitSelector)
        {
            return new Interval<Volume>(min, max, unitSelector(new VolumeUnitSelector()));
        }
    }
}