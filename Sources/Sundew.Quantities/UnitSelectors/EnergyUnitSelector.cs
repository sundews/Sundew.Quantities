// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EnergyUnitSelector.cs" company="Hukano">
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
    /// Unit selector for <see cref="Energy"/>.
    /// </summary>
    public class EnergyUnitSelector : PrefixSelector<IEnergyUnitSelector, IPrefixSelector<IEnergyUnitSelector>>,
                                      IEnergyUnitSelector
    {
        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.Joules;

        /// <summary>
        /// Gets the Joule.
        /// </summary>
        /// <value>
        /// The Joule.
        /// </value>
        public Expression Joules => this.SpecifyUnit(UnitDefinitions.Joule);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Joule;
        }

        /// <summary>
        /// Gets the prefixes and units.
        /// </summary>
        /// <returns>An <see cref="IPrefixSelector{TUnits}"/>.</returns>
        protected override IPrefixSelector<IEnergyUnitSelector> GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns>This instance.</returns>
        protected override IEnergyUnitSelector GetUnits()
        {
            return this;
        }
    }
}