// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InductanceUnitSelector.cs" company="Hukano">
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
    /// Unit selector for <see cref="Inductance"/>.
    /// </summary>
    public class InductanceUnitSelector :
        PrefixSelector<IInductanceUnitSelector, IPrefixSelector<IInductanceUnitSelector>>,
        IInductanceUnitSelector
    {
        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.Henry;

        /// <summary>
        /// Gets the siemens.
        /// </summary>
        /// <value>
        /// The siemens.
        /// </value>
        public Expression Henry => this.SpecifyUnit(UnitDefinitions.Henry);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Henry;
        }

        /// <summary>
        /// Gets the prefixes and units.
        /// </summary>
        /// <returns>The <see cref="IPrefixSelector{IInductanceUnitSelector}"/></returns>
        protected override IPrefixSelector<IInductanceUnitSelector> GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns>The <see cref="IInductanceUnitSelector"/>.</returns>
        protected override IInductanceUnitSelector GetUnits()
        {
            return this;
        }
    }
}