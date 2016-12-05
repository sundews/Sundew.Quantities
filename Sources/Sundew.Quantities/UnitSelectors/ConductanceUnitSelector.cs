// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConductanceUnitSelector.cs" company="Hukano">
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
    /// Unit selector for <see cref="Conductance"/>.
    /// </summary>
    public class ConductanceUnitSelector :
        PrefixSelector<IConductanceUnitSelector, IPrefixSelector<IConductanceUnitSelector>>,
        IConductanceUnitSelector
    {
        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.Siemens;

        /// <summary>
        /// Gets the Siemens.
        /// </summary>
        /// <value>
        /// The Siemens.
        /// </value>
        public Expression Siemens => this.SpecifyUnit(UnitDefinitions.Siemens);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{IUnit}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Siemens;
        }

        /// <summary>
        /// Gets the prefixes and units.
        /// </summary>
        /// <returns>The <see cref="IPrefixSelector{IConductanceUnitSelector}"/></returns>
        protected override IPrefixSelector<IConductanceUnitSelector> GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns>The <see cref="IConductanceUnitSelector"/>.</returns>
        protected override IConductanceUnitSelector GetUnits()
        {
            return this;
        }
    }
}