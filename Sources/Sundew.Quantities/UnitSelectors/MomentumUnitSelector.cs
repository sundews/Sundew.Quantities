// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MomentumUnitSelector.cs" company="Hukano">
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
    /// Unit selector for <see cref="Momentum"/>.
    /// </summary>
    public class MomentumUnitSelector : PrefixSelector<IMomentumUnitSelector, IPrefixSelector<IMomentumUnitSelector>>,
                                        IMomentumUnitSelector
    {
        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.SpecifyUnit(UnitDefinitions.Momentum);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Momentum;
        }

        /// <summary>
        /// Gets the prefixes and units.
        /// </summary>
        /// <returns>An <see cref="IPrefixSelector{TUnits}"/></returns>
        protected override IPrefixSelector<IMomentumUnitSelector> GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns>This instance.</returns>
        protected override IMomentumUnitSelector GetUnits()
        {
            return this;
        }
    }
}