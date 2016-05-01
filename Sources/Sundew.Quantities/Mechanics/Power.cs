// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Power.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Mechanics
{
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.UnitSelection;
    using Sundew.Quantities.Mechanics.UnitSelection;

    /// <summary>
    /// Represents a power quantity.
    /// </summary>
    public sealed partial class Power : Quantity<Power, PowerUnitSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Power"/> class.
        /// </summary>
        /// <param name="power">The Power.</param>
        /// <param name="powerUnitSelector">The Power unit selector.</param>
        public Power(double power, SelectUnit<PowerUnitSelector> powerUnitSelector)
            : base(power, powerUnitSelector(new PowerUnitSelector()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Power" /> class.
        /// </summary>
        /// <param name="quantity">The quantity operation result.</param>
        public Power(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Power"/> class.
        /// </summary>
        /// <param name="power">The Power.</param>
        /// <param name="powerUnit">The Power unit.</param>
        public Power(double power, IUnit powerUnit)
            : base(power, powerUnit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Power" /> class.
        /// </summary>
        /// <param name="power">The Power.</param>
        public Power(double power)
            : this(power, units => units.BaseUnit)
        {
        }

        /// <summary>
        /// Gets this instance as a <see cref="Power"/>.
        /// </summary>
        /// <value>
        /// This instance.
        /// </value>
        protected override Power Self => this;

        /// <summary>
        /// Increments the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The incremented result.</returns>
        public static Power operator ++(Power lhs)
        {
            return lhs.CreateQuantity(lhs.Value + 1, lhs.Unit);
        }

        /// <summary>
        /// Decrements the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The decremented result.</returns>
        public static Power operator --(Power lhs)
        {
            return lhs.CreateQuantity(lhs.Value - 1, lhs.Unit);
        }

        /// <summary>
        /// Creates the power quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>A new <see cref="Power"/>.</returns>
        public override Power CreateQuantity(double value, IUnit unit)
        {
            return new Power(value, unit);
        }

        /// <summary>
        /// Creates the power unit selector.
        /// </summary>
        /// <returns>A new <see cref="PowerUnitSelector"/>.</returns>
        public override PowerUnitSelector CreateUnitSelector()
        {
            return new PowerUnitSelector();
        }

        /// <summary>
        /// Creates a interval based on the specified min, max and unit.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The new interval.</returns>
        public static Interval<Power> Interval(double min, double max, SelectUnit<PowerUnitSelector> unitSelector)
        {
            return new Interval<Power>(min, max, unitSelector(new PowerUnitSelector()));
        }
    }
}