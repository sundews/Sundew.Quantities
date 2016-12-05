// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PowerUnitSelector.cs" company="Hukano">
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
    /// Unit selector for <see cref="Power"/>.
    /// </summary>
    public class PowerUnitSelector : PrefixSelector<IPowerUnitSelector, IPrefixSelector<IPowerUnitSelector>>,
                                     IPowerUnitSelector
    {
        /// <summary>
        /// Gets or sets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.Watts;

        /// <summary>
        /// Gets the Watt.
        /// </summary>
        /// <value>
        /// The Watt.
        /// </value>
        public Expression Watts => this.SpecifyUnit(UnitDefinitions.Watt);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Watt;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns></returns>
        protected override IPowerUnitSelector GetUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the prefixes and units.
        /// </summary>
        /// <returns></returns>
        protected override IPrefixSelector<IPowerUnitSelector> GetPrefixesAndUnits()
        {
            return this;
        }
    }
}