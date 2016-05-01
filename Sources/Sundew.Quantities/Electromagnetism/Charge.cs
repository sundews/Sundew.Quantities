// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Charge.cs" company="Hukano">
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
    /// Represents a charge quantity.
    /// </summary>
    public sealed partial class Charge : Quantity<Charge, ChargeUnitSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Charge" /> class.
        /// </summary>
        /// <param name="charge">The charge.</param>
        /// <param name="chargeUnitSelector">The Charge unit selector.</param>
        public Charge(double charge, SelectUnit<ChargeUnitSelector> chargeUnitSelector)
            : base(charge, chargeUnitSelector(new ChargeUnitSelector()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Charge"/> class.
        /// </summary>
        /// <param name="quantity">The quantity operation result.</param>
        public Charge(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Charge" /> class.
        /// </summary>
        /// <param name="charge">The charge.</param>
        /// <param name="chargeUnit">The charge unit.</param>
        public Charge(double charge, IUnit chargeUnit)
            : base(charge, chargeUnit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Charge" /> class.
        /// </summary>
        /// <param name="charge">The charge.</param>
        public Charge(double charge)
            : this(charge, x => x.BaseUnit)
        {
        }

        /// <summary>
        /// Gets this instance as a <see cref="Charge"/>.
        /// </summary>
        /// <value>
        /// This instance.
        /// </value>
        protected override Charge Self => this;

        /// <summary>
        /// Increments the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The incremented result.</returns>
        public static Charge operator ++(Charge lhs)
        {
            return lhs.CreateQuantity(lhs.Value + 1, lhs.Unit);
        }

        /// <summary>
        /// Decrements the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The decremented result.</returns>
        public static Charge operator --(Charge lhs)
        {
            return lhs.CreateQuantity(lhs.Value - 1, lhs.Unit);
        }

        /// <summary>
        /// Creates the charge quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>A new <see cref="Charge"/>.</returns>
        public override Charge CreateQuantity(double value, IUnit unit)
        {
            return new Charge(value, unit);
        }

        /// <summary>
        /// Creates the charge unit selector.
        /// </summary>
        /// <returns>A new <see cref="ChargeUnitSelector"/>.</returns>
        public override ChargeUnitSelector CreateUnitSelector()
        {
            return new ChargeUnitSelector();
        }

        /// <summary>
        /// Creates a interval based on the specified min, max and unit.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The new interval.</returns>
        public static Interval<Charge> Interval(double min, double max, SelectUnit<ChargeUnitSelector> unitSelector)
        {
            return new Interval<Charge>(min, max, unitSelector(new ChargeUnitSelector()));
        }
    }
}