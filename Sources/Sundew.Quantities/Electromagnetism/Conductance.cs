// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Conductance.cs" company="Hukano">
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
    /// Represents a conductance quantity.
    /// </summary>
    public sealed partial class Conductance : Quantity<Conductance, ConductanceUnitSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Conductance" /> class.
        /// </summary>
        /// <param name="conductance">The conductance.</param>
        /// <param name="conductanceUnitSelector">The Conductance unit selector.</param>
        public Conductance(double conductance, SelectUnit<ConductanceUnitSelector> conductanceUnitSelector)
            : base(conductance, conductanceUnitSelector(new ConductanceUnitSelector()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Conductance" /> class.
        /// </summary>
        /// <param name="quantity">The quantity operation result.</param>
        public Conductance(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Conductance" /> class.
        /// </summary>
        /// <param name="conductance">The conductance.</param>
        /// <param name="unit">The unit.</param>
        public Conductance(double conductance, IUnit unit)
            : base(conductance, unit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Conductance" /> class.
        /// </summary>
        /// <param name="conductance">The conductance.</param>
        public Conductance(double conductance)
            : this(conductance, x => x.BaseUnit)
        {
        }

        /// <summary>
        /// Gets this instance as a <see cref="Conductance"/>.
        /// </summary>
        /// <value>
        /// This instance.
        /// </value>
        protected override Conductance Self => this;

        /// <summary>
        /// Increments the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The incremented result.</returns>
        public static Conductance operator ++(Conductance lhs)
        {
            return lhs.CreateQuantity(lhs.Value + 1, lhs.Unit);
        }

        /// <summary>
        /// Decrements the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The decremented result.</returns>
        public static Conductance operator --(Conductance lhs)
        {
            return lhs.CreateQuantity(lhs.Value - 1, lhs.Unit);
        }

        /// <summary>
        /// Creates the conductance quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>A new <see cref="Conductance"/>.</returns>
        public override Conductance CreateQuantity(double value, IUnit unit)
        {
            return new Conductance(value, unit);
        }

        /// <summary>
        /// Creates the electric current unit selector.
        /// </summary>
        /// <returns>A new <see cref="ConductanceUnitSelector"/>.</returns>
        public override ConductanceUnitSelector CreateUnitSelector()
        {
            return new ConductanceUnitSelector();
        }

        /// <summary>
        /// Creates a interval based on the specified min, max and unit.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The new interval.</returns>
        public static Interval<Conductance> Interval(
            double min,
            double max,
            SelectUnit<ConductanceUnitSelector> unitSelector)
        {
            return new Interval<Conductance>(min, max, unitSelector(new ConductanceUnitSelector()));
        }
    }
}