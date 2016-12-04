// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FrequencyUnitSelector.cs" company="Hukano">
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
    /// Interface for <see cref="Frequency"/> unit selector.
    /// </summary>
    public class FrequencyUnitSelector : PrefixSelector<IFrequencyUnitSelector, IPrefixSelector<IFrequencyUnitSelector>>,
                                         IFrequencyUnitSelector
    {
        private readonly TimeUnits timeUnits = new TimeUnits();

        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.Hertz;

        /// <summary>
        /// Gets the second.
        /// </summary>
        /// <value>
        /// The second.
        /// </value>
        public Expression Seconds => this.SpecifyUnit(this.timeUnits.Seconds);

        /// <summary>
        /// Gets the year.
        /// </summary>
        /// <value>
        /// The year.
        /// </value>
        public Expression Years => this.SpecifyUnit(this.timeUnits.Years);

        /// <summary>
        /// Gets the month.
        /// </summary>
        /// <value>
        /// The month.
        /// </value>
        public Expression Months => this.SpecifyUnit(this.timeUnits.Months);

        /// <summary>
        /// Gets the week.
        /// </summary>
        /// <value>
        /// The week.
        /// </value>
        public Expression Weeks => this.SpecifyUnit(this.timeUnits.Weeks);

        /// <summary>
        /// Gets the day.
        /// </summary>
        /// <value>
        /// The day.
        /// </value>
        public Expression Days => this.SpecifyUnit(this.timeUnits.Days);

        /// <summary>
        /// Gets the minute.
        /// </summary>
        /// <value>
        /// The minute.
        /// </value>
        public Expression Minutes => this.SpecifyUnit(this.timeUnits.Minutes);

        /// <summary>
        /// Gets the hour.
        /// </summary>
        /// <value>
        /// The hour.
        /// </value>
        public Expression Hours => this.SpecifyUnit(this.timeUnits.Hours);

        /// <summary>
        /// Gets the one.
        /// </summary>
        /// <value>
        /// The one.
        /// </value>
        public Expression One => ConstantExpression.One;

        /// <summary>
        /// Gets the hertz.
        /// </summary>
        /// <value>
        /// The hertz.
        /// </value>
        public Expression Hertz => this.SpecifyUnit(UnitDefinitions.Hertz);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{IUnit}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Hertz;
        }

        /// <summary>
        /// Gets the prefixes and units.
        /// </summary>
        /// <returns>An <see cref="IPrefixSelector{TUnits}"/>.</returns>
        protected override IPrefixSelector<IFrequencyUnitSelector> GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns>An <see cref="IFrequencyUnitSelector"/>.</returns>
        protected override IFrequencyUnitSelector GetUnits()
        {
            return this;
        }
    }
}