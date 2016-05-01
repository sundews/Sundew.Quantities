// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ElectricCurrent.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Electromagnetism
{
    using Sundew.Quantities.Electromagnetism.UnitSelection;
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Represents an electric current quantity.
    /// </summary>
    public sealed partial class ElectricCurrent : Quantity<ElectricCurrent, ElectricCurrentUnitSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricCurrent" /> class.
        /// </summary>
        /// <param name="electricCurrent">The electricCurrent.</param>
        /// <param name="electricCurrentUnitSelector">The ElectricCurrent unit selector.</param>
        public ElectricCurrent(
            double electricCurrent,
            SelectUnit<ElectricCurrentUnitSelector> electricCurrentUnitSelector)
            : base(electricCurrent, electricCurrentUnitSelector(new ElectricCurrentUnitSelector()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricCurrent" /> class.
        /// </summary>
        /// <param name="quantity">The quantity operation result.</param>
        public ElectricCurrent(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricCurrent" /> class.
        /// </summary>
        /// <param name="electricCurrent">The electricCurrent.</param>
        /// <param name="electricCurrentUnit">The electricCurrent unit.</param>
        public ElectricCurrent(double electricCurrent, IUnit electricCurrentUnit)
            : base(electricCurrent, electricCurrentUnit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricCurrent" /> class.
        /// </summary>
        /// <param name="electricCurrent">The electricCurrent.</param>
        public ElectricCurrent(double electricCurrent)
            : this(electricCurrent, x => x.BaseUnit)
        {
        }

        /// <summary>
        /// Gets this instance as a <see cref="ElectricCurrent"/>.
        /// </summary>
        /// <value>
        /// This instance.
        /// </value>
        protected override ElectricCurrent Self => this;

        /// <summary>
        /// Increments the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The incremented result.</returns>
        public static ElectricCurrent operator ++(ElectricCurrent lhs)
        {
            return lhs.CreateQuantity(lhs.Value + 1, lhs.Unit);
        }

        /// <summary>
        /// Decrements the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The decremented result.</returns>
        public static ElectricCurrent operator --(ElectricCurrent lhs)
        {
            return lhs.CreateQuantity(lhs.Value - 1, lhs.Unit);
        }

        /// <summary>
        /// Creates the electric current quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>A new <see cref="ElectricCurrent"/>.</returns>
        public override ElectricCurrent CreateQuantity(double value, IUnit unit)
        {
            return new ElectricCurrent(value, unit);
        }

        /// <summary>
        /// Creates the electric current unit selector.
        /// </summary>
        /// <returns>A new <see cref="ElectricCurrentUnitSelector"/>.</returns>
        public override ElectricCurrentUnitSelector CreateUnitSelector()
        {
            return new ElectricCurrentUnitSelector();
        }

        /// <summary>
        /// Creates a interval based on the specified min, max and unit.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The new interval.</returns>
        public static Interval<ElectricCurrent> Interval(
            double min,
            double max,
            SelectUnit<ElectricCurrentUnitSelector> unitSelector)
        {
            return new Interval<ElectricCurrent>(min, max, unitSelector(new ElectricCurrentUnitSelector()));
        }
    }
}