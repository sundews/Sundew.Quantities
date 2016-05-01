// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="CapacitanceUnitSelector.cs" company="Hukano">
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
    /// Unit selector for <see cref="Capacitance"/>.
    /// </summary>
    public class CapacitanceUnitSelector :
        PrefixSelector<ICapacitanceUnitSelector, IPrefixSelector<ICapacitanceUnitSelector>>,
        ICapacitanceUnitSelector
    {
        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.Farads;

        /// <summary>
        /// Gets the Farad.
        /// </summary>
        /// <value>
        /// The Farad.
        /// </value>
        public Expression Farads => this.SpecifyUnit(UnitDefinitions.Farad);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{IUnit}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Farad;
        }

        /// <summary>
        /// Gets the prefixes and units.
        /// </summary>
        /// <returns>The <see cref="IPrefixSelector{ICapacitanceUnitSelector}"/></returns>
        protected override IPrefixSelector<ICapacitanceUnitSelector> GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns>The <see cref="ICapacitanceUnitSelector"/>.</returns>
        protected override ICapacitanceUnitSelector GetUnits()
        {
            return this;
        }
    }
}