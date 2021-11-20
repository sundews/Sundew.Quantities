// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SpacetimeUnits.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Units
{
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.Representations.Units;

    /// <summary>
    /// Spacetime units.
    /// </summary>
    public class SpacetimeUnits
    {
        private readonly DistanceUnits distanceUnits = new();

        private readonly TimeUnits timeUnits = new();

        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public IUnit BaseUnit => UnitDefinitions.Acceleration;

        /// <summary>
        /// Gets the meter.
        /// </summary>
        /// <value>
        /// The meter.
        /// </value>
        public IUnit Meters => this.distanceUnits.Meters;

        /// <summary>
        /// Gets the mile.
        /// </summary>
        /// <value>
        /// The mile.
        /// </value>
        public IUnit Miles => this.distanceUnits.Miles;

        /// <summary>
        /// Gets the foot.
        /// </summary>
        /// <value>
        /// The foot.
        /// </value>
        public IUnit Feet => this.distanceUnits.Feet;

        /// <summary>
        /// Gets the inch.
        /// </summary>
        /// <value>
        /// The inch.
        /// </value>
        public IUnit Inches => this.distanceUnits.Inches;

        /// <summary>
        /// Gets the nautical mile.
        /// </summary>
        /// <value>
        /// The nautical mile.
        /// </value>
        public IUnit NauticalMiles => this.distanceUnits.NauticalMiles;

        /// <summary>
        /// Gets the yard.
        /// </summary>
        /// <value>
        /// The yard.
        /// </value>
        public IUnit Yards => this.distanceUnits.Yards;

        /// <summary>
        /// Gets the second.
        /// </summary>
        /// <value>
        /// The second.
        /// </value>
        public IUnit Seconds => this.timeUnits.Seconds;

        /// <summary>
        /// Gets the year.
        /// </summary>
        /// <value>
        /// The year.
        /// </value>
        public IUnit Years => this.timeUnits.Years;

        /// <summary>
        /// Gets the month.
        /// </summary>
        /// <value>
        /// The month.
        /// </value>
        public IUnit Months => this.timeUnits.Months;

        /// <summary>
        /// Gets the week.
        /// </summary>
        /// <value>
        /// The week.
        /// </value>
        public IUnit Weeks => this.timeUnits.Weeks;

        /// <summary>
        /// Gets the day.
        /// </summary>
        /// <value>
        /// The day.
        /// </value>
        public IUnit Days => this.timeUnits.Days;

        /// <summary>
        /// Gets the minute.
        /// </summary>
        /// <value>
        /// The minute.
        /// </value>
        public IUnit Minutes => this.timeUnits.Minutes;

        /// <summary>
        /// Gets the hour.
        /// </summary>
        /// <value>
        /// The hour.
        /// </value>
        public IUnit Hours => this.timeUnits.Hours;
    }
}