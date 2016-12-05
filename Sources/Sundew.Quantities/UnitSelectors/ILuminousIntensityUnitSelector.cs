// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ILuminousIntensityUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitSelectors
{
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.UnitSelection;

    /// <summary>
    /// Interface for <see cref="LuminousIntensity"/> unit selector.
    /// </summary>
    public interface ILuminousIntensityUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the candela.
        /// </summary>
        /// <value>
        /// The candelas.
        /// </value>
        Expression Candelas { get; }
    }
}