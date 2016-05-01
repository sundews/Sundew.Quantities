// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ForceUnitSelector.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Mechanics.UnitSelection
{
    using System.Collections.Generic;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.Units;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Unit selector for <see cref="Force"/>.
    /// </summary>
    public class ForceUnitSelector : PrefixSelector<IForceUnitSelector, IPrefixSelector<IForceUnitSelector>>,
                                     IForceUnitSelector
    {
        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.Newtons;

        /// <summary>
        /// Gets or sets the Newton.
        /// </summary>
        /// <value>
        /// The Newton.
        /// </value>
        public Expression Newtons => this.SpecifyUnit(UnitDefinitions.Newton);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Newton;
        }

        /// <summary>
        /// Gets the derived units.
        /// </summary>
        /// <returns>This instance.</returns>
        protected override IPrefixSelector<IForceUnitSelector> GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns>This instance.</returns>
        protected override IForceUnitSelector GetUnits()
        {
            return this;
        }
    }
}