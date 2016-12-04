// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MomentumUnitSelector.cs" company="Hukano">
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