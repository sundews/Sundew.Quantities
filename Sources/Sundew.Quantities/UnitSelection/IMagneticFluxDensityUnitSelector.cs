// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMagneticFluxDensityUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="MagneticFluxDensity"/> unit selector.
    /// </summary>
    public interface IMagneticFluxDensityUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the Tesla.
        /// </summary>
        /// <value>
        /// The Tesla.
        /// </value>
        Expression Teslas { get; }
    }
}