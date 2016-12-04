// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AngleUnitSelector.cs" company="Hukano">
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
    /// Unit selector for <see cref="Angle"/>.
    /// </summary>
    public class AngleUnitSelector : PrefixSelector<IAngleUnitSelector, IPrefixSelector<IAngleUnitSelector>>,
                                     IAngleUnitSelector
    {
        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.Radians;

        /// <summary>
        /// Gets the Mole.
        /// </summary>
        /// <value>
        /// The Mole.
        /// </value>
        public Expression Radians => this.SpecifyUnit(UnitDefinitions.Radian);

        /// <summary>
        /// Gets the degrees.
        /// </summary>
        /// <value>
        /// The degrees.
        /// </value>
        public Expression Degrees => this.SpecifyUnit(UnitDefinitions.Degree);

        /// <summary>
        /// Gets the turns.
        /// </summary>
        /// <value>
        /// The turns.
        /// </value>
        public Expression Turns => this.SpecifyUnit(UnitDefinitions.Turn);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Radian;
            yield return UnitDefinitions.Degree;
            yield return UnitDefinitions.Turn;
        }

        /// <summary>
        /// Gets the prefixes and units.
        /// </summary>
        /// <returns>The <see cref="IPrefixSelector{IAngleUnitSelector}"/></returns>
        protected override IPrefixSelector<IAngleUnitSelector> GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns>The <see cref="IAngleUnitSelector"/>.</returns>
        protected override IAngleUnitSelector GetUnits()
        {
            return this;
        }
    }
}