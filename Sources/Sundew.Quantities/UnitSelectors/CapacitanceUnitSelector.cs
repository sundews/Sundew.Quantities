// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CapacitanceUnitSelector.cs" company="Hukano">
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
    /// Unit selector for <see cref="Capacitance"/>.
    /// </summary>
    public class CapacitanceUnitSelector :
        PrefixSelector<ICapacitanceUnitSelector, IPrefixSelector<ICapacitanceUnitSelector>>,
        ICapacitanceUnitSelector
    {
        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.Farads;

        /// <summary>
        /// Gets the Farad.
        /// </summary>
        /// <value>
        /// The Farad.
        /// </value>
        public Expression Farads => this.SpecifyUnit(UnitDefinitions.Farad);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{IUnit}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Farad;
        }

        /// <summary>
        /// Gets the prefixes and units.
        /// </summary>
        /// <returns>The <see cref="IPrefixSelector{ICapacitanceUnitSelector}"/></returns>
        protected override IPrefixSelector<ICapacitanceUnitSelector> GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns>The <see cref="ICapacitanceUnitSelector"/>.</returns>
        protected override ICapacitanceUnitSelector GetUnits()
        {
            return this;
        }
    }
}