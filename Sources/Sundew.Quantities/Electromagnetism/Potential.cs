// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Potential.cs" company="Hukano">
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
    /// Represents a potential quantity.
    /// </summary>
    public sealed partial class Potential : Quantity<Potential, PotentialUnitSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Potential"/> class.
        /// </summary>
        /// <param name="potential">The potential.</param>
        /// <param name="potentialUnitSelector">The potential unit selector.</param>
        public Potential(double potential, SelectUnit<PotentialUnitSelector> potentialUnitSelector)
            : base(potential, potentialUnitSelector(new PotentialUnitSelector()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Potential"/> class.
        /// </summary>
        /// <param name="quantity">The quantity operation result.</param>
        public Potential(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Potential"/> class.
        /// </summary>
        /// <param name="potential">The potential.</param>
        /// <param name="potentialUnit">The potential unit.</param>
        public Potential(double potential, IUnit potentialUnit)
            : base(potential, potentialUnit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Potential" /> class.
        /// </summary>
        /// <param name="potential">The potential.</param>
        public Potential(double potential)
            : this(potential, units => units.BaseUnit)
        {
        }

        /// <summary>
        /// Gets this instance as a <see cref="Potential"/>.
        /// </summary>
        /// <value>
        /// This instance.
        /// </value>
        protected override Potential Self => this;

        /// <summary>
        /// Increments the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The incremented result.</returns>
        public static Potential operator ++(Potential lhs)
        {
            return lhs.CreateQuantity(lhs.Value + 1, lhs.Unit);
        }

        /// <summary>
        /// Decrements the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The decremented result.</returns>
        public static Potential operator --(Potential lhs)
        {
            return lhs.CreateQuantity(lhs.Value - 1, lhs.Unit);
        }

        /// <summary>
        /// Creates the potential quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>A new <see cref="Potential"/>.</returns>
        public override Potential CreateQuantity(double value, IUnit unit)
        {
            return new Potential(value, unit);
        }

        /// <summary>
        /// Creates the potential unit selector.
        /// </summary>
        /// <returns>A new <see cref="PotentialUnitSelector"/>.</returns>
        public override PotentialUnitSelector CreateUnitSelector()
        {
            return new PotentialUnitSelector();
        }

        /// <summary>
        /// Creates a interval based on the specified min, max and unit.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The new interval.</returns>
        public static Interval<Potential> Interval(
            double min,
            double max,
            SelectUnit<PotentialUnitSelector> unitSelector)
        {
            return new Interval<Potential>(min, max, unitSelector(new PotentialUnitSelector()));
        }
    }
}