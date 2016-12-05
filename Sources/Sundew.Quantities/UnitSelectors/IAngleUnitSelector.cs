// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAngleUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitSelectors
{
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Angle"/> unit selector.
    /// </summary>
    public interface IAngleUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the radian.
        /// </summary>
        /// <value>
        /// The radian.
        /// </value>
        Expression Radians { get; }

        /// <summary>
        /// Gets the degrees.
        /// </summary>
        /// <value>
        /// The degrees.
        /// </value>
        Expression Degrees { get; }

        /// <summary>
        /// Gets the turns.
        /// </summary>
        /// <value>
        /// The turns.
        /// </value>
        Expression Turns { get; }
    }
}