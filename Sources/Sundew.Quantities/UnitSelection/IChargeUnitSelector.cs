// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IChargeUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;

    /// <summary>
    /// Interface for <see cref="Charge"/> unit selector.
    /// </summary>
    public interface IChargeUnitSelector : IElectricCurrentUnitSelector, ITimeUnitSelector
    {
        /// <summary>
        /// Gets the coulomb.
        /// </summary>
        /// <value>
        /// The coulomb.
        /// </value>
        Expression Coulombs { get; }
    }
}