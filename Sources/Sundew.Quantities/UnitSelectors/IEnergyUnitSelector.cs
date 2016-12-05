// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEnergyUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitSelectors
{
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Energy"/> unit selector.
    /// </summary>
    public interface IEnergyUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the Joule.
        /// </summary>
        /// <value>
        /// The Joule.
        /// </value>
        Expression Joules { get; }
    }
}