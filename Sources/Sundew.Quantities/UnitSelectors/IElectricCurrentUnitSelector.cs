// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IElectricCurrentUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitSelectors
{
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.UnitSelection;

    /// <summary>
    /// Interface for <see cref="ElectricCurrent"/> unit selector.
    /// </summary>
    public interface IElectricCurrentUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the ampere.
        /// </summary>
        /// <value>
        /// The ampere.
        /// </value>
        Expression Amperes { get; }
    }
}