// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ElectricCurrentUnitSelector.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Electromagnetism.UnitSelection
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