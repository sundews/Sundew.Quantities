// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="TemperatureUnitSelector.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Thermodynamics.UnitSelection
{
    using System.Collections.Generic;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.Units;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Unit selector for <see cref="Temperature"/>.
    /// </summary>
    public class TemperatureUnitSelector :
        PrefixSelector<ITemperatureUnitSelector, IPrefixSelector<ITemperatureUnitSelector>>,
        ITemperatureUnitSelector
    {
        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.Kelvin;

        /// <summary>
        /// Gets the Kelvin.
        /// </summary>
        /// <value>
        /// The Kelvin.
        /// </value>
        public Expression Kelvin => this.SpecifyUnit(UnitDefinitions.Kelvin);

        /// <summary>
        /// Gets the Celsius.
        /// </summary>
        /// <value>
        /// The Celsius.
        /// </value>
        public Expression Celsius => this.SpecifyUnit(UnitDefinitions.Celsius);

        /// <summary>
        /// Gets the Fahrenheit.
        /// </summary>
        /// <value>
        /// The Fahrenheit.
        /// </value>
        public Expression Fahrenheits => this.SpecifyUnit(UnitDefinitions.Fahrenheit);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{IUnit}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Kelvin;
            yield return UnitDefinitions.Celsius;
            yield return UnitDefinitions.Fahrenheit;
        }

        /// <summary>
        /// Gets the prefixes and units.
        /// </summary>
        /// <returns>The <see cref="IPrefixSelector{ITemperatureUnitSelector}"/></returns>
        protected override IPrefixSelector<ITemperatureUnitSelector> GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns>The <see cref="ITemperatureUnitSelector"/>.</returns>
        protected override ITemperatureUnitSelector GetUnits()
        {
            return this;
        }
    }
}