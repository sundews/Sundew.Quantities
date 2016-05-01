// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Momentum.cs" company="Hukano">
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
    /// Represents an momentum quantity.
    /// </summary>
    public sealed partial class Momentum : Quantity<Momentum, MomentumUnitSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Momentum" /> class.
        /// </summary>
        /// <param name="momentum">The momentum.</param>
        /// <param name="momentumUnitSelector">The Momentum unit selector.</param>
        public Momentum(double momentum, SelectUnit<MomentumUnitSelector> momentumUnitSelector)
            : base(momentum, momentumUnitSelector(new MomentumUnitSelector()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Momentum" /> class.
        /// </summary>
        /// <param name="quantity">The quantity operation result.</param>
        public Momentum(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Momentum" /> class.
        /// </summary>
        /// <param name="momentum">The momentum.</param>
        /// <param name="momentumUnit">The momentum unit.</param>
        public Momentum(double momentum, IUnit momentumUnit)
            : base(momentum, momentumUnit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Momentum" /> class.
        /// </summary>
        /// <param name="momentum">The momentum.</param>
        public Momentum(double momentum)
            : this(momentum, x => x.BaseUnit)
        {
        }

        /// <summary>
        /// Gets this instance as a <see cref="Momentum"/>.
        /// </summary>
        /// <value>
        /// This instance.
        /// </value>
        protected override Momentum Self => this;

        /// <summary>
        /// Increments the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The incremented result.</returns>
        public static Momentum operator ++(Momentum lhs)
        {
            return lhs.CreateQuantity(lhs.Value + 1, lhs.Unit);
        }

        /// <summary>
        /// Decrements the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The decremented result.</returns>
        public static Momentum operator --(Momentum lhs)
        {
            return lhs.CreateQuantity(lhs.Value - 1, lhs.Unit);
        }

        /// <summary>
        /// Creates a momentum quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>A new <see cref="Momentum"/>.</returns>
        public override Momentum CreateQuantity(double value, IUnit unit)
        {
            return new Momentum(value, unit);
        }

        /// <summary>
        /// Creates the momentum unit selector.
        /// </summary>
        /// <returns>A new <see cref="MomentumUnitSelector"/>.</returns>
        public override MomentumUnitSelector CreateUnitSelector()
        {
            return new MomentumUnitSelector();
        }

        /// <summary>
        /// Creates a interval based on the specified min, max and unit.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The new interval.</returns>
        public static Interval<Momentum> Interval(double min, double max, SelectUnit<MomentumUnitSelector> unitSelector)
        {
            return new Interval<Momentum>(min, max, unitSelector(new MomentumUnitSelector()));
        }
    }
}