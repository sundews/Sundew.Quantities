// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICapacitanceUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitSelectors
{
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Capacitance"/> unit selector.
    /// </summary>
    public interface ICapacitanceUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the Farad.
        /// </summary>
        /// <value>
        /// The Farad.
        /// </value>
        Expression Farads { get; }
    }
}