// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PotentialUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitSelection
{
    using System.Collections.Generic;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.Units;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Unit selector for <see cref="Potential"/>.
    /// </summary>
    public class PotentialUnitSelector : PrefixSelector<IPotentialUnitSelector, IPrefixSelector<IPotentialUnitSelector>>,
                                         IPotentialUnitSelector
    {
        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.Volts;

        /// <summary>
        /// Gets the volt.
        /// </summary>
        /// <value>
        /// The volt.
        /// </value>
        public Expression Volts => this.SpecifyUnit(UnitDefinitions.Volt);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{IUnit}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Volt;
        }

        /// <summary>
        /// Gets the prefixes and units.
        /// </summary>
        /// <returns>This instance.</returns>
        protected override IPrefixSelector<IPotentialUnitSelector> GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns>This instance.</returns>
        protected override IPotentialUnitSelector GetUnits()
        {
            return this;
        }
    }
}