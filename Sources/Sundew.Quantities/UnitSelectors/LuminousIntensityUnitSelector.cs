// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LuminousIntensityUnitSelector.cs" company="Hukano">
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
    /// Interface for <see cref="LuminousIntensity"/> unit selector.
    /// </summary>
    public class LuminousIntensityUnitSelector :
        PrefixSelector<ILuminousIntensityUnitSelector, IPrefixSelector<ILuminousIntensityUnitSelector>>,
        ILuminousIntensityUnitSelector
    {
        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.Candelas;

        /// <summary>
        /// Gets or sets the candela.
        /// </summary>
        /// <value>
        /// The candela.
        /// </value>
        public Expression Candelas => this.SpecifyUnit(UnitDefinitions.Candela);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{IUnit}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Candela;
        }

        /// <summary>
        /// Gets the prefixes and units.
        /// </summary>
        /// <returns></returns>
        protected override IPrefixSelector<ILuminousIntensityUnitSelector> GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns></returns>
        protected override ILuminousIntensityUnitSelector GetUnits()
        {
            return this;
        }
    }
}