// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="SolidAngle.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Spatial
{
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.UnitSelection;
    using Sundew.Quantities.Spatial.UnitSelection;

    /// <summary>
    /// Represents a amount of substance quantity.
    /// </summary>
    public sealed class SolidAngle : Quantity<SolidAngle, SolidAngleUnitSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SolidAngle" /> class.
        /// </summary>
        /// <param name="solidAngle">The solid angle.</param>
        /// <param name="solidAngleUnitSelector">The solidAngle unit selector.</param>
        public SolidAngle(double solidAngle, SelectUnit<SolidAngleUnitSelector> solidAngleUnitSelector)
            : base(solidAngle, solidAngleUnitSelector(new SolidAngleUnitSelector()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolidAngle" /> class.
        /// </summary>
        /// <param name="quantity">The quantity operation result.</param>
        public SolidAngle(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolidAngle" /> class.
        /// </summary>
        /// <param name="solidAngle">The solid angle.</param>
        /// <param name="unit">The unit.</param>
        public SolidAngle(double solidAngle, IUnit unit)
            : base(solidAngle, unit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolidAngle" /> class.
        /// </summary>
        /// <param name="solidAngle">The solid angle.</param>
        public SolidAngle(double solidAngle)
            : this(solidAngle, x => x.BaseUnit)
        {
        }

        /// <summary>
        /// Gets this instance as a <see cref="SolidAngle"/>.
        /// </summary>
        /// <value>
        /// This instance.
        /// </value>
        protected override SolidAngle Self => this;

        /// <summary>
        /// Increments the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The incremented result.</returns>
        public static SolidAngle operator ++(SolidAngle lhs)
        {
            return lhs.CreateQuantity(lhs.Value + 1, lhs.Unit);
        }

        /// <summary>
        /// Decrements the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The decremented result.</returns>
        public static SolidAngle operator --(SolidAngle lhs)
        {
            return lhs.CreateQuantity(lhs.Value - 1, lhs.Unit);
        }

        /// <summary>
        /// Creates a solid angle quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>A new <see cref="SolidAngle"/>.</returns>
        public override SolidAngle CreateQuantity(double value, IUnit unit)
        {
            return new SolidAngle(value, unit);
        }

        /// <summary>
        /// Creates the electric current unit selector.
        /// </summary>
        /// <returns>A new <see cref="SolidAngleUnitSelector"/>.</returns>
        public override SolidAngleUnitSelector CreateUnitSelector()
        {
            return new SolidAngleUnitSelector();
        }

        /// <summary>
        /// Creates a interval based on the specified min, max and unit.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The new interval.</returns>
        public static Interval<SolidAngle> Interval(
            double min,
            double max,
            SelectUnit<SolidAngleUnitSelector> unitSelector)
        {
            return new Interval<SolidAngle>(min, max, unitSelector(new SolidAngleUnitSelector()));
        }
    }
}