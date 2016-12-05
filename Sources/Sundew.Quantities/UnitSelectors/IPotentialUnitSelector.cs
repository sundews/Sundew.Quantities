// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPotentialUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitSelectors
{
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Potential"/> unit selector.
    /// </summary>
    public interface IPotentialUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the volt.
        /// </summary>
        /// <value>
        /// The volt <see cref="Expression"/>.
        /// </value>
        Expression Volts { get; }
    }
}