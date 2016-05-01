// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="MagneticFluxDensity.cs" company="Hukano">
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
    /// Represents a magnetic flux density quantity.
    /// </summary>
    public sealed partial class MagneticFluxDensity : Quantity<MagneticFluxDensity, MagneticFluxDensityUnitSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MagneticFluxDensity" /> class.
        /// </summary>
        /// <param name="magneticFluxDensity">The magneticFluxDensity.</param>
        /// <param name="magneticFluxDensityUnitSelector">The MagneticFluxDensity unit selector.</param>
        public MagneticFluxDensity(
            double magneticFluxDensity,
            SelectUnit<MagneticFluxDensityUnitSelector> magneticFluxDensityUnitSelector)
            : base(magneticFluxDensity, magneticFluxDensityUnitSelector(new MagneticFluxDensityUnitSelector()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MagneticFluxDensity" /> class.
        /// </summary>
        /// <param name="quantity">The quantity operation result.</param>
        public MagneticFluxDensity(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MagneticFluxDensity" /> class.
        /// </summary>
        /// <param name="magneticFluxDensity">The magneticFluxDensity.</param>
        /// <param name="unit">The unit.</param>
        public MagneticFluxDensity(double magneticFluxDensity, IUnit unit)
            : base(magneticFluxDensity, unit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MagneticFluxDensity" /> class.
        /// </summary>
        /// <param name="magneticFluxDensity">The magneticFluxDensity.</param>
        public MagneticFluxDensity(double magneticFluxDensity)
            : this(magneticFluxDensity, x => x.BaseUnit)
        {
        }

        /// <summary>
        /// Gets this instance as a <see cref="MagneticFluxDensity"/>.
        /// </summary>
        /// <value>
        /// This instance.
        /// </value>
        protected override MagneticFluxDensity Self => this;

        /// <summary>
        /// Increments the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The incremented result.</returns>
        public static MagneticFluxDensity operator ++(MagneticFluxDensity lhs)
        {
            return lhs.CreateQuantity(lhs.Value + 1, lhs.Unit);
        }

        /// <summary>
        /// Decrements the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The decremented result.</returns>
        public static MagneticFluxDensity operator --(MagneticFluxDensity lhs)
        {
            return lhs.CreateQuantity(lhs.Value - 1, lhs.Unit);
        }

        /// <summary>
        /// Creates the magnetic flux density quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>A new <see cref="MagneticFluxDensity"/>.</returns>
        public override MagneticFluxDensity CreateQuantity(double value, IUnit unit)
        {
            return new MagneticFluxDensity(value, unit);
        }

        /// <summary>
        /// Creates the electric current unit selector.
        /// </summary>
        /// <returns>A new <see cref="MagneticFluxDensityUnitSelector"/>.</returns>
        public override MagneticFluxDensityUnitSelector CreateUnitSelector()
        {
            return new MagneticFluxDensityUnitSelector();
        }

        /// <summary>
        /// Creates a interval based on the specified min, max and unit.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The new interval.</returns>
        public static Interval<MagneticFluxDensity> Interval(
            double min,
            double max,
            SelectUnit<MagneticFluxDensityUnitSelector> unitSelector)
        {
            return new Interval<MagneticFluxDensity>(min, max, unitSelector(new MagneticFluxDensityUnitSelector()));
        }
    }
}