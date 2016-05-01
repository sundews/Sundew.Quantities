// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="DistanceUnitSelector.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Spatial.UnitSelection
{
    using System.Collections.Generic;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.Units;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Unit selector for <see cref="Distance"/>.
    /// </summary>
    public class DistanceUnitSelector : PrefixSelector<IDistanceUnitSelector, IPrefixedDistanceUnitSelector>,
                                        IPrefixedDistanceUnitSelector
    {
        private readonly DistanceUnits distanceUnits = new DistanceUnits();

        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.SpecifyUnit(this.distanceUnits.Meters);

        /// <summary>
        /// Gets the meter.
        /// </summary>
        /// <value>
        /// The meter.
        /// </value>
        public Expression Meters => this.SpecifyUnit(UnitDefinitions.Meter);

        /// <summary>
        /// Gets the mile.
        /// </summary>
        /// <value>
        /// The mile.
        /// </value>
        public Expression Miles => this.SpecifyUnit(UnitDefinitions.Mile);

        /// <summary>
        /// Gets the foot.
        /// </summary>
        /// <value>
        /// The foot.
        /// </value>
        public Expression Feet => this.SpecifyUnit(UnitDefinitions.Foot);

        /// <summary>
        /// Gets the inch.
        /// </summary>
        /// <value>
        /// The inch.
        /// </value>
        public Expression Inches => this.SpecifyUnit(UnitDefinitions.Inch);

        /// <summary>
        /// Gets the nautical mile.
        /// </summary>
        /// <value>
        /// The nautical mile.
        /// </value>
        public Expression NauticalMiles => this.SpecifyUnit(UnitDefinitions.NauticalMile);

        /// <summary>
        /// Gets the yard.
        /// </summary>
        /// <value>
        /// The yard.
        /// </value>
        public Expression Yards => this.SpecifyUnit(UnitDefinitions.Yard);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{IUnit}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Meter;
            yield return UnitDefinitions.Mile;
            yield return UnitDefinitions.NauticalMile;
            yield return UnitDefinitions.Foot;
            yield return UnitDefinitions.Inch;
            yield return UnitDefinitions.Yard;
        }

        /// <summary>
        /// Gets the derived units.
        /// </summary>
        /// <returns></returns>
        protected override IPrefixedDistanceUnitSelector GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns></returns>
        protected override IDistanceUnitSelector GetUnits()
        {
            return this;
        }
    }
}