// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ForceUnitSelector.cs" company="Hukano">
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
    /// Unit selector for <see cref="Force"/>.
    /// </summary>
    public class ForceUnitSelector : PrefixSelector<IForceUnitSelector, IPrefixSelector<IForceUnitSelector>>,
                                     IForceUnitSelector
    {
        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.Newtons;

        /// <summary>
        /// Gets or sets the Newton.
        /// </summary>
        /// <value>
        /// The Newton.
        /// </value>
        public Expression Newtons => this.SpecifyUnit(UnitDefinitions.Newton);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Newton;
        }

        /// <summary>
        /// Gets the derived units.
        /// </summary>
        /// <returns>This instance.</returns>
        protected override IPrefixSelector<IForceUnitSelector> GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns>This instance.</returns>
        protected override IForceUnitSelector GetUnits()
        {
            return this;
        }
    }
}