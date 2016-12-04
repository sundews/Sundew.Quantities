// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SpacetimeUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Abstract base class for implementing spacetime unit selectors.
    /// </summary>
    /// <typeparam name="TUnits">The type of the units.</typeparam>
    /// <typeparam name="TPrefixedUnits">The type of the prefixed units.</typeparam>
    public abstract class SpacetimeUnitSelector<TUnits, TPrefixedUnits> : PrefixSelector<TUnits, TPrefixedUnits>
        where TUnits : IUnitSelector
        where TPrefixedUnits : IUnitSelector, IPrefixSelector<TUnits>
    {
        private readonly SpacetimeUnits spacetimeUnits = new SpacetimeUnits();

        /// <summary>
        /// Gets the meter.
        /// </summary>
        /// <value>
        /// The meter.
        /// </value>
        public Expression Meters => this.SpecifyUnit(this.spacetimeUnits.Meters);

        /// <summary>
        /// Gets the mile.
        /// </summary>
        /// <value>
        /// The mile.
        /// </value>
        public Expression Miles => this.SpecifyUnit(this.spacetimeUnits.Miles);

        /// <summary>
        /// Gets the foot.
        /// </summary>
        /// <value>
        /// The foot.
        /// </value>
        public Expression Feet => this.SpecifyUnit(this.spacetimeUnits.Feet);

        /// <summary>
        /// Gets the inch.
        /// </summary>
        /// <value>
        /// The inch.
        /// </value>
        public Expression Inches => this.SpecifyUnit(this.spacetimeUnits.Inches);

        /// <summary>
        /// Gets the nautical mile.
        /// </summary>
        /// <value>
        /// The nautical mile.
        /// </value>
        public Expression NauticalMiles => this.SpecifyUnit(this.spacetimeUnits.NauticalMiles);

        /// <summary>
        /// Gets the yard.
        /// </summary>
        /// <value>
        /// The yard.
        /// </value>
        public Expression Yards => this.SpecifyUnit(this.spacetimeUnits.Yards);

        /// <summary>
        /// Gets the second.
        /// </summary>
        /// <value>
        /// The second.
        /// </value>
        public Expression Seconds => this.SpecifyUnit(this.spacetimeUnits.Seconds);

        /// <summary>
        /// Gets the year.
        /// </summary>
        /// <value>
        /// The year.
        /// </value>
        public Expression Years => this.SpecifyUnit(this.spacetimeUnits.Years);

        /// <summary>
        /// Gets the month.
        /// </summary>
        /// <value>
        /// The month.
        /// </value>
        public Expression Months => this.SpecifyUnit(this.spacetimeUnits.Months);

        /// <summary>
        /// Gets the week.
        /// </summary>
        /// <value>
        /// The week.
        /// </value>
        public Expression Weeks => this.SpecifyUnit(this.spacetimeUnits.Weeks);

        /// <summary>
        /// Gets the day.
        /// </summary>
        /// <value>
        /// The day.
        /// </value>
        public Expression Days => this.SpecifyUnit(this.spacetimeUnits.Days);

        /// <summary>
        /// Gets the minute.
        /// </summary>
        /// <value>
        /// The minute.
        /// </value>
        public Expression Minutes => this.SpecifyUnit(this.spacetimeUnits.Minutes);

        /// <summary>
        /// Gets the hour.
        /// </summary>
        /// <value>
        /// The hour.
        /// </value>
        public Expression Hours => this.SpecifyUnit(this.spacetimeUnits.Hours);
    }
}