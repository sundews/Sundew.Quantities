// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Resistance.cs" company="Hukano">
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
    /// Represents a resistance quantity.
    /// </summary>
    public sealed partial class Resistance : Quantity<Resistance, ResistanceUnitSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Resistance" /> class.
        /// </summary>
        /// <param name="resistance">The resistance.</param>
        /// <param name="resistanceUnitSelector">The Resistance unit selector.</param>
        public Resistance(double resistance, SelectUnit<ResistanceUnitSelector> resistanceUnitSelector)
            : base(resistance, resistanceUnitSelector(new ResistanceUnitSelector()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Resistance"/> class.
        /// </summary>
        /// <param name="quantity">The quantity operation result.</param>
        public Resistance(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Resistance" /> class.
        /// </summary>
        /// <param name="resistance">The resistance.</param>
        /// <param name="resistanceUnit">The resistance unit.</param>
        public Resistance(double resistance, IUnit resistanceUnit)
            : base(resistance, resistanceUnit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Resistance" /> class.
        /// </summary>
        /// <param name="resistance">The resistance.</param>
        public Resistance(double resistance)
            : this(resistance, units => units.BaseUnit)
        {
        }

        /// <summary>
        /// Gets this instance as a <see cref="Resistance"/>.
        /// </summary>
        /// <value>
        /// This instance.
        /// </value>
        protected override Resistance Self => this;

        /// <summary>
        /// Increments the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The incremented result.</returns>
        public static Resistance operator ++(Resistance lhs)
        {
            return lhs.CreateQuantity(lhs.Value + 1, lhs.Unit);
        }

        /// <summary>
        /// Decrements the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The decremented result.</returns>
        public static Resistance operator --(Resistance lhs)
        {
            return lhs.CreateQuantity(lhs.Value - 1, lhs.Unit);
        }

        /// <summary>
        /// Creates the resistance quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>A new <see cref="Resistance"/>.</returns>
        public override Resistance CreateQuantity(double value, IUnit unit)
        {
            return new Resistance(value, unit);
        }

        /// <summary>
        /// Creates the electric current unit selector.
        /// </summary>
        /// <returns>A new <see cref="ResistanceUnitSelector"/>.</returns>
        public override ResistanceUnitSelector CreateUnitSelector()
        {
            return new ResistanceUnitSelector();
        }

        /// <summary>
        /// Creates a interval based on the specified min, max and unit.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The new interval.</returns>
        public static Interval<Resistance> Interval(
            double min,
            double max,
            SelectUnit<ResistanceUnitSelector> unitSelector)
        {
            return new Interval<Resistance>(min, max, unitSelector(new ResistanceUnitSelector()));
        }
    }
}