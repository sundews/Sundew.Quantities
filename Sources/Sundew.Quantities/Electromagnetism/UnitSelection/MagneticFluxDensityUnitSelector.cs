// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="MagneticFluxDensityUnitSelector.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Electromagnetism.UnitSelection
{
    using System.Collections.Generic;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.Units;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Unit selector for <see cref="MagneticFluxDensity"/>.
    /// </summary>
    public class MagneticFluxDensityUnitSelector :
        PrefixSelector<IMagneticFluxDensityUnitSelector, IPrefixSelector<IMagneticFluxDensityUnitSelector>>,
        IMagneticFluxDensityUnitSelector
    {
        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.Teslas;

        /// <summary>
        /// Gets the Tesla.
        /// </summary>
        /// <value>
        /// The Tesla.
        /// </value>
        public Expression Teslas => this.SpecifyUnit(UnitDefinitions.Tesla);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{IUnit}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Tesla;
        }

        /// <summary>
        /// Gets the prefixes and units.
        /// </summary>
        /// <returns>The <see cref="IPrefixSelector{IMagneticFluxDensityUnitSelector}"/></returns>
        protected override IPrefixSelector<IMagneticFluxDensityUnitSelector> GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns>The <see cref="IMagneticFluxDensityUnitSelector"/>.</returns>
        protected override IMagneticFluxDensityUnitSelector GetUnits()
        {
            return this;
        }
    }
}