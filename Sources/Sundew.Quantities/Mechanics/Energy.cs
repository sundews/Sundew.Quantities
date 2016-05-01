// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Energy.cs" company="Hukano">
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
    /// Represents an energy quantity.
    /// </summary>
    public sealed partial class Energy : Quantity<Energy, EnergyUnitSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Energy" /> class.
        /// </summary>
        /// <param name="energy">The energy.</param>
        /// <param name="energyUnitSelector">The Energy unit selector.</param>
        public Energy(double energy, SelectUnit<EnergyUnitSelector> energyUnitSelector)
            : base(energy, energyUnitSelector(new EnergyUnitSelector()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Energy" /> class.
        /// </summary>
        /// <param name="quantity">The quantity operation result.</param>
        public Energy(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Energy" /> class.
        /// </summary>
        /// <param name="energy">The energy.</param>
        /// <param name="energyUnit">The energy unit.</param>
        public Energy(double energy, IUnit energyUnit)
            : base(energy, energyUnit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Energy" /> class.
        /// </summary>
        /// <param name="energy">The energy.</param>
        public Energy(double energy)
            : this(energy, x => x.BaseUnit)
        {
        }

        /// <summary>
        /// Gets this instance as a <see cref="Energy"/>.
        /// </summary>
        /// <value>
        /// This instance.
        /// </value>
        protected override Energy Self => this;

        /// <summary>
        /// Increments the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The incremented result.</returns>
        public static Energy operator ++(Energy lhs)
        {
            return lhs.CreateQuantity(lhs.Value + 1, lhs.Unit);
        }

        /// <summary>
        /// Decrements the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The decremented result.</returns>
        public static Energy operator --(Energy lhs)
        {
            return lhs.CreateQuantity(lhs.Value - 1, lhs.Unit);
        }

        /// <summary>
        /// Creates a energy quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>A new <see cref="Energy"/>.</returns>
        public override Energy CreateQuantity(double value, IUnit unit)
        {
            return new Energy(value, unit);
        }

        /// <summary>
        /// Creates the energy unit selector.
        /// </summary>
        /// <returns>A new <see cref="EnergyUnitSelector"/>.</returns>
        public override EnergyUnitSelector CreateUnitSelector()
        {
            return new EnergyUnitSelector();
        }

        /// <summary>
        /// Creates a interval based on the specified min, max and unit.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The new interval.</returns>
        public static Interval<Energy> Interval(double min, double max, SelectUnit<EnergyUnitSelector> unitSelector)
        {
            return new Interval<Energy>(min, max, unitSelector(new EnergyUnitSelector()));
        }
    }
}