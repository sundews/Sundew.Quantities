// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ITimeUnitSelector.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Periodics.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

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