// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IlluminanceUnitSelector.cs" company="Hukano">
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