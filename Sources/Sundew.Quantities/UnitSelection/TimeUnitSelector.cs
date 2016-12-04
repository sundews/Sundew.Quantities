// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TimeUnitSelector.cs" company="Hukano">
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
    /// Interface for <see cref="Time"/> unit selector.
    /// </summary>
    public class TimeUnitSelector : PrefixSelector<ITimeUnitSelector, IPrefixedTimeUnitSelector>,
                                    IPrefixedTimeUnitSelector
    {
        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.Seconds;

        /// <summary>
        /// Gets the second.
        /// </summary>
        /// <value>
        /// The second.
        /// </value>
        public Expression Seconds => this.SpecifyUnit(UnitDefinitions.Second);

        /// <summary>
        /// Gets the minute.
        /// </summary>
        /// <value>
        /// The minute.
        /// </value>
        public Expression Minutes => this.SpecifyUnit(UnitDefinitions.Minute);

        /// <summary>
        /// Gets the hour.
        /// </summary>
        /// <value>
        /// The hour.
        /// </value>
        public Expression Hours => this.SpecifyUnit(UnitDefinitions.Hour);

        /// <summary>
        /// Gets the day.
        /// </summary>
        /// <value>
        /// The day.
        /// </value>
        public Expression Days => this.SpecifyUnit(UnitDefinitions.Day);

        /// <summary>
        /// Gets the week.
        /// </summary>
        /// <value>
        /// The week.
        /// </value>
        public Expression Weeks => this.SpecifyUnit(UnitDefinitions.Week);

        /// <summary>
        /// Gets the month.
        /// </summary>
        /// <value>
        /// The month.
        /// </value>
        public Expression Months => this.SpecifyUnit(UnitDefinitions.Month);

        /// <summary>
        /// Gets the year.
        /// </summary>
        /// <value>
        /// The year.
        /// </value>
        public Expression Years => this.SpecifyUnit(UnitDefinitions.Year);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Second;
            yield return UnitDefinitions.Minute;
            yield return UnitDefinitions.Hour;
            yield return UnitDefinitions.Day;
            yield return UnitDefinitions.Month;
            yield return UnitDefinitions.Week;
            yield return UnitDefinitions.Year;
        }

        /// <summary>
        /// Gets the derived units.
        /// </summary>
        /// <returns>The instance.</returns>
        protected override IPrefixedTimeUnitSelector GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns>The instance.</returns>
        protected override ITimeUnitSelector GetUnits()
        {
            return this;
        }
    }
}