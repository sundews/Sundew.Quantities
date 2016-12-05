// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITimeUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitSelectors
{
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Time"/> unit selector.
    /// </summary>
    public interface ITimeUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the second.
        /// </summary>
        /// <value>
        /// The second <see cref="Expression"/>.
        /// </value>
        Expression Seconds { get; }

        /// <summary>
        /// Gets the year.
        /// </summary>
        /// <value>
        /// The year <see cref="Expression"/>.
        /// </value>
        Expression Years { get; }

        /// <summary>
        /// Gets the month.
        /// </summary>
        /// <value>
        /// The month <see cref="Expression"/>.
        /// </value>
        Expression Months { get; }

        /// <summary>
        /// Gets the week.
        /// </summary>
        /// <value>
        /// The week <see cref="Expression"/>.
        /// </value>
        Expression Weeks { get; }

        /// <summary>
        /// Gets the day.
        /// </summary>
        /// <value>
        /// The day <see cref="Expression"/>.
        /// </value>
        Expression Days { get; }

        /// <summary>
        /// Gets the minute.
        /// </summary>
        /// <value>
        /// The minute <see cref="Expression"/>.
        /// </value>
        Expression Minutes { get; }

        /// <summary>
        /// Gets the hour.
        /// </summary>
        /// <value>
        /// The hour <see cref="Expression"/>.
        /// </value>
        Expression Hours { get; }
    }
}