// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LuminousFluxUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitSelectors
{
    using System.Collections.Generic;
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.Representations.Units;
    using Sundew.Quantities.UnitSelection;

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