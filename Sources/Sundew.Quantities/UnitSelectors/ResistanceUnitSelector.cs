// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ResistanceUnitSelector.cs" company="Hukano">
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
    /// Unit selector for <see cref="Resistance"/>.
    /// </summary>
    public class ResistanceUnitSelector :
        PrefixSelector<IResistanceUnitSelector, IPrefixSelector<IResistanceUnitSelector>>,
        IResistanceUnitSelector
    {
        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.Ohms;

        /// <summary>
        /// Gets the ohm.
        /// </summary>
        /// <value>
        /// The ohm.
        /// </value>
        public Expression Ohms => this.SpecifyUnit(UnitDefinitions.Ohm);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Ohm;
        }

        /// <summary>
        /// Gets the prefixes and units.
        /// </summary>
        /// <returns></returns>
        protected override IPrefixSelector<IResistanceUnitSelector> GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns></returns>
        protected override IResistanceUnitSelector GetUnits()
        {
            return this;
        }
    }
}