// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TimeUnits.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Units
{
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.Representations.Units;

    /// <summary>
    /// Time units.
    /// </summary>
    public class TimeUnits
    {
        /// <summary>
        /// Gets the second.
        /// </summary>
        /// <value>
        /// The second.
        /// </value>
        public IUnit Seconds => UnitDefinitions.Second;

        /// <summary>
        /// Gets the minute.
        /// </summary>
        /// <value>
        /// The minute.
        /// </value>
        public IUnit Minutes => UnitDefinitions.Minute;

        /// <summary>
        /// Gets the hour.
        /// </summary>
        /// <value>
        /// The hour.
        /// </value>
        public IUnit Hours => UnitDefinitions.Hour;

        /// <summary>
        /// Gets the day.
        /// </summary>
        /// <value>
        /// The day.
        /// </value>
        public IUnit Days => UnitDefinitions.Day;

        /// <summary>
        /// Gets the week.
        /// </summary>
        /// <value>
        /// The week.
        /// </value>
        public IUnit Weeks => UnitDefinitions.Week;

        /// <summary>
        /// Gets the month.
        /// </summary>
        /// <value>
        /// The month.
        /// </value>
        public IUnit Months => UnitDefinitions.Month;

        /// <summary>
        /// Gets the year.
        /// </summary>
        /// <value>
        /// The year.
        /// </value>
        public IUnit Years => UnitDefinitions.Year;

        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public IUnit BaseUnit => this.Seconds;
    }
}