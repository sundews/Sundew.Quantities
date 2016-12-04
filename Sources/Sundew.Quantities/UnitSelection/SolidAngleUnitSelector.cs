// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SolidAngleUnitSelector.cs" company="Hukano">
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
    /// Unit selector for <see cref="SolidAngle"/>.
    /// </summary>
    public class SolidAngleUnitSelector :
        PrefixSelector<ISolidAngleUnitSelector, IPrefixSelector<ISolidAngleUnitSelector>>,
        ISolidAngleUnitSelector
    {
        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.Steradians;

        /// <summary>
        /// Gets the steradian.
        /// </summary>
        /// <value>
        /// The steradian.
        /// </value>
        public Expression Steradians => this.SpecifyUnit(UnitDefinitions.Steradian);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{IUnit}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Steradian;
        }

        /// <summary>
        /// Gets the prefixes and units.
        /// </summary>
        /// <returns>The <see cref="IPrefixSelector{ISolidAngleUnitSelector}"/></returns>
        protected override IPrefixSelector<ISolidAngleUnitSelector> GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns>The <see cref="ISolidAngleUnitSelector"/>.</returns>
        protected override ISolidAngleUnitSelector GetUnits()
        {
            return this;
        }
    }
}