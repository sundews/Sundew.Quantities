// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISolidAngleUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitSelectors
{
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.UnitSelection;

    /// <summary>
    /// Interface for <see cref="SolidAngle"/> unit selector.
    /// </summary>
    public interface ISolidAngleUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the steradian.
        /// </summary>
        /// <value>
        /// The steradian.
        /// </value>
        Expression Steradians { get; }
    }
}