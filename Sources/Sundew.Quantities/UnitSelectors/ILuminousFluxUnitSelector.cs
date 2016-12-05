// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ILuminousFluxUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitSelectors
{
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.UnitSelection;

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