// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ElectricCurrentUnitSelector.cs" company="Hukano">
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
    /// Unit selector for <see cref="ElectricCurrent"/>.
    /// </summary>
    public class ElectricCurrentUnitSelector :
        PrefixSelector<IElectricCurrentUnitSelector, IPrefixSelector<IElectricCurrentUnitSelector>>,
        IElectricCurrentUnitSelector
    {
        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.Amperes;

        /// <summary>
        /// Gets the ampere.
        /// </summary>
        /// <value>
        /// The ampere.
        /// </value>
        public Expression Amperes => this.SpecifyUnit(UnitDefinitions.Ampere);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{IUnit}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Ampere;
        }

        /// <summary>
        /// Gets the prefixes and units.
        /// </summary>
        /// <returns>this instance.</returns>
        protected override IPrefixSelector<IElectricCurrentUnitSelector> GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns>this instance.</returns>
        protected override IElectricCurrentUnitSelector GetUnits()
        {
            return this;
        }
    }
}