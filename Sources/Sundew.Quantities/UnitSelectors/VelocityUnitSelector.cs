// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VelocityUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitSelectors
{
    using System.Collections.Generic;
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.Representations.Units;

    /// <summary>
    /// Unit selector for <see cref="Velocity"/>.
    /// </summary>
    public class VelocityUnitSelector : SpacetimeUnitSelector<IVelocityUnitSelector, IPrefixedVelocityUnitSelector>,
                                        IPrefixedVelocityUnitSelector
    {
        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.SpecifyUnit(UnitDefinitions.Velocity);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{IUnit}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Velocity;
        }

        /// <summary>
        /// Gets the derived units.
        /// </summary>
        /// <returns>This instance.</returns>
        protected override IPrefixedVelocityUnitSelector GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns>This instance.</returns>
        protected override IVelocityUnitSelector GetUnits()
        {
            return this;
        }
    }
}