// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPowerUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitSelectors
{
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Power"/> unit selector.
    /// </summary>
    public interface IPowerUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the watt.
        /// </summary>
        /// <value>
        /// The watt <see cref="Expression"/>.
        /// </value>
        Expression Watts { get; }
    }
}