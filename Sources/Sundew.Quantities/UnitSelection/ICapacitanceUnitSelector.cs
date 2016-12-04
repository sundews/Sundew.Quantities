// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICapacitanceUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

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