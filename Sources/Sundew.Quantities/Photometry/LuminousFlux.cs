// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="LuminousFlux.cs" company="Hukano">
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
    public sealed partial class LuminousFlux : Quantity<LuminousFlux, LuminousFluxUnitSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LuminousFlux"/> class.
        /// </summary>
        /// <param name="luminousFlux">The luminousFlux.</param>
        /// <param name="luminousFluxUnitSelector">The luminousFlux unit selector.</param>
        public LuminousFlux(double luminousFlux, SelectUnit<LuminousFluxUnitSelector> luminousFluxUnitSelector)
            : base(luminousFlux, luminousFluxUnitSelector(new LuminousFluxUnitSelector()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LuminousFlux"/> class.
        /// </summary>
        /// <param name="quantity">The quantity operation result.</param>
        public LuminousFlux(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LuminousFlux"/> class.
        /// </summary>
        /// <param name="luminousFlux">The luminousFlux.</param>
        /// <param name="luminousFluxUnit">The luminousFlux unit.</param>
        public LuminousFlux(double luminousFlux, IUnit luminousFluxUnit)
            : base(luminousFlux, luminousFluxUnit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LuminousFlux" /> class.
        /// </summary>
        /// <param name="luminousFlux">The luminousFlux.</param>
        public LuminousFlux(double luminousFlux)
            : this(luminousFlux, units => units.BaseUnit)
        {
        }

        /// <summary>
        /// Gets this instance as a <see cref="LuminousFlux"/>.
        /// </summary>
        /// <value>
        /// This instance.
        /// </value>
        protected override LuminousFlux Self => this;

        /// <summary>
        /// Increments the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The incremented result.</returns>
        public static LuminousFlux operator ++(LuminousFlux lhs)
        {
            return lhs.CreateQuantity(lhs.Value + 1, lhs.Unit);
        }

        /// <summary>
        /// Decrements the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The decremented result.</returns>
        public static LuminousFlux operator --(LuminousFlux lhs)
        {
            return lhs.CreateQuantity(lhs.Value - 1, lhs.Unit);
        }

        /// <summary>
        /// Creates a luminous flux quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>A <see cref="LuminousFlux"/>.</returns>
        public override LuminousFlux CreateQuantity(double value, IUnit unit)
        {
            return new LuminousFlux(value, unit);
        }

        /// <summary>
        /// Creates the luminousFlux unit selector.
        /// </summary>
        /// <returns>A <see cref="LuminousFluxUnitSelector"/>.</returns>
        public override LuminousFluxUnitSelector CreateUnitSelector()
        {
            return new LuminousFluxUnitSelector();
        }

        /// <summary>
        /// Creates a interval based on the specified min, max and unit.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The new interval.</returns>
        public static Interval<LuminousFlux> Interval(
            double min,
            double max,
            SelectUnit<LuminousFluxUnitSelector> unitSelector)
        {
            return new Interval<LuminousFlux>(min, max, unitSelector(new LuminousFluxUnitSelector()));
        }
    }
}