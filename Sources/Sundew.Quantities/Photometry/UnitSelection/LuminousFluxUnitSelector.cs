// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="LuminousFluxUnitSelector.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Photometry.UnitSelection
{
    using System.Collections.Generic;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.Units;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="LuminousFlux"/> unit selector.
    /// </summary>
    public class LuminousFluxUnitSelector :
        PrefixSelector<ILuminousFluxUnitSelector, IPrefixSelector<ILuminousFluxUnitSelector>>,
        ILuminousFluxUnitSelector
    {
        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.Lumens;

        /// <summary>
        /// Gets the lumen.
        /// </summary>
        /// <value>
        /// The lumen.
        /// </value>
        public Expression Lumens => this.SpecifyUnit(UnitDefinitions.Lumen);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{IUnit}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Lumen;
        }

        /// <summary>
        /// Gets the prefixes and units.
        /// </summary>
        /// <returns></returns>
        protected override IPrefixSelector<ILuminousFluxUnitSelector> GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns></returns>
        protected override ILuminousFluxUnitSelector GetUnits()
        {
            return this;
        }
    }
}