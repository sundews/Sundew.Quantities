// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Illuminance.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Photometry
{
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.UnitSelection;
    using Sundew.Quantities.Photometry.UnitSelection;

    /// <summary>
    /// Represents a luminous intensity quantity. 
    /// </summary>
    public sealed partial class Illuminance : Quantity<Illuminance, IlluminanceUnitSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Illuminance"/> class.
        /// </summary>
        /// <param name="illuminance">The illuminance.</param>
        /// <param name="illuminanceUnitSelector">The illuminance unit selector.</param>
        public Illuminance(double illuminance, SelectUnit<IlluminanceUnitSelector> illuminanceUnitSelector)
            : base(illuminance, illuminanceUnitSelector(new IlluminanceUnitSelector()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Illuminance"/> class.
        /// </summary>
        /// <param name="quantity">The quantity operation result.</param>
        public Illuminance(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Illuminance"/> class.
        /// </summary>
        /// <param name="illuminance">The illuminance.</param>
        /// <param name="illuminanceUnit">The illuminance unit.</param>
        public Illuminance(double illuminance, IUnit illuminanceUnit)
            : base(illuminance, illuminanceUnit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Illuminance" /> class.
        /// </summary>
        /// <param name="illuminance">The illuminance.</param>
        public Illuminance(double illuminance)
            : this(illuminance, units => units.BaseUnit)
        {
        }

        /// <summary>
        /// Gets this instance as a <see cref="Illuminance"/>.
        /// </summary>
        /// <value>
        /// This instance.
        /// </value>
        protected override Illuminance Self => this;

        /// <summary>
        /// Increments the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The incremented result.</returns>
        public static Illuminance operator ++(Illuminance lhs)
        {
            return lhs.CreateQuantity(lhs.Value + 1, lhs.Unit);
        }

        /// <summary>
        /// Decrements the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The decremented result.</returns>
        public static Illuminance operator --(Illuminance lhs)
        {
            return lhs.CreateQuantity(lhs.Value - 1, lhs.Unit);
        }

        /// <summary>
        /// Creates a illuminance quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>A <see cref="Illuminance"/>.</returns>
        public override Illuminance CreateQuantity(double value, IUnit unit)
        {
            return new Illuminance(value, unit);
        }

        /// <summary>
        /// Creates the illuminance unit selector.
        /// </summary>
        /// <returns>A <see cref="IlluminanceUnitSelector"/>.</returns>
        public override IlluminanceUnitSelector CreateUnitSelector()
        {
            return new IlluminanceUnitSelector();
        }

        /// <summary>
        /// Creates a interval based on the specified min, max and unit.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The new interval.</returns>
        public static Interval<Illuminance> Interval(
            double min,
            double max,
            SelectUnit<IlluminanceUnitSelector> unitSelector)
        {
            return new Interval<Illuminance>(min, max, unitSelector(new IlluminanceUnitSelector()));
        }
    }
}