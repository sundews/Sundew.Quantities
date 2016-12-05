// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IlluminanceUnitSelector.cs" company="Hukano">
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
    /// Interface for <see cref="Illuminance"/> unit selector.
    /// </summary>
    public class IlluminanceUnitSelector :
        PrefixSelector<IIlluminanceUnitSelector, IPrefixSelector<IIlluminanceUnitSelector>>,
        IIlluminanceUnitSelector
    {
        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.Lux;

        /// <summary>
        /// Gets the lux.
        /// </summary>
        /// <value>
        /// The lux.
        /// </value>
        public Expression Lux => this.SpecifyUnit(UnitDefinitions.Lux);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Lux;
        }

        /// <summary>
        /// Gets the prefixes and units.
        /// </summary>
        /// <returns></returns>
        protected override IPrefixSelector<IIlluminanceUnitSelector> GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns></returns>
        protected override IIlluminanceUnitSelector GetUnits()
        {
            return this;
        }
    }
}