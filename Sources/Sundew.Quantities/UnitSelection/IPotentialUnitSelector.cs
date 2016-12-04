// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPotentialUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Sundew.Quantities.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

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