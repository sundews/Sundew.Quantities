// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="AccelerationUnitSelector.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Spacetime.UnitSelection
{
    using System.Collections.Generic;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.Units;

    /// <summary>
    /// Interface for <see cref="Acceleration"/> unit selector.
    /// </summary>
    public class AccelerationUnitSelector :
        SpacetimeUnitSelector<IAccelerationUnitSelector, IPrefixedAccelerationUnitSelector>,
        IPrefixedAccelerationUnitSelector
    {
        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.SpecifyUnit(UnitDefinitions.Acceleration);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{IUnit}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Acceleration;
        }

        /// <summary>
        /// Gets the derived units.
        /// </summary>
        /// <returns>This instance.</returns>
        protected override IPrefixedAccelerationUnitSelector GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns>This instance.</returns>
        protected override IAccelerationUnitSelector GetUnits()
        {
            return this;
        }
    }
}