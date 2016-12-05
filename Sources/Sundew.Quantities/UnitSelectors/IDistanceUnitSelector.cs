// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDistanceUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitSelectors
{
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Distance"/> unit selector.
    /// </summary>
    public interface IDistanceUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the meter.
        /// </summary>
        /// <value>
        /// The meter <see cref="Expression"/>.
        /// </value>
        Expression Meters { get; }

        /// <summary>
        /// Gets the mile.
        /// </summary>
        /// <value>
        /// The mile <see cref="Expression"/>.
        /// </value>
        Expression Miles { get; }

        /// <summary>
        /// Gets the feet.
        /// </summary>
        /// <value>
        /// The feet <see cref="Expression"/>.
        /// </value>
        Expression Feet { get; }

        /// <summary>
        /// Gets the inch.
        /// </summary>
        /// <value>
        /// The inch <see cref="Expression"/>.
        /// </value>
        Expression Inches { get; }

        /// <summary>
        /// Gets the nautical mile.
        /// </summary>
        /// <value>
        /// The nautical mile <see cref="Expression"/>.
        /// </value>
        Expression NauticalMiles { get; }

        /// <summary>
        /// Gets the yard.
        /// </summary>
        /// <value>
        /// The yard <see cref="Expression"/>.
        /// </value>
        Expression Yards { get; }
    }
}