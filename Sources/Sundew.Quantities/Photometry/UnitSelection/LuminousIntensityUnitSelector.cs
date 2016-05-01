// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="LuminousIntensityUnitSelector.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Photometry.UnitSelection
{
    using System.Collections.Generic;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.Units;
    using Sundew.Quantities.Engine.UnitSelection;

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