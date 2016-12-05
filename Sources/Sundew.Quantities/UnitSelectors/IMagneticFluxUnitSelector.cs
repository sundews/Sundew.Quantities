// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMagneticFluxUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitSelectors
{
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.UnitSelection;

    /// <summary>
    /// Interface for <see cref="MagneticFlux"/> unit selector.
    /// </summary>
    public interface IMagneticFluxUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the Weber.
        /// </summary>
        /// <value>
        /// The Weber.
        /// </value>
        Expression Webers { get; }
    }
}