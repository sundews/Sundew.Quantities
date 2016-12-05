// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IResistanceUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitSelectors
{
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Resistance"/> unit selector.
    /// </summary>
    public interface IResistanceUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the ohm.
        /// </summary>
        /// <value>
        /// The ohm <see cref="Expression"/>.
        /// </value>
        Expression Ohms { get; }
    }
}