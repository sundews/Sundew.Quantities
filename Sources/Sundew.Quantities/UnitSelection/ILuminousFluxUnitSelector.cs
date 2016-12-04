// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ILuminousFluxUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="LuminousFlux"/> unit selector.
    /// </summary>
    public interface ILuminousFluxUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the lumen.
        /// </summary>
        /// <value>
        /// The lumen.
        /// </value>
        Expression Lumens { get; }
    }
}